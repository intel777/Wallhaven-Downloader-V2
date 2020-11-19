
namespace Wallhaven_Downloader_V2 {
    partial class UserInput {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInput));
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputButtonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 15);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(37, 13);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input: ";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(55, 12);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.InputTextBox.TabIndex = 1;
            // 
            // InputButtonOK
            // 
            this.InputButtonOK.Location = new System.Drawing.Point(46, 38);
            this.InputButtonOK.Name = "InputButtonOK";
            this.InputButtonOK.Size = new System.Drawing.Size(75, 23);
            this.InputButtonOK.TabIndex = 2;
            this.InputButtonOK.Text = "OK";
            this.InputButtonOK.UseVisualStyleBackColor = true;
            this.InputButtonOK.Click += new System.EventHandler(this.InputButtonOK_Click);
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 71);
            this.Controls.Add(this.InputButtonOK);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInput";
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button InputButtonOK;
    }
}