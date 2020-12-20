using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace Wallhaven_Downloader_V2 {
    public partial class Main : Form{
        public string APIKey = null;
        public SearchParameters search_params = new SearchParameters();
        List<Collection> Collections = new List<Collection>();
        bool started = false;
        int total_downloaded = 0;
        int selected_collection = 0;
        public Main(){
            InitializeComponent();
            this.MaximizeBox = false;
            SortingComboBox.SelectedIndex = 0;
            colorDialog1.FullOpen = true;
            DownloadProgressBar.Minimum = 0;
            DownloadProgressBar.Step = 1;
        }

        public JObject GetJsonFromURL(string url) {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            JObject result = new JObject();
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), UTF8Encoding.ASCII)) {
                string response_text = reader.ReadToEnd();
                result = JObject.Parse(response_text);
            }
            return result;
        }

        void DownloadImagesFromList(object data) {
            ThreadParams thread_params = (ThreadParams)data;
            int thread_id = thread_params.thread_id;
            List<Image> images = thread_params.images;
            int total_to_download = thread_params.total_to_download;
            long total_size = 0;
            Logpush($"[Thread-{thread_id}]Started, received {images.Count} images to process...");
            string save_path = Properties.Settings.Default.SavePath;
            int downloaded = 0;
            if (save_path == "Downloads") {
                save_path = AppDomain.CurrentDomain.BaseDirectory + '\\' + save_path;
            }
            if (!Directory.Exists(save_path)) {
                Directory.CreateDirectory(save_path);
            }
            using (WebClient client = new WebClient()) {
                foreach (var image in images) {
                    try {
                        if (!File.Exists(save_path + '\\' + image.filename)) {
                            client.DownloadFile(image.url, save_path + '\\' + image.filename);
                            FileInfo file = new FileInfo(save_path + '\\' + image.filename);
                            total_size += file.Length / 1024;
                            downloaded += 1;
                            total_downloaded += 1;
                        }
                        else {
                            Logpush($"[Thread-{thread_id}]Warn: File {image.filename} already exists!");
                        }
                    }
                    catch (WebException e) {
                        Logpush($"[Thread-{thread_id}]Error while downloading {image.url}");
                        Logpush(e.ToString());
                    }
                    if (!started) {
                        break;
                    }
                    AddProgressBarStep();
                }
            }
            if (!started) {
                Logpush($"[Thread-{thread_id}]Cancel signal received!");
            }
            Logpush($"[Thread-{thread_id}]Done, {downloaded} images, total size: {total_size}");
        }

        delegate void SetLogpushCallback(string text);
        void Logpush(string text) {
            if (LogTextBox.InvokeRequired) {
                SetLogpushCallback d = new SetLogpushCallback(Logpush);
                Invoke(d, new object[] { text });
            }
            else {
                LogTextBox.Text += text + "\n";
            }
        }

        delegate void ProgressBarSetterCallback(int maxvalue);
        void SetMaxProgressBar(int maxvalue) {
            if (DownloadProgressBar.InvokeRequired) {
                ProgressBarSetterCallback d = new ProgressBarSetterCallback(SetMaxProgressBar);
                Invoke(d, new object[] { maxvalue });
            }
            else {
                DownloadProgressBar.Maximum = maxvalue;
            }
        }

        delegate void ProgressBarSetValueCallback(int value);
        void ProgressBarSetValue(int value) {
            if (DownloadProgressBar.InvokeRequired) {
                ProgressBarSetValueCallback d = new ProgressBarSetValueCallback(ProgressBarSetValue);
                Invoke(d, new object[] { value });
            }
            else {
                DownloadProgressBar.Value = value;
            }
        }

        delegate void ProgressBarAddCallback();
        void AddProgressBarStep() {
            if (DownloadProgressBar.InvokeRequired) {
                ProgressBarAddCallback d = new ProgressBarAddCallback(AddProgressBarStep);
                Invoke(d, new object[] { });
            }
            else {
                DownloadProgressBar.PerformStep();
            }
        }
        private void AdvancedSearchPage_KeyPressed(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void ThreadsTextBox_KeyPressed(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8) {
                e.Handled = true;
            }
        }

        private void AmountToDownloadTextBox_KeyPressed(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8) {
                e.Handled = true;
            }
        }

        private void LogTextBox_TextChanged(object sender, EventArgs e) {
            LogTextBox.SelectionStart = LogTextBox.Text.Length;
            LogTextBox.ScrollToCaret();
        }

        private void Main_Shown(object sender, EventArgs e){
            Logpush($"===[Application Settings]===\n[APIKey]={APIKey}\n[Threads]={Properties.Settings.Default.Threads}\n" +
                $"[SavePath]={Properties.Settings.Default.SavePath}\n=======================");
            ThreadsTextBox.Text = Properties.Settings.Default.Threads.ToString();
            if (APIKey != "") {
                Logpush("API Key detected, please wait while search parameters being fetch...");
                FiltersGroupBox.Enabled = false;
                SearchSettingsGroupBox.Enabled = false;
                ImageSourceGroupBox.Enabled = false;
                JObject search_settings = GetJsonFromURL($"https://wallhaven.cc/api/v1/settings?apikey={APIKey}");
                search_params.ConvertFromJson(search_settings);
                Logpush("Search parameters... OK!");
            }
            else {
                PurityNSFWCheckbox.Enabled = false;
            }
            UpdateShownSettings();

        }

        private void UpdateShownSettings() {
            FiltersGroupBox.Enabled = true;
            SearchSettingsGroupBox.Enabled = true;
            ImageSourceGroupBox.Enabled = true;
            if (search_params.categories[0] == '1') {
                CategoriesGeneralCheckbox.Checked = true;
            }
            if (search_params.categories[1] == '1') {
                CategoriesAnimeCheckbox.Checked = true;
            }
            if (search_params.categories[2] == '1') {
                CategoriesPeopleCheckBox.Checked = true;
            }
            if (search_params.purity[0] == '1') {
                PuritySFWCheckbox.Checked = true;
            }
            if (search_params.purity[1] == '1') {
                PuritySketchyCheckbox.Checked = true;
            }
            if (search_params.purity[2] == '1') {
                PurityNSFWCheckbox.Checked = true;
            }
            RatioListBox.Items.Clear();
            if (search_params.ratios.Count > 0) {
                RatioEnabledCheckbox.Checked = true;
                foreach (var ratio in search_params.ratios) {
                    RatioListBox.Items.Add(ratio);
                }
            }
            else {
                RatioRemoveButton.Enabled = false;
            }
            ResolutionListBox.Items.Clear();
            if (search_params.resolutions.Count > 0) {
                ResolutionsEnabledCheckbox.Checked = true;
                ResolutionFromListRadioButton.Checked = true;
                foreach (var resolution in search_params.resolutions) {
                    ResolutionListBox.Items.Add(resolution);
                }
            }
            else {
                ResolutionButtonRemove.Enabled = false;
            }
            ColorListBox.Items.Clear();
            if (search_params.colors.Count > 0) {
                ColorEnableCheckbox.Checked = true;
                foreach (var color in search_params.colors) {
                    ColorListBox.Items.Add(color);
                }
            }
            else {
                ResolutionButtonRemove.Enabled = false;
            }
            switch (search_params.topRange) {
                case "1d":
                    TopListComboBox.SelectedIndex = 0;
                    break;
                case "3d":
                    TopListComboBox.SelectedIndex = 1;
                    break;
                case "1w":
                    TopListComboBox.SelectedIndex = 2;
                    break;
                case "1M":
                    TopListComboBox.SelectedIndex = 3;
                    break;
                case "3M":
                    TopListComboBox.SelectedIndex = 4;
                    break;
                case "6M":
                    TopListComboBox.SelectedIndex = 5;
                    break;
                case "1y":
                    TopListComboBox.SelectedIndex = 6;
                    break;
            }
            ImageSourceCollectionsListBox.Items.Clear();
            if (Collections.Count > 0) {
                foreach (var collection in Collections) {
                    ImageSourceCollectionsListBox.Items.Add($"{collection.name} (ID: {collection.id}, User: {collection.owner})");
                }
            }
        }

        delegate void SetLockInterfaceCallback();
        public void LockInterface() {
            if (FiltersGroupBox.InvokeRequired || SearchSettingsGroupBox.InvokeRequired ||
                ImageSourceGroupBox.InvokeRequired || DownloadButton.InvokeRequired ||
                ThreadsTextBox.InvokeRequired || SavePathButton.InvokeRequired ||
                LogoutButton.InvokeRequired || CancelButton.InvokeRequired || InvokeRequired) {
                SetLockInterfaceCallback d = new SetLockInterfaceCallback(LockInterface);
                Invoke(d, new object[] { });
            }
            else {
                FiltersGroupBox.Enabled = false;
                SearchSettingsGroupBox.Enabled = false;
                ImageSourceGroupBox.Enabled = false;
                ControlBox = false;
                DownloadButton.Enabled = false;
                ThreadsTextBox.Enabled = false;
                SavePathButton.Enabled = false;
                LogoutButton.Enabled = false;
                CancelButton.Enabled = true;
            }
        }

        delegate void SetUnlockInterfaceCallback();
        public void UnLockInterface() {
            if (FiltersGroupBox.InvokeRequired || SearchSettingsGroupBox.InvokeRequired ||
                ImageSourceGroupBox.InvokeRequired || DownloadButton.InvokeRequired ||
                ThreadsTextBox.InvokeRequired || SavePathButton.InvokeRequired ||
                LogoutButton.InvokeRequired || CancelButton.InvokeRequired || InvokeRequired) {
                SetUnlockInterfaceCallback d = new SetUnlockInterfaceCallback(UnLockInterface);
                Invoke(d, new object[] { });
            }
            else {
                FiltersGroupBox.Enabled = true;
                SearchSettingsGroupBox.Enabled = true;
                ImageSourceGroupBox.Enabled = true;
                ControlBox = true;
                DownloadButton.Enabled = true;
                ThreadsTextBox.Enabled = true;
                SavePathButton.Enabled = true;
                LogoutButton.Enabled = true;
                CancelButton.Enabled = false;
            }
        }

        private void CategoriesGeneralCheckbox_CheckedChanged(object sender, EventArgs e) {
            StringBuilder changed_category_value = new StringBuilder(search_params.categories);
            if (CategoriesGeneralCheckbox.Checked) {
                changed_category_value[0] = '1';
            }
            else {
                changed_category_value[0] = '0';
            }
            search_params.categories = changed_category_value.ToString();
        }

        private void CategoriesAnimeCheckbox_CheckedChanged(object sender, EventArgs e) {
            StringBuilder changed_category_value = new StringBuilder(search_params.categories);
            if (CategoriesAnimeCheckbox.Checked) {
                changed_category_value[1] = '1';
            }
            else {
                changed_category_value[1] = '0';
            }
            search_params.categories = changed_category_value.ToString();
        }

        private void CategoriesPeopleCheckBox_CheckedChanged(object sender, EventArgs e) {
            StringBuilder changed_category_value = new StringBuilder(search_params.categories);
            if (CategoriesPeopleCheckBox.Checked) {
                changed_category_value[2] = '1';
            }
            else {
                changed_category_value[2] = '0';
            }
            search_params.categories = changed_category_value.ToString();
        }

        private void PuritySFWCheckbox_CheckedChanged(object sender, EventArgs e) {
            StringBuilder changed_purity_value = new StringBuilder(search_params.purity);
            if (PuritySFWCheckbox.Checked) {
                changed_purity_value[0] = '1';
            }
            else {
                changed_purity_value[0] = '0';
            }
            search_params.purity = changed_purity_value.ToString();
        }
        private void PuritySketchyCheckbox_CheckedChanged(object sender, EventArgs e) {
            StringBuilder changed_purity_value = new StringBuilder(search_params.purity);
            if (PuritySketchyCheckbox.Checked) {
                changed_purity_value[1] = '1';
            }
            else {
                changed_purity_value[1] = '0';
            }
            search_params.purity = changed_purity_value.ToString();
        }
        private void PurityNSFWCheckbox_CheckedChanged(object sender, EventArgs e) {
            StringBuilder changed_purity_value = new StringBuilder(search_params.purity);
            if (PurityNSFWCheckbox.Checked) {
                changed_purity_value[2] = '1';
            }
            else {
                changed_purity_value[2] = '0';
            }
            search_params.purity = changed_purity_value.ToString();
        }
        private void RatioEnabledCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (RatioEnabledCheckbox.Checked) {
                RatioAddButton.Enabled = true;
                RatioListBox.Enabled = true;
            }
            else {
                RatioAddButton.Enabled = false;
                RatioListBox.Enabled = false;
                RatioRemoveButton.Enabled = false;
                search_params.ratios = new List<String>();
                UpdateShownSettings();
            }
        }

        private void RatioAddButton_Click(object sender, EventArgs e){
            using (var form = new UserInput()) {
                var result = form.ShowDialog();
                if (result == DialogResult.OK) {
                    var new_ratio = form.input_result;
                    search_params.ratios.Add(new_ratio);
                    UpdateShownSettings();
                }
            }
        }

        private void RatioListBox_IndexChanged(object sender, EventArgs e) {
            RatioRemoveButton.Enabled = true;
        }

        private void RatioRemoveButton_Click(object sender, EventArgs e) {
            search_params.ratios.Remove(RatioListBox.SelectedItem.ToString());
            UpdateShownSettings();
        }

        private void ResolutionsEnabledCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (ResolutionsEnabledCheckbox.Checked) {
                ResolutionAtleastRadioButton.Enabled = true;
                ResolutionAtleastRadioButton.Checked = true;
                ResolutionAtleastWidth.Enabled = true;
                ResolutionAtleastHeight.Enabled = true;
                ResolutionFromListRadioButton.Enabled = true;
            }
            else {
                ResolutionAtleastRadioButton.Enabled = false;
                ResolutionAtleastRadioButton.Checked = false;
                ResolutionFromListRadioButton.Checked = false;
                ResolutionAtleastWidth.Enabled = false;
                ResolutionAtleastWidth.Text = "";
                ResolutionAtleastHeight.Enabled = false;
                ResolutionAtleastHeight.Text = "";
                ResolutionFromListRadioButton.Enabled = false;
                ResolutionButtonAdd.Enabled = false;
                ResolutionListBox.Enabled = false;
                ResolutionButtonRemove.Enabled = false;
                search_params.resolutions = new List<String>();
                search_params.atleast = "";
                UpdateShownSettings();
            }
        }

        private void ResolutionFromListRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (ResolutionFromListRadioButton.Checked) {
                ResolutionButtonAdd.Enabled = true;
                ResolutionListBox.Enabled = true;
                ResolutionAtleastWidth.Text = "";
                ResolutionAtleastHeight.Text = "";
            }
            else {
                ResolutionButtonAdd.Enabled = false;
                ResolutionButtonRemove.Enabled = false;
                search_params.resolutions = new List<String>();
                UpdateShownSettings();
            }
        }

        private void ResolutionButtonAdd_Click(object sender, EventArgs e) {
            using (var form = new UserInput()) {
                var result = form.ShowDialog();
                if (result == DialogResult.OK) {
                    var new_ratio = form.input_result;
                    search_params.resolutions.Add(new_ratio);
                    UpdateShownSettings();
                }
            }
        }

        private void ResolutionButtonRemove_Click(object sender, EventArgs e) {
            search_params.resolutions.Remove(ResolutionListBox.SelectedItem.ToString());
            UpdateShownSettings();
        }

        private void ResolutionsListBox_IndexChanged(object sender, EventArgs e) {
            ResolutionButtonRemove.Enabled = true;
        }

        private void ColorEnableCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (ColorEnableCheckbox.Checked) {
                ColorAddColorButton.Enabled = true;
                ColorListBox.Enabled = true;
            }
            else {
                ColorAddColorButton.Enabled = false;
                ColorListBox.Enabled = false;
                ColorRemoveColorButton.Enabled = false;
                search_params.colors = new List<String>();
                UpdateShownSettings();
            }
        }

        private void ColorListBox_IndexChanged(object sender, EventArgs e) {
            ColorRemoveColorButton.Enabled = true;
        }

        private void ColorAddColorButton_Click(object sender, EventArgs e) {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                var new_color = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                search_params.colors.Add(new_color);
                UpdateShownSettings();
            }
        }

        private void ColorRemoveColorButton_Click(object sender, EventArgs e) {
            search_params.colors.Remove(ColorListBox.SelectedItem.ToString());
            UpdateShownSettings();
        }

        private void OrderAscendingRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (OrderAscendingRadioButton.Checked) {
                search_params.order = "asc";
            }
        }

        private void OrderDescendingRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (OrderDescendingRadioButton.Checked) {
                search_params.order = "desc";
            }
        }

        private void SortingComboBox_IndexChanged(object sender, EventArgs e) {
            string new_value = "date_added";
            TopListComboBox.Enabled = false;
            AdvancedSearchSeed.Enabled = false;
            switch (SortingComboBox.SelectedIndex) {
                case 0:
                    new_value = "date_added";
                    break;
                case 1:
                    new_value = "relevance";
                    break;
                case 2:
                    new_value = "random";
                    AdvancedSearchSeed.Enabled = true;
                    break;
                case 3:
                    new_value = "views";
                    break;
                case 4:
                    new_value = "favorites";
                    break;
                case 5:
                    new_value = "toplist";
                    TopListComboBox.Enabled = true;
                    break;
            }
            search_params.sorting = new_value;
        }

        private void AdvancedSearchEnabled_CheckedChanged(object sender, EventArgs e) {
            if (AdvancedSearchEnabled.Checked) {
                PageSelectorRadioButton.Enabled = true;
                PagesRangeSelectorRadioButton.Enabled = true;
                if (PageSelectorRadioButton.Checked) {
                    AdvancedSearchPage.Enabled = true;
                }
                if (PagesRangeSelectorRadioButton.Checked) {
                    PagesRangeBegin.Enabled = true;
                    PagesRangeEnd.Enabled = true;
                }
            }
            else {
                AdvancedSearchPage.Enabled = false;
                AdvancedSearchSeed.Enabled = false;
                PageSelectorRadioButton.Enabled = false;
                PagesRangeSelectorRadioButton.Enabled = false;
                PagesRangeBegin.Enabled = false;
                PagesRangeEnd.Enabled = false;
            }
        }

        private void ImageSourceUserCollectionsRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (ImageSourceUserCollectionsRadioButton.Checked) {
                ImageSourceUsername.Enabled = true;
                ImageSourceFetchCollections.Enabled = true;
                ImageSourceCollectionsListBox.Enabled = true;
            }
            else {
                ImageSourceUsername.Enabled = false;
                ImageSourceFetchCollections.Enabled = false;
                ImageSourceCollectionsListBox.Enabled = false;
            }
        }

        private void ImageSourceFetchCollections_Click(object sender, EventArgs e) {
            if (ImageSourceUsername.Text != "") {
                Logpush($"Fetching {ImageSourceUsername.Text} collections...");
                JObject collections_response  = GetJsonFromURL($"https://wallhaven.cc/api/v1/collections/{ImageSourceUsername.Text}?apikey={APIKey}");
                foreach (var col in collections_response.SelectToken("data")) {
                    Collections.Add(new Collection(col["label"].ToString(), Int32.Parse(col["id"].ToString()), ImageSourceUsername.Text));
                }
                UpdateShownSettings();
                if (Collections.Count > 0) {
                    ImageSourceCollectionsListBox.SelectedIndex = 0;
                }
            }
            else {
                MessageBox.Show("Username cannot be empty!");
            }
        }

        private void TopListComboBox_IndexChanged(object sender, EventArgs e) {
            switch (TopListComboBox.SelectedIndex) {
                case 0:
                    search_params.topRange = "1d";
                    break;
                case 1:
                    search_params.topRange = "3d";
                    break;
                case 2:
                    search_params.topRange = "1w";
                    break;
                case 3:
                    search_params.topRange = "1M";
                    break;
                case 4:
                    search_params.topRange = "3M";
                    break;
                case 5:
                    search_params.topRange = "6M";
                    break;
                case 6:
                    search_params.topRange = "1y";
                    break;
            }
        }

        private void SavePathButton_Click(object sender, EventArgs e) {
            folderBrowserDialog1.Description = "Save images to...";
            folderBrowserDialog1.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                Properties.Settings.Default.SavePath = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
                Logpush($"New save path: {Properties.Settings.Default.SavePath}");
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
                Properties.Settings.Default.APIKey = "";
                Properties.Settings.Default.Save();
                Close();
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e) {
            new Thread(delegate () {
                started = true;
                DateTime start = DateTime.Now;
                LockInterface();
                Logpush("===WORK BEGIN===");
                Logpush("Prepearing for download...");
                ProgressBarSetValue(0);
                List<Image> Images = new List<Image>();
                int threads_requested = Int32.Parse(ThreadsTextBox.Text);
                Properties.Settings.Default.Threads = threads_requested;
                Properties.Settings.Default.Save();
                int target_amount;
                if (AmountToDownloadTextBox.Text != "") {
                    target_amount = Int32.Parse(AmountToDownloadTextBox.Text);
                }
                else {
                    target_amount = 0;
                }
                if (ResolutionsEnabledCheckbox.Checked & ResolutionAtleastWidth.Text != "" & ResolutionAtleastHeight.Text != "") {
                    search_params.atleast = ResolutionAtleastWidth.Text + "x" + ResolutionAtleastHeight.Text; 
                }
                if (PageSelectorRadioButton.Checked) {
                    if (AdvancedSearchPage.Text != "" & AdvancedSearchPage.Text != "0") {
                        search_params.page = Int32.Parse(AdvancedSearchPage.Text);
                    }
                    else {
                        search_params.page = 1;
                    }
                }
                else {
                    if (PagesRangeSelectorRadioButton.Checked) {
                        Logpush("Range selected, calculating values...");
                        int range_begin = Int32.Parse(PagesRangeBegin.Text);
                        int range_end = Int32.Parse(PagesRangeEnd.Text);
                        int range_delta = range_end - range_begin;
                        if (range_delta > 0) {
                            search_params.page = range_begin;
                            search_params.end_page = range_end;
                            Logpush($"New params: target_amount = {target_amount}, page = {search_params.page}");
                        }
                        else {
                            MessageBox.Show("Begin page cannot be grater or equal to end page.");
                            started = false;
                        }
                    }
                }
                if (AdvancedSearchSeed.Text != "") {
                    search_params.seed = AdvancedSearchSeed.Text;
                }
                else {
                    search_params.seed = "";
                }

                if (started) {
                    Logpush("This might take a while. (Images fetched at rate of 64/1.34s)");
                    Logpush("[Stage 1/2: URL fetching]");
                    if (ImageSourceSearchRadioButton.Checked) {
                        Logpush("Image source: Search");
                        search_params.q = WebUtility.UrlEncode(ImageSourceSearchQuery.Text);
                        string request_url = $"https://wallhaven.cc/api/v1/search?{search_params}&apikey={APIKey}";
                        JObject probe = GetJsonFromURL(request_url);
                        if (target_amount == 0) {
                            target_amount = Int32.Parse(probe.SelectToken("meta.total").ToString());
                            Logpush($"Amount set to {target_amount} as it was 0");
                        }
                        else {
                            Logpush("Amount will be used to determine when to stop.");
                        }
                        if (search_params.end_page == 0) {
                            search_params.end_page = Int32.Parse(probe.SelectToken("meta.last_page").ToString());
                            Logpush($"End page set to {search_params.end_page} as it was 0");
                        }
                        else {
                            Logpush("Eng page will be used to determine where to stop.");
                        }
                        if (probe.SelectToken("meta.seed").ToString() != "") {
                            search_params.seed = probe.SelectToken("meta.seed").ToString();
                            Logpush($"New seed: {search_params.seed}");
                        }
                        ProgressBarSetValue(0);
                        if (PagesRangeSelectorRadioButton.Checked) {
                            SetMaxProgressBar((1 + search_params.end_page - search_params.page) * (Int32.Parse(probe.SelectToken("meta.per_page").ToString())));
                        }
                        else {
                            SetMaxProgressBar(target_amount);
                        }
                        while ((Images.Count < target_amount & search_params.page <= search_params.end_page) & started) {
                            Thread.Sleep(1340);
                            foreach (var image in probe.SelectToken("data")) {
                                Images.Add(new Image(image["id"].ToString(), image["path"].ToString()));
                                ProgressBarSetValue(Images.Count);
                                if (Images.Count >= target_amount) {
                                    break;
                                }
                            }
                            search_params.page++;
                            request_url = $"https://wallhaven.cc/api/v1/search?{search_params}&apikey={APIKey}";
                            probe = GetJsonFromURL(request_url);
                        }
                    }
                    else {
                        if (ImageSourceUserCollectionsRadioButton.Checked) {
                            Logpush("Image source: User collection");
                            if (Collections.Count > 0) {
                                Collection target_collection = Collections[selected_collection];
                                Logpush($"Selected collection is {target_collection.name}, ID: {target_collection.id}, User: {target_collection.owner}");
                                Logpush("Warn: Only Purity filter can be aplied to collections!");
                                string base_url = $"https://wallhaven.cc/api/v1/collections/{target_collection.owner}/{target_collection.id}";
                                JObject response = GetJsonFromURL(base_url + $"?purity={search_params.purity}&page={search_params.page}&apikey={APIKey}");
                                if (target_amount == 0) {
                                    target_amount = Int32.Parse(response.SelectToken("meta.total").ToString());
                                    Logpush($"Amount set to {target_amount} as it was 0");
                                }
                                else {
                                    Logpush("Amount will be used to determine when to stop.");
                                }
                                if (search_params.end_page == 0) {
                                    search_params.end_page = Int32.Parse(response.SelectToken("meta.last_page").ToString());
                                    Logpush($"End page set to {search_params.end_page} as it was 0");
                                }
                                else {
                                    Logpush("Eng page will be used to determine where to stop.");
                                }
                                ProgressBarSetValue(0);
                                if (PagesRangeSelectorRadioButton.Checked) {
                                    SetMaxProgressBar((1 + search_params.end_page - search_params.page) * (Int32.Parse(response.SelectToken("meta.per_page").ToString())));
                                }
                                else {
                                    SetMaxProgressBar(target_amount);
                                }
                                while ((Images.Count < target_amount & search_params.page <= search_params.end_page) & started) {
                                    Thread.Sleep(1340);
                                    foreach (var image in response.SelectToken("data")) {
                                        Images.Add(new Image(image["id"].ToString(), image["path"].ToString()));
                                        ProgressBarSetValue(Images.Count);
                                        if (Images.Count >= target_amount) {
                                            break;
                                        }
                                    }
                                    search_params.page++;
                                    response = GetJsonFromURL(base_url + $"?purity={search_params.purity}&page={search_params.page}&apikey={APIKey}");
                                }
                            }
                            else {
                                MessageBox.Show("User collection not specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                started = false;
                            }
                        }
                    }

                    if (started) {
                        Logpush("[Stage 2/2: Download]");
                        Logpush("Prepearing download workers...");
                        ProgressBarSetValue(0);
                        SetMaxProgressBar(Images.Count);
                        int chunk_size = 0;
                        int threads_to_spawn = Properties.Settings.Default.Threads;
                        List<Thread> Threads = new List<Thread>();
                        if (Images.Count > threads_to_spawn) {
                            chunk_size = Images.Count / threads_to_spawn;
                        }
                        else {
                            threads_to_spawn = Images.Count;
                        }
                        for (int i = 0; i < threads_to_spawn; i++) {
                            Threads.Add(new Thread(new ParameterizedThreadStart(DownloadImagesFromList)));
                        }

                        Logpush("Starting download workers...");
                        int ii = 0;
                        int amount_selector = chunk_size;
                        foreach (var thread in Threads) {
                            if (ii + 1 == Threads.Count) {
                                amount_selector = Images.Count - ii * chunk_size;
                            }
                            thread.Start(new ThreadParams(Images.GetRange(ii * chunk_size, amount_selector), ii, Images.Count));
                            ii++;
                        }
                        foreach (var thread in Threads) {
                            while (thread.IsAlive) {
                                Thread.Sleep(1000);
                            }
                        }
                    }
                }

                if (!started) {
                    Logpush("Cancel signal was received, work might be unfinished!");
                }
                Logpush($"Done in {DateTime.Now - start}");
                Logpush("===ALL DONE===");
                started = false;
                total_downloaded = 0;
                UnLockInterface();
            }).Start();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            started = false;
            Logpush("[Cancel] Signal send, please wait for main and workers threads to respond...");
        }

        private void ImageSourceCollectionsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            selected_collection = ImageSourceCollectionsListBox.SelectedIndex;
        }

        private void PageSelectorRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (PageSelectorRadioButton.Checked) {
                AdvancedSearchPage.Enabled = true;
            }
            else {
                AdvancedSearchPage.Enabled = false;
            }
        }

        private void PagesRangeSelectorRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (PagesRangeSelectorRadioButton.Checked) {
                PagesRangeBegin.Enabled = true;
                PagesRangeEnd.Enabled = true;
                AmountToDownloadTextBox.Enabled = false;
            }
            else {
                PagesRangeBegin.Enabled = false;
                PagesRangeEnd.Enabled = false;
                AmountToDownloadTextBox.Enabled = true;
            }
        }

        private void PagesRangeBegin_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8) {
                e.Handled = true;
            }
        }

        private void PagesRangeEnd_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8) {
                e.Handled = true;
            }
        }
    }
}
