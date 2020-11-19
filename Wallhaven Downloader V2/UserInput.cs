using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wallhaven_Downloader_V2 {
    public partial class UserInput : Form {

        public string input_result;
        public UserInput() {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void InputButtonOK_Click(object sender, EventArgs e) {
            input_result = InputTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
