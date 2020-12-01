
namespace Wallhaven_Downloader_V2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.FiltersGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorRemoveColorButton = new System.Windows.Forms.Button();
            this.ColorAddColorButton = new System.Windows.Forms.Button();
            this.ColorListBox = new System.Windows.Forms.ListBox();
            this.ColorEnableCheckbox = new System.Windows.Forms.CheckBox();
            this.RatioGroupBox = new System.Windows.Forms.GroupBox();
            this.RatioListBox = new System.Windows.Forms.ListBox();
            this.RatioRemoveButton = new System.Windows.Forms.Button();
            this.RatioAddButton = new System.Windows.Forms.Button();
            this.RatioEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.ResolutionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ResolutionsEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.ResolutionButtonRemove = new System.Windows.Forms.Button();
            this.ResolutionButtonAdd = new System.Windows.Forms.Button();
            this.ResolutionListBox = new System.Windows.Forms.ListBox();
            this.ResolutionFromListRadioButton = new System.Windows.Forms.RadioButton();
            this.ResolutionAtleastHeight = new System.Windows.Forms.TextBox();
            this.ColorsGroupBox = new System.Windows.Forms.Label();
            this.ResolutionAtleastWidth = new System.Windows.Forms.TextBox();
            this.ResolutionAtleastRadioButton = new System.Windows.Forms.RadioButton();
            this.PurityGroupBox = new System.Windows.Forms.GroupBox();
            this.PurityNSFWCheckbox = new System.Windows.Forms.CheckBox();
            this.PuritySketchyCheckbox = new System.Windows.Forms.CheckBox();
            this.PuritySFWCheckbox = new System.Windows.Forms.CheckBox();
            this.CategoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoriesPeopleCheckBox = new System.Windows.Forms.CheckBox();
            this.CategoriesAnimeCheckbox = new System.Windows.Forms.CheckBox();
            this.CategoriesGeneralCheckbox = new System.Windows.Forms.CheckBox();
            this.SortingComboBox = new System.Windows.Forms.ComboBox();
            this.SortingLabel = new System.Windows.Forms.Label();
            this.OrderSortingGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopListComboBox = new System.Windows.Forms.ComboBox();
            this.OrderDescendingRadioButton = new System.Windows.Forms.RadioButton();
            this.OrderAscendingRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.AdvancedSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.PagesRangeEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PagesRangeBegin = new System.Windows.Forms.TextBox();
            this.PagesRangeSelectorRadioButton = new System.Windows.Forms.RadioButton();
            this.PageSelectorRadioButton = new System.Windows.Forms.RadioButton();
            this.AdvancedSearchSeed = new System.Windows.Forms.TextBox();
            this.AdvancedSearchSeedLabel = new System.Windows.Forms.Label();
            this.AdvancedSearchPage = new System.Windows.Forms.TextBox();
            this.AdvancedSearchEnabled = new System.Windows.Forms.CheckBox();
            this.LogGroupBox = new System.Windows.Forms.GroupBox();
            this.DownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ImageSourceGroupBox = new System.Windows.Forms.GroupBox();
            this.AmountToDownloadTextBox = new System.Windows.Forms.TextBox();
            this.ImageSourceCollectionsListBox = new System.Windows.Forms.ListBox();
            this.AmountToDownloadLabel = new System.Windows.Forms.Label();
            this.ImageSourceFetchCollections = new System.Windows.Forms.Button();
            this.ImageSourceUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ImageSourceUserCollectionsRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageSourceSearchQuery = new System.Windows.Forms.TextBox();
            this.ImageSourceSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SavePathButton = new System.Windows.Forms.Button();
            this.ThreadsTextBox = new System.Windows.Forms.TextBox();
            this.ThreadsLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FiltersGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RatioGroupBox.SuspendLayout();
            this.ResolutionsGroupBox.SuspendLayout();
            this.PurityGroupBox.SuspendLayout();
            this.CategoriesGroupBox.SuspendLayout();
            this.OrderSortingGroupBox.SuspendLayout();
            this.SearchSettingsGroupBox.SuspendLayout();
            this.AdvancedSearchGroupBox.SuspendLayout();
            this.LogGroupBox.SuspendLayout();
            this.ImageSourceGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(6, 14);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(299, 143);
            this.LogTextBox.TabIndex = 0;
            this.LogTextBox.Text = "";
            this.LogTextBox.TextChanged += new System.EventHandler(this.LogTextBox_TextChanged);
            // 
            // FiltersGroupBox
            // 
            this.FiltersGroupBox.Controls.Add(this.groupBox1);
            this.FiltersGroupBox.Controls.Add(this.RatioGroupBox);
            this.FiltersGroupBox.Controls.Add(this.ResolutionsGroupBox);
            this.FiltersGroupBox.Controls.Add(this.PurityGroupBox);
            this.FiltersGroupBox.Controls.Add(this.CategoriesGroupBox);
            this.FiltersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FiltersGroupBox.Name = "FiltersGroupBox";
            this.FiltersGroupBox.Size = new System.Drawing.Size(574, 244);
            this.FiltersGroupBox.TabIndex = 1;
            this.FiltersGroupBox.TabStop = false;
            this.FiltersGroupBox.Text = "Filters";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColorRemoveColorButton);
            this.groupBox1.Controls.Add(this.ColorAddColorButton);
            this.groupBox1.Controls.Add(this.ColorListBox);
            this.groupBox1.Controls.Add(this.ColorEnableCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(418, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 219);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // ColorRemoveColorButton
            // 
            this.ColorRemoveColorButton.Enabled = false;
            this.ColorRemoveColorButton.Location = new System.Drawing.Point(77, 190);
            this.ColorRemoveColorButton.Name = "ColorRemoveColorButton";
            this.ColorRemoveColorButton.Size = new System.Drawing.Size(67, 23);
            this.ColorRemoveColorButton.TabIndex = 11;
            this.ColorRemoveColorButton.Text = "Remove";
            this.ColorRemoveColorButton.UseVisualStyleBackColor = true;
            this.ColorRemoveColorButton.Click += new System.EventHandler(this.ColorRemoveColorButton_Click);
            // 
            // ColorAddColorButton
            // 
            this.ColorAddColorButton.Enabled = false;
            this.ColorAddColorButton.Location = new System.Drawing.Point(6, 190);
            this.ColorAddColorButton.Name = "ColorAddColorButton";
            this.ColorAddColorButton.Size = new System.Drawing.Size(65, 23);
            this.ColorAddColorButton.TabIndex = 10;
            this.ColorAddColorButton.Text = "Add";
            this.ColorAddColorButton.UseVisualStyleBackColor = true;
            this.ColorAddColorButton.Click += new System.EventHandler(this.ColorAddColorButton_Click);
            // 
            // ColorListBox
            // 
            this.ColorListBox.Enabled = false;
            this.ColorListBox.FormattingEnabled = true;
            this.ColorListBox.Location = new System.Drawing.Point(6, 42);
            this.ColorListBox.Name = "ColorListBox";
            this.ColorListBox.Size = new System.Drawing.Size(138, 134);
            this.ColorListBox.TabIndex = 9;
            this.ColorListBox.SelectedIndexChanged += new System.EventHandler(this.ColorListBox_IndexChanged);
            // 
            // ColorEnableCheckbox
            // 
            this.ColorEnableCheckbox.AutoSize = true;
            this.ColorEnableCheckbox.Location = new System.Drawing.Point(6, 19);
            this.ColorEnableCheckbox.Name = "ColorEnableCheckbox";
            this.ColorEnableCheckbox.Size = new System.Drawing.Size(65, 17);
            this.ColorEnableCheckbox.TabIndex = 3;
            this.ColorEnableCheckbox.Text = "Enabled";
            this.ColorEnableCheckbox.UseVisualStyleBackColor = true;
            this.ColorEnableCheckbox.CheckedChanged += new System.EventHandler(this.ColorEnableCheckbox_CheckedChanged);
            // 
            // RatioGroupBox
            // 
            this.RatioGroupBox.Controls.Add(this.RatioListBox);
            this.RatioGroupBox.Controls.Add(this.RatioRemoveButton);
            this.RatioGroupBox.Controls.Add(this.RatioAddButton);
            this.RatioGroupBox.Controls.Add(this.RatioEnabledCheckbox);
            this.RatioGroupBox.Location = new System.Drawing.Point(7, 115);
            this.RatioGroupBox.Name = "RatioGroupBox";
            this.RatioGroupBox.Size = new System.Drawing.Size(200, 123);
            this.RatioGroupBox.TabIndex = 4;
            this.RatioGroupBox.TabStop = false;
            this.RatioGroupBox.Text = "Ratio";
            // 
            // RatioListBox
            // 
            this.RatioListBox.FormattingEnabled = true;
            this.RatioListBox.Location = new System.Drawing.Point(77, 19);
            this.RatioListBox.Name = "RatioListBox";
            this.RatioListBox.Size = new System.Drawing.Size(120, 95);
            this.RatioListBox.TabIndex = 9;
            this.RatioListBox.SelectedIndexChanged += new System.EventHandler(this.RatioListBox_IndexChanged);
            // 
            // RatioRemoveButton
            // 
            this.RatioRemoveButton.Enabled = false;
            this.RatioRemoveButton.Location = new System.Drawing.Point(6, 86);
            this.RatioRemoveButton.Name = "RatioRemoveButton";
            this.RatioRemoveButton.Size = new System.Drawing.Size(65, 23);
            this.RatioRemoveButton.TabIndex = 8;
            this.RatioRemoveButton.Text = "Remove";
            this.RatioRemoveButton.UseVisualStyleBackColor = true;
            this.RatioRemoveButton.Click += new System.EventHandler(this.RatioRemoveButton_Click);
            // 
            // RatioAddButton
            // 
            this.RatioAddButton.Enabled = false;
            this.RatioAddButton.Location = new System.Drawing.Point(6, 51);
            this.RatioAddButton.Name = "RatioAddButton";
            this.RatioAddButton.Size = new System.Drawing.Size(65, 23);
            this.RatioAddButton.TabIndex = 7;
            this.RatioAddButton.Text = "Add";
            this.RatioAddButton.UseVisualStyleBackColor = true;
            this.RatioAddButton.Click += new System.EventHandler(this.RatioAddButton_Click);
            // 
            // RatioEnabledCheckbox
            // 
            this.RatioEnabledCheckbox.AutoSize = true;
            this.RatioEnabledCheckbox.Location = new System.Drawing.Point(6, 19);
            this.RatioEnabledCheckbox.Name = "RatioEnabledCheckbox";
            this.RatioEnabledCheckbox.Size = new System.Drawing.Size(65, 17);
            this.RatioEnabledCheckbox.TabIndex = 0;
            this.RatioEnabledCheckbox.Text = "Enabled";
            this.RatioEnabledCheckbox.UseVisualStyleBackColor = true;
            this.RatioEnabledCheckbox.CheckedChanged += new System.EventHandler(this.RatioEnabledCheckbox_CheckedChanged);
            // 
            // ResolutionsGroupBox
            // 
            this.ResolutionsGroupBox.Controls.Add(this.ResolutionsEnabledCheckbox);
            this.ResolutionsGroupBox.Controls.Add(this.ResolutionButtonRemove);
            this.ResolutionsGroupBox.Controls.Add(this.ResolutionButtonAdd);
            this.ResolutionsGroupBox.Controls.Add(this.ResolutionListBox);
            this.ResolutionsGroupBox.Controls.Add(this.ResolutionFromListRadioButton);
            this.ResolutionsGroupBox.Controls.Add(this.ResolutionAtleastHeight);
            this.ResolutionsGroupBox.Controls.Add(this.ColorsGroupBox);
            this.ResolutionsGroupBox.Controls.Add(this.ResolutionAtleastWidth);
            this.ResolutionsGroupBox.Controls.Add(this.ResolutionAtleastRadioButton);
            this.ResolutionsGroupBox.Location = new System.Drawing.Point(213, 19);
            this.ResolutionsGroupBox.Name = "ResolutionsGroupBox";
            this.ResolutionsGroupBox.Size = new System.Drawing.Size(199, 219);
            this.ResolutionsGroupBox.TabIndex = 3;
            this.ResolutionsGroupBox.TabStop = false;
            this.ResolutionsGroupBox.Text = "Resolution";
            // 
            // ResolutionsEnabledCheckbox
            // 
            this.ResolutionsEnabledCheckbox.AutoSize = true;
            this.ResolutionsEnabledCheckbox.Location = new System.Drawing.Point(6, 19);
            this.ResolutionsEnabledCheckbox.Name = "ResolutionsEnabledCheckbox";
            this.ResolutionsEnabledCheckbox.Size = new System.Drawing.Size(65, 17);
            this.ResolutionsEnabledCheckbox.TabIndex = 8;
            this.ResolutionsEnabledCheckbox.Text = "Enabled";
            this.ResolutionsEnabledCheckbox.UseVisualStyleBackColor = true;
            this.ResolutionsEnabledCheckbox.CheckedChanged += new System.EventHandler(this.ResolutionsEnabledCheckbox_CheckedChanged);
            // 
            // ResolutionButtonRemove
            // 
            this.ResolutionButtonRemove.Enabled = false;
            this.ResolutionButtonRemove.Location = new System.Drawing.Point(99, 190);
            this.ResolutionButtonRemove.Name = "ResolutionButtonRemove";
            this.ResolutionButtonRemove.Size = new System.Drawing.Size(94, 23);
            this.ResolutionButtonRemove.TabIndex = 7;
            this.ResolutionButtonRemove.Text = "Remove";
            this.ResolutionButtonRemove.UseVisualStyleBackColor = true;
            this.ResolutionButtonRemove.Click += new System.EventHandler(this.ResolutionButtonRemove_Click);
            // 
            // ResolutionButtonAdd
            // 
            this.ResolutionButtonAdd.Enabled = false;
            this.ResolutionButtonAdd.Location = new System.Drawing.Point(6, 190);
            this.ResolutionButtonAdd.Name = "ResolutionButtonAdd";
            this.ResolutionButtonAdd.Size = new System.Drawing.Size(87, 23);
            this.ResolutionButtonAdd.TabIndex = 6;
            this.ResolutionButtonAdd.Text = "Add";
            this.ResolutionButtonAdd.UseVisualStyleBackColor = true;
            this.ResolutionButtonAdd.Click += new System.EventHandler(this.ResolutionButtonAdd_Click);
            // 
            // ResolutionListBox
            // 
            this.ResolutionListBox.Enabled = false;
            this.ResolutionListBox.FormattingEnabled = true;
            this.ResolutionListBox.Location = new System.Drawing.Point(6, 90);
            this.ResolutionListBox.Name = "ResolutionListBox";
            this.ResolutionListBox.Size = new System.Drawing.Size(187, 95);
            this.ResolutionListBox.TabIndex = 5;
            this.ResolutionListBox.SelectedIndexChanged += new System.EventHandler(this.ResolutionsListBox_IndexChanged);
            // 
            // ResolutionFromListRadioButton
            // 
            this.ResolutionFromListRadioButton.AutoSize = true;
            this.ResolutionFromListRadioButton.Enabled = false;
            this.ResolutionFromListRadioButton.Location = new System.Drawing.Point(6, 67);
            this.ResolutionFromListRadioButton.Name = "ResolutionFromListRadioButton";
            this.ResolutionFromListRadioButton.Size = new System.Drawing.Size(138, 17);
            this.ResolutionFromListRadioButton.TabIndex = 4;
            this.ResolutionFromListRadioButton.TabStop = true;
            this.ResolutionFromListRadioButton.Text = "From list (single allowed)";
            this.ResolutionFromListRadioButton.UseVisualStyleBackColor = true;
            this.ResolutionFromListRadioButton.CheckedChanged += new System.EventHandler(this.ResolutionFromListRadioButton_CheckedChanged);
            // 
            // ResolutionAtleastHeight
            // 
            this.ResolutionAtleastHeight.Enabled = false;
            this.ResolutionAtleastHeight.Location = new System.Drawing.Point(148, 41);
            this.ResolutionAtleastHeight.Name = "ResolutionAtleastHeight";
            this.ResolutionAtleastHeight.Size = new System.Drawing.Size(45, 20);
            this.ResolutionAtleastHeight.TabIndex = 3;
            // 
            // ColorsGroupBox
            // 
            this.ColorsGroupBox.AutoSize = true;
            this.ColorsGroupBox.Location = new System.Drawing.Point(128, 44);
            this.ColorsGroupBox.Name = "ColorsGroupBox";
            this.ColorsGroupBox.Size = new System.Drawing.Size(14, 13);
            this.ColorsGroupBox.TabIndex = 2;
            this.ColorsGroupBox.Text = "X";
            // 
            // ResolutionAtleastWidth
            // 
            this.ResolutionAtleastWidth.Enabled = false;
            this.ResolutionAtleastWidth.Location = new System.Drawing.Point(77, 41);
            this.ResolutionAtleastWidth.Name = "ResolutionAtleastWidth";
            this.ResolutionAtleastWidth.Size = new System.Drawing.Size(45, 20);
            this.ResolutionAtleastWidth.TabIndex = 1;
            // 
            // ResolutionAtleastRadioButton
            // 
            this.ResolutionAtleastRadioButton.AutoSize = true;
            this.ResolutionAtleastRadioButton.Enabled = false;
            this.ResolutionAtleastRadioButton.Location = new System.Drawing.Point(6, 42);
            this.ResolutionAtleastRadioButton.Name = "ResolutionAtleastRadioButton";
            this.ResolutionAtleastRadioButton.Size = new System.Drawing.Size(63, 17);
            this.ResolutionAtleastRadioButton.TabIndex = 0;
            this.ResolutionAtleastRadioButton.TabStop = true;
            this.ResolutionAtleastRadioButton.Text = "At least:";
            this.ResolutionAtleastRadioButton.UseVisualStyleBackColor = true;
            // 
            // PurityGroupBox
            // 
            this.PurityGroupBox.Controls.Add(this.PurityNSFWCheckbox);
            this.PurityGroupBox.Controls.Add(this.PuritySketchyCheckbox);
            this.PurityGroupBox.Controls.Add(this.PuritySFWCheckbox);
            this.PurityGroupBox.Location = new System.Drawing.Point(6, 67);
            this.PurityGroupBox.Name = "PurityGroupBox";
            this.PurityGroupBox.Size = new System.Drawing.Size(201, 42);
            this.PurityGroupBox.TabIndex = 1;
            this.PurityGroupBox.TabStop = false;
            this.PurityGroupBox.Text = "Purity";
            // 
            // PurityNSFWCheckbox
            // 
            this.PurityNSFWCheckbox.AutoSize = true;
            this.PurityNSFWCheckbox.Location = new System.Drawing.Point(136, 19);
            this.PurityNSFWCheckbox.Name = "PurityNSFWCheckbox";
            this.PurityNSFWCheckbox.Size = new System.Drawing.Size(58, 17);
            this.PurityNSFWCheckbox.TabIndex = 2;
            this.PurityNSFWCheckbox.Text = "NSFW";
            this.PurityNSFWCheckbox.UseVisualStyleBackColor = true;
            this.PurityNSFWCheckbox.CheckedChanged += new System.EventHandler(this.PurityNSFWCheckbox_CheckedChanged);
            // 
            // PuritySketchyCheckbox
            // 
            this.PuritySketchyCheckbox.AutoSize = true;
            this.PuritySketchyCheckbox.Location = new System.Drawing.Point(62, 19);
            this.PuritySketchyCheckbox.Name = "PuritySketchyCheckbox";
            this.PuritySketchyCheckbox.Size = new System.Drawing.Size(65, 17);
            this.PuritySketchyCheckbox.TabIndex = 1;
            this.PuritySketchyCheckbox.Text = "Sketchy";
            this.PuritySketchyCheckbox.UseVisualStyleBackColor = true;
            this.PuritySketchyCheckbox.CheckedChanged += new System.EventHandler(this.PuritySketchyCheckbox_CheckedChanged);
            // 
            // PuritySFWCheckbox
            // 
            this.PuritySFWCheckbox.AutoSize = true;
            this.PuritySFWCheckbox.Location = new System.Drawing.Point(6, 19);
            this.PuritySFWCheckbox.Name = "PuritySFWCheckbox";
            this.PuritySFWCheckbox.Size = new System.Drawing.Size(50, 17);
            this.PuritySFWCheckbox.TabIndex = 0;
            this.PuritySFWCheckbox.Text = "SFW";
            this.PuritySFWCheckbox.UseVisualStyleBackColor = true;
            this.PuritySFWCheckbox.CheckedChanged += new System.EventHandler(this.PuritySFWCheckbox_CheckedChanged);
            // 
            // CategoriesGroupBox
            // 
            this.CategoriesGroupBox.Controls.Add(this.CategoriesPeopleCheckBox);
            this.CategoriesGroupBox.Controls.Add(this.CategoriesAnimeCheckbox);
            this.CategoriesGroupBox.Controls.Add(this.CategoriesGeneralCheckbox);
            this.CategoriesGroupBox.Location = new System.Drawing.Point(6, 19);
            this.CategoriesGroupBox.Name = "CategoriesGroupBox";
            this.CategoriesGroupBox.Size = new System.Drawing.Size(201, 42);
            this.CategoriesGroupBox.TabIndex = 0;
            this.CategoriesGroupBox.TabStop = false;
            this.CategoriesGroupBox.Text = "Categories";
            // 
            // CategoriesPeopleCheckBox
            // 
            this.CategoriesPeopleCheckBox.AutoSize = true;
            this.CategoriesPeopleCheckBox.Location = new System.Drawing.Point(136, 19);
            this.CategoriesPeopleCheckBox.Name = "CategoriesPeopleCheckBox";
            this.CategoriesPeopleCheckBox.Size = new System.Drawing.Size(59, 17);
            this.CategoriesPeopleCheckBox.TabIndex = 2;
            this.CategoriesPeopleCheckBox.Text = "People";
            this.CategoriesPeopleCheckBox.UseVisualStyleBackColor = true;
            this.CategoriesPeopleCheckBox.CheckedChanged += new System.EventHandler(this.CategoriesPeopleCheckBox_CheckedChanged);
            // 
            // CategoriesAnimeCheckbox
            // 
            this.CategoriesAnimeCheckbox.AutoSize = true;
            this.CategoriesAnimeCheckbox.Location = new System.Drawing.Point(75, 19);
            this.CategoriesAnimeCheckbox.Name = "CategoriesAnimeCheckbox";
            this.CategoriesAnimeCheckbox.Size = new System.Drawing.Size(55, 17);
            this.CategoriesAnimeCheckbox.TabIndex = 1;
            this.CategoriesAnimeCheckbox.Text = "Anime";
            this.CategoriesAnimeCheckbox.UseVisualStyleBackColor = true;
            this.CategoriesAnimeCheckbox.CheckedChanged += new System.EventHandler(this.CategoriesAnimeCheckbox_CheckedChanged);
            // 
            // CategoriesGeneralCheckbox
            // 
            this.CategoriesGeneralCheckbox.AutoSize = true;
            this.CategoriesGeneralCheckbox.Location = new System.Drawing.Point(6, 19);
            this.CategoriesGeneralCheckbox.Name = "CategoriesGeneralCheckbox";
            this.CategoriesGeneralCheckbox.Size = new System.Drawing.Size(63, 17);
            this.CategoriesGeneralCheckbox.TabIndex = 0;
            this.CategoriesGeneralCheckbox.Text = "General";
            this.CategoriesGeneralCheckbox.UseVisualStyleBackColor = true;
            this.CategoriesGeneralCheckbox.CheckedChanged += new System.EventHandler(this.CategoriesGeneralCheckbox_CheckedChanged);
            // 
            // SortingComboBox
            // 
            this.SortingComboBox.FormattingEnabled = true;
            this.SortingComboBox.Items.AddRange(new object[] {
            "Date Added",
            "Relevance",
            "Random",
            "Views",
            "Favourites",
            "Toplist"});
            this.SortingComboBox.Location = new System.Drawing.Point(57, 42);
            this.SortingComboBox.Name = "SortingComboBox";
            this.SortingComboBox.Size = new System.Drawing.Size(114, 21);
            this.SortingComboBox.TabIndex = 2;
            this.SortingComboBox.SelectedIndexChanged += new System.EventHandler(this.SortingComboBox_IndexChanged);
            // 
            // SortingLabel
            // 
            this.SortingLabel.AutoSize = true;
            this.SortingLabel.Location = new System.Drawing.Point(6, 47);
            this.SortingLabel.Name = "SortingLabel";
            this.SortingLabel.Size = new System.Drawing.Size(43, 13);
            this.SortingLabel.TabIndex = 3;
            this.SortingLabel.Text = "Sorting:";
            // 
            // OrderSortingGroupBox
            // 
            this.OrderSortingGroupBox.Controls.Add(this.label1);
            this.OrderSortingGroupBox.Controls.Add(this.TopListComboBox);
            this.OrderSortingGroupBox.Controls.Add(this.OrderDescendingRadioButton);
            this.OrderSortingGroupBox.Controls.Add(this.OrderAscendingRadioButton);
            this.OrderSortingGroupBox.Controls.Add(this.SortingComboBox);
            this.OrderSortingGroupBox.Controls.Add(this.SortingLabel);
            this.OrderSortingGroupBox.Location = new System.Drawing.Point(6, 19);
            this.OrderSortingGroupBox.Name = "OrderSortingGroupBox";
            this.OrderSortingGroupBox.Size = new System.Drawing.Size(177, 97);
            this.OrderSortingGroupBox.TabIndex = 2;
            this.OrderSortingGroupBox.TabStop = false;
            this.OrderSortingGroupBox.Text = "Order and Sorting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toplist Range:";
            // 
            // TopListComboBox
            // 
            this.TopListComboBox.Enabled = false;
            this.TopListComboBox.FormattingEnabled = true;
            this.TopListComboBox.Items.AddRange(new object[] {
            "1 day",
            "3 days",
            "1 week",
            "1 month",
            "3 months",
            "6 months",
            "1 year"});
            this.TopListComboBox.Location = new System.Drawing.Point(92, 69);
            this.TopListComboBox.Name = "TopListComboBox";
            this.TopListComboBox.Size = new System.Drawing.Size(79, 21);
            this.TopListComboBox.TabIndex = 4;
            this.TopListComboBox.SelectedIndexChanged += new System.EventHandler(this.TopListComboBox_IndexChanged);
            // 
            // OrderDescendingRadioButton
            // 
            this.OrderDescendingRadioButton.AutoSize = true;
            this.OrderDescendingRadioButton.Checked = true;
            this.OrderDescendingRadioButton.Location = new System.Drawing.Point(89, 19);
            this.OrderDescendingRadioButton.Name = "OrderDescendingRadioButton";
            this.OrderDescendingRadioButton.Size = new System.Drawing.Size(82, 17);
            this.OrderDescendingRadioButton.TabIndex = 1;
            this.OrderDescendingRadioButton.TabStop = true;
            this.OrderDescendingRadioButton.Text = "Descending";
            this.OrderDescendingRadioButton.UseVisualStyleBackColor = true;
            this.OrderDescendingRadioButton.CheckedChanged += new System.EventHandler(this.OrderDescendingRadioButton_CheckedChanged);
            // 
            // OrderAscendingRadioButton
            // 
            this.OrderAscendingRadioButton.AutoSize = true;
            this.OrderAscendingRadioButton.Location = new System.Drawing.Point(6, 19);
            this.OrderAscendingRadioButton.Name = "OrderAscendingRadioButton";
            this.OrderAscendingRadioButton.Size = new System.Drawing.Size(75, 17);
            this.OrderAscendingRadioButton.TabIndex = 0;
            this.OrderAscendingRadioButton.Text = "Ascending";
            this.OrderAscendingRadioButton.UseVisualStyleBackColor = true;
            this.OrderAscendingRadioButton.CheckedChanged += new System.EventHandler(this.OrderAscendingRadioButton_CheckedChanged);
            // 
            // SearchSettingsGroupBox
            // 
            this.SearchSettingsGroupBox.Controls.Add(this.AdvancedSearchGroupBox);
            this.SearchSettingsGroupBox.Controls.Add(this.OrderSortingGroupBox);
            this.SearchSettingsGroupBox.Location = new System.Drawing.Point(12, 262);
            this.SearchSettingsGroupBox.Name = "SearchSettingsGroupBox";
            this.SearchSettingsGroupBox.Size = new System.Drawing.Size(375, 124);
            this.SearchSettingsGroupBox.TabIndex = 3;
            this.SearchSettingsGroupBox.TabStop = false;
            this.SearchSettingsGroupBox.Text = "Search settings";
            // 
            // AdvancedSearchGroupBox
            // 
            this.AdvancedSearchGroupBox.Controls.Add(this.PagesRangeEnd);
            this.AdvancedSearchGroupBox.Controls.Add(this.label3);
            this.AdvancedSearchGroupBox.Controls.Add(this.PagesRangeBegin);
            this.AdvancedSearchGroupBox.Controls.Add(this.PagesRangeSelectorRadioButton);
            this.AdvancedSearchGroupBox.Controls.Add(this.PageSelectorRadioButton);
            this.AdvancedSearchGroupBox.Controls.Add(this.AdvancedSearchSeed);
            this.AdvancedSearchGroupBox.Controls.Add(this.AdvancedSearchSeedLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.AdvancedSearchPage);
            this.AdvancedSearchGroupBox.Controls.Add(this.AdvancedSearchEnabled);
            this.AdvancedSearchGroupBox.Location = new System.Drawing.Point(189, 19);
            this.AdvancedSearchGroupBox.Name = "AdvancedSearchGroupBox";
            this.AdvancedSearchGroupBox.Size = new System.Drawing.Size(181, 97);
            this.AdvancedSearchGroupBox.TabIndex = 3;
            this.AdvancedSearchGroupBox.TabStop = false;
            this.AdvancedSearchGroupBox.Text = "Advanced";
            // 
            // PagesRangeEnd
            // 
            this.PagesRangeEnd.Enabled = false;
            this.PagesRangeEnd.Location = new System.Drawing.Point(149, 69);
            this.PagesRangeEnd.Name = "PagesRangeEnd";
            this.PagesRangeEnd.Size = new System.Drawing.Size(25, 20);
            this.PagesRangeEnd.TabIndex = 11;
            this.PagesRangeEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PagesRangeEnd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "–";
            // 
            // PagesRangeBegin
            // 
            this.PagesRangeBegin.Enabled = false;
            this.PagesRangeBegin.Location = new System.Drawing.Point(100, 69);
            this.PagesRangeBegin.Name = "PagesRangeBegin";
            this.PagesRangeBegin.Size = new System.Drawing.Size(25, 20);
            this.PagesRangeBegin.TabIndex = 9;
            this.PagesRangeBegin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PagesRangeBegin_KeyPress);
            // 
            // PagesRangeSelectorRadioButton
            // 
            this.PagesRangeSelectorRadioButton.AutoSize = true;
            this.PagesRangeSelectorRadioButton.Enabled = false;
            this.PagesRangeSelectorRadioButton.Location = new System.Drawing.Point(5, 70);
            this.PagesRangeSelectorRadioButton.Name = "PagesRangeSelectorRadioButton";
            this.PagesRangeSelectorRadioButton.Size = new System.Drawing.Size(88, 17);
            this.PagesRangeSelectorRadioButton.TabIndex = 8;
            this.PagesRangeSelectorRadioButton.Text = "Pages range:";
            this.PagesRangeSelectorRadioButton.UseVisualStyleBackColor = true;
            this.PagesRangeSelectorRadioButton.CheckedChanged += new System.EventHandler(this.PagesRangeSelectorRadioButton_CheckedChanged);
            // 
            // PageSelectorRadioButton
            // 
            this.PageSelectorRadioButton.AutoSize = true;
            this.PageSelectorRadioButton.Checked = true;
            this.PageSelectorRadioButton.Enabled = false;
            this.PageSelectorRadioButton.Location = new System.Drawing.Point(6, 44);
            this.PageSelectorRadioButton.Name = "PageSelectorRadioButton";
            this.PageSelectorRadioButton.Size = new System.Drawing.Size(82, 17);
            this.PageSelectorRadioButton.TabIndex = 7;
            this.PageSelectorRadioButton.TabStop = true;
            this.PageSelectorRadioButton.Text = "Begin page:";
            this.PageSelectorRadioButton.UseVisualStyleBackColor = true;
            this.PageSelectorRadioButton.CheckedChanged += new System.EventHandler(this.PageSelectorRadioButton_CheckedChanged);
            // 
            // AdvancedSearchSeed
            // 
            this.AdvancedSearchSeed.Enabled = false;
            this.AdvancedSearchSeed.Location = new System.Drawing.Point(136, 17);
            this.AdvancedSearchSeed.Name = "AdvancedSearchSeed";
            this.AdvancedSearchSeed.Size = new System.Drawing.Size(39, 20);
            this.AdvancedSearchSeed.TabIndex = 6;
            // 
            // AdvancedSearchSeedLabel
            // 
            this.AdvancedSearchSeedLabel.AutoSize = true;
            this.AdvancedSearchSeedLabel.Location = new System.Drawing.Point(95, 20);
            this.AdvancedSearchSeedLabel.Name = "AdvancedSearchSeedLabel";
            this.AdvancedSearchSeedLabel.Size = new System.Drawing.Size(35, 13);
            this.AdvancedSearchSeedLabel.TabIndex = 5;
            this.AdvancedSearchSeedLabel.Text = "Seed:";
            // 
            // AdvancedSearchPage
            // 
            this.AdvancedSearchPage.Enabled = false;
            this.AdvancedSearchPage.Location = new System.Drawing.Point(100, 43);
            this.AdvancedSearchPage.Name = "AdvancedSearchPage";
            this.AdvancedSearchPage.Size = new System.Drawing.Size(25, 20);
            this.AdvancedSearchPage.TabIndex = 4;
            this.AdvancedSearchPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdvancedSearchPage_KeyPressed);
            // 
            // AdvancedSearchEnabled
            // 
            this.AdvancedSearchEnabled.AutoSize = true;
            this.AdvancedSearchEnabled.Location = new System.Drawing.Point(6, 19);
            this.AdvancedSearchEnabled.Name = "AdvancedSearchEnabled";
            this.AdvancedSearchEnabled.Size = new System.Drawing.Size(65, 17);
            this.AdvancedSearchEnabled.TabIndex = 4;
            this.AdvancedSearchEnabled.Text = "Enabled";
            this.AdvancedSearchEnabled.UseVisualStyleBackColor = true;
            this.AdvancedSearchEnabled.CheckedChanged += new System.EventHandler(this.AdvancedSearchEnabled_CheckedChanged);
            // 
            // LogGroupBox
            // 
            this.LogGroupBox.Controls.Add(this.DownloadProgressBar);
            this.LogGroupBox.Controls.Add(this.LogTextBox);
            this.LogGroupBox.Location = new System.Drawing.Point(592, 196);
            this.LogGroupBox.Name = "LogGroupBox";
            this.LogGroupBox.Size = new System.Drawing.Size(311, 190);
            this.LogGroupBox.TabIndex = 4;
            this.LogGroupBox.TabStop = false;
            this.LogGroupBox.Text = "Log";
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.Location = new System.Drawing.Point(6, 163);
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(299, 21);
            this.DownloadProgressBar.TabIndex = 1;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadButton.Location = new System.Drawing.Point(6, 48);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(181, 37);
            this.DownloadButton.TabIndex = 5;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(6, 91);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(117, 27);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ImageSourceGroupBox
            // 
            this.ImageSourceGroupBox.Controls.Add(this.AmountToDownloadTextBox);
            this.ImageSourceGroupBox.Controls.Add(this.ImageSourceCollectionsListBox);
            this.ImageSourceGroupBox.Controls.Add(this.AmountToDownloadLabel);
            this.ImageSourceGroupBox.Controls.Add(this.ImageSourceFetchCollections);
            this.ImageSourceGroupBox.Controls.Add(this.ImageSourceUsername);
            this.ImageSourceGroupBox.Controls.Add(this.label2);
            this.ImageSourceGroupBox.Controls.Add(this.ImageSourceUserCollectionsRadioButton);
            this.ImageSourceGroupBox.Controls.Add(this.ImageSourceSearchQuery);
            this.ImageSourceGroupBox.Controls.Add(this.ImageSourceSearchRadioButton);
            this.ImageSourceGroupBox.Location = new System.Drawing.Point(592, 12);
            this.ImageSourceGroupBox.Name = "ImageSourceGroupBox";
            this.ImageSourceGroupBox.Size = new System.Drawing.Size(311, 178);
            this.ImageSourceGroupBox.TabIndex = 7;
            this.ImageSourceGroupBox.TabStop = false;
            this.ImageSourceGroupBox.Text = "Image Source";
            // 
            // AmountToDownloadTextBox
            // 
            this.AmountToDownloadTextBox.Location = new System.Drawing.Point(186, 22);
            this.AmountToDownloadTextBox.Name = "AmountToDownloadTextBox";
            this.AmountToDownloadTextBox.Size = new System.Drawing.Size(119, 20);
            this.AmountToDownloadTextBox.TabIndex = 13;
            this.AmountToDownloadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountToDownloadTextBox_KeyPressed);
            // 
            // ImageSourceCollectionsListBox
            // 
            this.ImageSourceCollectionsListBox.Enabled = false;
            this.ImageSourceCollectionsListBox.FormattingEnabled = true;
            this.ImageSourceCollectionsListBox.Location = new System.Drawing.Point(119, 103);
            this.ImageSourceCollectionsListBox.Name = "ImageSourceCollectionsListBox";
            this.ImageSourceCollectionsListBox.Size = new System.Drawing.Size(186, 69);
            this.ImageSourceCollectionsListBox.TabIndex = 11;
            this.ImageSourceCollectionsListBox.TabIndexChanged += new System.EventHandler(this.ImageSourceCollectionsListBox_IndexChanged);
            // 
            // AmountToDownloadLabel
            // 
            this.AmountToDownloadLabel.AutoSize = true;
            this.AmountToDownloadLabel.Location = new System.Drawing.Point(12, 25);
            this.AmountToDownloadLabel.Name = "AmountToDownloadLabel";
            this.AmountToDownloadLabel.Size = new System.Drawing.Size(168, 13);
            this.AmountToDownloadLabel.TabIndex = 12;
            this.AmountToDownloadLabel.Text = "Amount to Download (empty = all):";
            // 
            // ImageSourceFetchCollections
            // 
            this.ImageSourceFetchCollections.Enabled = false;
            this.ImageSourceFetchCollections.Location = new System.Drawing.Point(15, 149);
            this.ImageSourceFetchCollections.Name = "ImageSourceFetchCollections";
            this.ImageSourceFetchCollections.Size = new System.Drawing.Size(98, 23);
            this.ImageSourceFetchCollections.TabIndex = 10;
            this.ImageSourceFetchCollections.Text = "Get Collections";
            this.ImageSourceFetchCollections.UseVisualStyleBackColor = true;
            this.ImageSourceFetchCollections.Click += new System.EventHandler(this.ImageSourceFetchCollections_Click);
            // 
            // ImageSourceUsername
            // 
            this.ImageSourceUsername.Enabled = false;
            this.ImageSourceUsername.Location = new System.Drawing.Point(15, 120);
            this.ImageSourceUsername.Name = "ImageSourceUsername";
            this.ImageSourceUsername.Size = new System.Drawing.Size(98, 20);
            this.ImageSourceUsername.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username:";
            // 
            // ImageSourceUserCollectionsRadioButton
            // 
            this.ImageSourceUserCollectionsRadioButton.AutoSize = true;
            this.ImageSourceUserCollectionsRadioButton.Location = new System.Drawing.Point(12, 73);
            this.ImageSourceUserCollectionsRadioButton.Name = "ImageSourceUserCollectionsRadioButton";
            this.ImageSourceUserCollectionsRadioButton.Size = new System.Drawing.Size(101, 17);
            this.ImageSourceUserCollectionsRadioButton.TabIndex = 2;
            this.ImageSourceUserCollectionsRadioButton.Text = "User Collections";
            this.ImageSourceUserCollectionsRadioButton.UseVisualStyleBackColor = true;
            this.ImageSourceUserCollectionsRadioButton.CheckedChanged += new System.EventHandler(this.ImageSourceUserCollectionsRadioButton_CheckedChanged);
            // 
            // ImageSourceSearchQuery
            // 
            this.ImageSourceSearchQuery.Location = new System.Drawing.Point(153, 48);
            this.ImageSourceSearchQuery.Name = "ImageSourceSearchQuery";
            this.ImageSourceSearchQuery.Size = new System.Drawing.Size(152, 20);
            this.ImageSourceSearchQuery.TabIndex = 1;
            // 
            // ImageSourceSearchRadioButton
            // 
            this.ImageSourceSearchRadioButton.AutoSize = true;
            this.ImageSourceSearchRadioButton.Checked = true;
            this.ImageSourceSearchRadioButton.Location = new System.Drawing.Point(12, 49);
            this.ImageSourceSearchRadioButton.Name = "ImageSourceSearchRadioButton";
            this.ImageSourceSearchRadioButton.Size = new System.Drawing.Size(135, 17);
            this.ImageSourceSearchRadioButton.TabIndex = 0;
            this.ImageSourceSearchRadioButton.TabStop = true;
            this.ImageSourceSearchRadioButton.Text = "Search (can be empty):";
            this.ImageSourceSearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LogoutButton);
            this.groupBox2.Controls.Add(this.SavePathButton);
            this.groupBox2.Controls.Add(this.ThreadsTextBox);
            this.groupBox2.Controls.Add(this.ThreadsLabel);
            this.groupBox2.Controls.Add(this.DownloadButton);
            this.groupBox2.Controls.Add(this.CancelButton);
            this.groupBox2.Location = new System.Drawing.Point(393, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 124);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(129, 91);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(58, 27);
            this.LogoutButton.TabIndex = 10;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SavePathButton
            // 
            this.SavePathButton.Location = new System.Drawing.Point(112, 20);
            this.SavePathButton.Name = "SavePathButton";
            this.SavePathButton.Size = new System.Drawing.Size(75, 23);
            this.SavePathButton.TabIndex = 9;
            this.SavePathButton.Text = "Save to...";
            this.SavePathButton.UseVisualStyleBackColor = true;
            this.SavePathButton.Click += new System.EventHandler(this.SavePathButton_Click);
            // 
            // ThreadsTextBox
            // 
            this.ThreadsTextBox.Location = new System.Drawing.Point(70, 22);
            this.ThreadsTextBox.Name = "ThreadsTextBox";
            this.ThreadsTextBox.Size = new System.Drawing.Size(36, 20);
            this.ThreadsTextBox.TabIndex = 8;
            this.ThreadsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThreadsTextBox_KeyPressed);
            // 
            // ThreadsLabel
            // 
            this.ThreadsLabel.AutoSize = true;
            this.ThreadsLabel.Location = new System.Drawing.Point(6, 25);
            this.ThreadsLabel.Name = "ThreadsLabel";
            this.ThreadsLabel.Size = new System.Drawing.Size(52, 13);
            this.ThreadsLabel.TabIndex = 7;
            this.ThreadsLabel.Text = "Threads: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ImageSourceGroupBox);
            this.Controls.Add(this.LogGroupBox);
            this.Controls.Add(this.SearchSettingsGroupBox);
            this.Controls.Add(this.FiltersGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Wallhaven Downloader V2";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.FiltersGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RatioGroupBox.ResumeLayout(false);
            this.RatioGroupBox.PerformLayout();
            this.ResolutionsGroupBox.ResumeLayout(false);
            this.ResolutionsGroupBox.PerformLayout();
            this.PurityGroupBox.ResumeLayout(false);
            this.PurityGroupBox.PerformLayout();
            this.CategoriesGroupBox.ResumeLayout(false);
            this.CategoriesGroupBox.PerformLayout();
            this.OrderSortingGroupBox.ResumeLayout(false);
            this.OrderSortingGroupBox.PerformLayout();
            this.SearchSettingsGroupBox.ResumeLayout(false);
            this.AdvancedSearchGroupBox.ResumeLayout(false);
            this.AdvancedSearchGroupBox.PerformLayout();
            this.LogGroupBox.ResumeLayout(false);
            this.ImageSourceGroupBox.ResumeLayout(false);
            this.ImageSourceGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.GroupBox FiltersGroupBox;
        private System.Windows.Forms.GroupBox CategoriesGroupBox;
        private System.Windows.Forms.CheckBox CategoriesPeopleCheckBox;
        private System.Windows.Forms.CheckBox CategoriesAnimeCheckbox;
        private System.Windows.Forms.CheckBox CategoriesGeneralCheckbox;
        private System.Windows.Forms.GroupBox PurityGroupBox;
        private System.Windows.Forms.CheckBox PurityNSFWCheckbox;
        private System.Windows.Forms.CheckBox PuritySketchyCheckbox;
        private System.Windows.Forms.CheckBox PuritySFWCheckbox;
        private System.Windows.Forms.Label SortingLabel;
        private System.Windows.Forms.ComboBox SortingComboBox;
        private System.Windows.Forms.GroupBox OrderSortingGroupBox;
        private System.Windows.Forms.RadioButton OrderDescendingRadioButton;
        private System.Windows.Forms.RadioButton OrderAscendingRadioButton;
        private System.Windows.Forms.GroupBox ResolutionsGroupBox;
        private System.Windows.Forms.Label ColorsGroupBox;
        private System.Windows.Forms.TextBox ResolutionAtleastWidth;
        private System.Windows.Forms.RadioButton ResolutionAtleastRadioButton;
        private System.Windows.Forms.ListBox ResolutionListBox;
        private System.Windows.Forms.RadioButton ResolutionFromListRadioButton;
        private System.Windows.Forms.TextBox ResolutionAtleastHeight;
        private System.Windows.Forms.Button ResolutionButtonRemove;
        private System.Windows.Forms.Button ResolutionButtonAdd;
        private System.Windows.Forms.CheckBox ResolutionsEnabledCheckbox;
        private System.Windows.Forms.GroupBox RatioGroupBox;
        private System.Windows.Forms.Button RatioRemoveButton;
        private System.Windows.Forms.Button RatioAddButton;
        private System.Windows.Forms.CheckBox RatioEnabledCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ColorRemoveColorButton;
        private System.Windows.Forms.Button ColorAddColorButton;
        private System.Windows.Forms.ListBox ColorListBox;
        private System.Windows.Forms.CheckBox ColorEnableCheckbox;
        private System.Windows.Forms.GroupBox SearchSettingsGroupBox;
        private System.Windows.Forms.GroupBox AdvancedSearchGroupBox;
        private System.Windows.Forms.CheckBox AdvancedSearchEnabled;
        private System.Windows.Forms.TextBox AdvancedSearchSeed;
        private System.Windows.Forms.Label AdvancedSearchSeedLabel;
        private System.Windows.Forms.TextBox AdvancedSearchPage;
        private System.Windows.Forms.GroupBox LogGroupBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TopListComboBox;
        private System.Windows.Forms.GroupBox ImageSourceGroupBox;
        private System.Windows.Forms.TextBox ImageSourceUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ImageSourceUserCollectionsRadioButton;
        private System.Windows.Forms.TextBox ImageSourceSearchQuery;
        private System.Windows.Forms.RadioButton ImageSourceSearchRadioButton;
        private System.Windows.Forms.ListBox ImageSourceCollectionsListBox;
        private System.Windows.Forms.Button ImageSourceFetchCollections;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SavePathButton;
        private System.Windows.Forms.TextBox ThreadsTextBox;
        private System.Windows.Forms.Label ThreadsLabel;
        private System.Windows.Forms.ListBox RatioListBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox AmountToDownloadTextBox;
        private System.Windows.Forms.Label AmountToDownloadLabel;
        private System.Windows.Forms.ProgressBar DownloadProgressBar;
        private System.Windows.Forms.RadioButton PageSelectorRadioButton;
        private System.Windows.Forms.TextBox PagesRangeEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PagesRangeBegin;
        private System.Windows.Forms.RadioButton PagesRangeSelectorRadioButton;
    }
}