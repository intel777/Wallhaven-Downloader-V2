
namespace Wallhaven_Downloader_V2
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.APIKeyInput = new System.Windows.Forms.TextBox();
            this.APIKeySaveCheckbox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.APIKeyLabel = new System.Windows.Forms.Label();
            this.AuthInfoRichTextbox = new System.Windows.Forms.RichTextBox();
            this.OpenProfileSettingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // APIKeyInput
            // 
            this.APIKeyInput.Location = new System.Drawing.Point(68, 106);
            this.APIKeyInput.Name = "APIKeyInput";
            this.APIKeyInput.Size = new System.Drawing.Size(278, 20);
            this.APIKeyInput.TabIndex = 0;
            // 
            // APIKeySaveCheckbox
            // 
            this.APIKeySaveCheckbox.AutoSize = true;
            this.APIKeySaveCheckbox.Location = new System.Drawing.Point(15, 132);
            this.APIKeySaveCheckbox.Name = "APIKeySaveCheckbox";
            this.APIKeySaveCheckbox.Size = new System.Drawing.Size(71, 17);
            this.APIKeySaveCheckbox.TabIndex = 1;
            this.APIKeySaveCheckbox.Text = "Save key";
            this.APIKeySaveCheckbox.UseVisualStyleBackColor = true;
            this.APIKeySaveCheckbox.CheckedChanged += new System.EventHandler(this.APIKeySaveCheckbox_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(142, 151);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // APIKeyLabel
            // 
            this.APIKeyLabel.AutoSize = true;
            this.APIKeyLabel.Location = new System.Drawing.Point(12, 109);
            this.APIKeyLabel.Name = "APIKeyLabel";
            this.APIKeyLabel.Size = new System.Drawing.Size(50, 13);
            this.APIKeyLabel.TabIndex = 3;
            this.APIKeyLabel.Text = "API key: ";
            // 
            // AuthInfoRichTextbox
            // 
            this.AuthInfoRichTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthInfoRichTextbox.Enabled = false;
            this.AuthInfoRichTextbox.Location = new System.Drawing.Point(12, 12);
            this.AuthInfoRichTextbox.Name = "AuthInfoRichTextbox";
            this.AuthInfoRichTextbox.ReadOnly = true;
            this.AuthInfoRichTextbox.Size = new System.Drawing.Size(334, 59);
            this.AuthInfoRichTextbox.TabIndex = 4;
            this.AuthInfoRichTextbox.Text = "In order to access NSFW images and save search settings, user must be registered " +
    "at Wallhaven.\nOpen profile settings and copy API key in the field below.\nFor ano" +
    "nymous login leave API Key field empty.";
            // 
            // OpenProfileSettingButton
            // 
            this.OpenProfileSettingButton.Location = new System.Drawing.Point(12, 77);
            this.OpenProfileSettingButton.Name = "OpenProfileSettingButton";
            this.OpenProfileSettingButton.Size = new System.Drawing.Size(127, 23);
            this.OpenProfileSettingButton.TabIndex = 5;
            this.OpenProfileSettingButton.Text = "Open profile settings";
            this.OpenProfileSettingButton.UseVisualStyleBackColor = true;
            this.OpenProfileSettingButton.Click += new System.EventHandler(this.OpenProfileSettingButton_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 186);
            this.Controls.Add(this.OpenProfileSettingButton);
            this.Controls.Add(this.AuthInfoRichTextbox);
            this.Controls.Add(this.APIKeyLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.APIKeySaveCheckbox);
            this.Controls.Add(this.APIKeyInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthForm";
            this.Text = "Authorization";
            this.Shown += new System.EventHandler(this.AuthForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox APIKeyInput;
        private System.Windows.Forms.CheckBox APIKeySaveCheckbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label APIKeyLabel;
        private System.Windows.Forms.RichTextBox AuthInfoRichTextbox;
        private System.Windows.Forms.Button OpenProfileSettingButton;
    }
}

