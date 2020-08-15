namespace BarcodeReaderSample.Forms
{
    partial class SettingsForm
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
            //this.components = new System.ComponentModel.Container();
            this.CameraPreviewLabel = new System.Windows.Forms.Label();
            this.CameraComboBox = new System.Windows.Forms.ComboBox();
            this.AppLogoTitle = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.CameraComboBoxLabel = new System.Windows.Forms.Label();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.HotkeyTitleLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.CSVDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CameraPreviewLabel
            // 
            this.CameraPreviewLabel.AutoSize = true;
            this.CameraPreviewLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CameraPreviewLabel.Location = new System.Drawing.Point(27, 19);
            this.CameraPreviewLabel.Name = "CameraPreviewLabel";
            this.CameraPreviewLabel.Size = new System.Drawing.Size(91, 15);
            this.CameraPreviewLabel.TabIndex = 1;
            this.CameraPreviewLabel.Text = "Camera preview";
            // 
            // CameraComboBox
            // 
            this.CameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CameraComboBox.FormattingEnabled = true;
            this.CameraComboBox.Location = new System.Drawing.Point(27, 228);
            this.CameraComboBox.Name = "CameraComboBox";
            this.CameraComboBox.Size = new System.Drawing.Size(150, 23);
            this.CameraComboBox.TabIndex = 4;
            this.CameraComboBox.SelectionChangeCommitted += new System.EventHandler(this.CameraComboBox_SelectionChangeCommitted);
            // 
            // AppLogoTitle
            // 
            this.AppLogoTitle.AutoSize = true;
            this.AppLogoTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.AppLogoTitle.Location = new System.Drawing.Point(270, 226);
            this.AppLogoTitle.Name = "AppLogoTitle";
            this.AppLogoTitle.Size = new System.Drawing.Size(151, 21);
            this.AppLogoTitle.TabIndex = 10;
            this.AppLogoTitle.Text = "Barcode Reader Tool";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.VersionLabel.Location = new System.Drawing.Point(347, 247);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VersionLabel.Size = new System.Drawing.Size(72, 15);
            this.VersionLabel.TabIndex = 11;
            this.VersionLabel.Text = "Version 1.0.0";
            // 
            // CameraComboBoxLabel
            // 
            this.CameraComboBoxLabel.AutoSize = true;
            this.CameraComboBoxLabel.Location = new System.Drawing.Point(27, 210);
            this.CameraComboBoxLabel.Name = "CameraComboBoxLabel";
            this.CameraComboBoxLabel.Size = new System.Drawing.Size(123, 15);
            this.CameraComboBoxLabel.TabIndex = 12;
            this.CameraComboBoxLabel.Text = "Default camera device";
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(27, 46);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(150, 152);
            this.videoSourcePlayer1.TabIndex = 15;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // HotkeyTitleLabel
            // 
            this.HotkeyTitleLabel.AutoSize = true;
            this.HotkeyTitleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HotkeyTitleLabel.Location = new System.Drawing.Point(241, 19);
            this.HotkeyTitleLabel.Name = "HotkeyTitleLabel";
            this.HotkeyTitleLabel.Size = new System.Drawing.Size(118, 15);
            this.HotkeyTitleLabel.TabIndex = 3;
            this.HotkeyTitleLabel.Text = "CSV output directory";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // CSVDirectoryTextBox
            // 
            this.CSVDirectoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CSVDirectoryTextBox.Location = new System.Drawing.Point(241, 75);
            this.CSVDirectoryTextBox.Name = "CSVDirectoryTextBox";
            this.CSVDirectoryTextBox.ReadOnly = true;
            this.CSVDirectoryTextBox.Size = new System.Drawing.Size(211, 23);
            this.CSVDirectoryTextBox.TabIndex = 18;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.CSVDirectoryTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.CameraComboBoxLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.AppLogoTitle);
            this.Controls.Add(this.CameraComboBox);
            this.Controls.Add(this.HotkeyTitleLabel);
            this.Controls.Add(this.CameraPreviewLabel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CameraPreviewLabel;
        private System.Windows.Forms.ComboBox CameraComboBox;
        private System.Windows.Forms.Label AppLogoTitle;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label CameraComboBoxLabel;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Label HotkeyTitleLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CSVDirectoryTextBox;
    }
}