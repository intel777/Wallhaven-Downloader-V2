using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Wallhaven_Downloader_V2 {
    public partial class AuthForm : Form {
        public AuthForm() {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void OpenMainForm(string APIKey) {
            Main MainForm = new Main {
                APIKey = APIKey
            };
            this.Hide();
            MainForm.Closed += (s, args) => this.Close();
            MainForm.Show();
        }

        private void AuthForm_Shown(object sender, EventArgs e) {
            if (Properties.Settings.Default.APIKey != "") {
                OpenMainForm(Properties.Settings.Default.APIKey);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            OpenMainForm(APIKeyInput.Text);
        }

        private void OpenProfileSettingButton_Click(object sender, EventArgs e) {
            Process.Start("https://wallhaven.cc/settings/account");
        }

        private void APIKeySaveCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (APIKeySaveCheckbox.Checked) {
                var result = MessageBox.Show(
                    "Saving your API key might be unsave as it saved in plaintext inside \"AppData/Local\" folder.",
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                    );
                if (result == DialogResult.OK) {
                    Properties.Settings.Default.APIKey = APIKeyInput.Text;
                    Properties.Settings.Default.Save();
                }
                else {
                    APIKeySaveCheckbox.Checked = false;
                }
            }
            else {
                Properties.Settings.Default.APIKey = "";
                Properties.Settings.Default.Save();
            }
        }
    }
}
