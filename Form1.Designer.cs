namespace YoutubeDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.videoLinkTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.videoTitleLabel = new System.Windows.Forms.Label();
            this.videoThumbnailPictureBox = new System.Windows.Forms.PictureBox();
            this.downloadFormatBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.downloadPathTextBox = new System.Windows.Forms.TextBox();
            this.folderDialogButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.formatLabel = new System.Windows.Forms.Label();
            this.downloadCompleteLabel = new System.Windows.Forms.Label();
            this.downloadQualityBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbnailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Manrope Medium", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "YoutubeGrabber";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // videoLinkTextBox
            // 
            this.videoLinkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.videoLinkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.videoLinkTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videoLinkTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.videoLinkTextBox.Location = new System.Drawing.Point(12, 99);
            this.videoLinkTextBox.Name = "videoLinkTextBox";
            this.videoLinkTextBox.Size = new System.Drawing.Size(634, 25);
            this.videoLinkTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Manrope Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Video Link:";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Manrope Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.submitButton.Location = new System.Drawing.Point(652, 95);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(136, 29);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // videoTitleLabel
            // 
            this.videoTitleLabel.AutoSize = true;
            this.videoTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.videoTitleLabel.Font = new System.Drawing.Font("Manrope Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videoTitleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.videoTitleLabel.Location = new System.Drawing.Point(12, 143);
            this.videoTitleLabel.Name = "videoTitleLabel";
            this.videoTitleLabel.Size = new System.Drawing.Size(44, 22);
            this.videoTitleLabel.TabIndex = 6;
            this.videoTitleLabel.Text = "Title";
            // 
            // videoThumbnailPictureBox
            // 
            this.videoThumbnailPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.videoThumbnailPictureBox.Location = new System.Drawing.Point(12, 168);
            this.videoThumbnailPictureBox.Name = "videoThumbnailPictureBox";
            this.videoThumbnailPictureBox.Size = new System.Drawing.Size(480, 270);
            this.videoThumbnailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.videoThumbnailPictureBox.TabIndex = 7;
            this.videoThumbnailPictureBox.TabStop = false;
            // 
            // downloadFormatBox
            // 
            this.downloadFormatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.downloadFormatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.downloadFormatBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadFormatBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.downloadFormatBox.FormattingEnabled = true;
            this.downloadFormatBox.Items.AddRange(new object[] {
            "Audio",
            "Video"});
            this.downloadFormatBox.Location = new System.Drawing.Point(498, 186);
            this.downloadFormatBox.Name = "downloadFormatBox";
            this.downloadFormatBox.Size = new System.Drawing.Size(121, 23);
            this.downloadFormatBox.TabIndex = 8;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Red;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Manrope", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.startButton.Location = new System.Drawing.Point(498, 377);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(290, 61);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // downloadPathTextBox
            // 
            this.downloadPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.downloadPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.downloadPathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downloadPathTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.downloadPathTextBox.Location = new System.Drawing.Point(498, 348);
            this.downloadPathTextBox.Name = "downloadPathTextBox";
            this.downloadPathTextBox.Size = new System.Drawing.Size(253, 22);
            this.downloadPathTextBox.TabIndex = 9;
            // 
            // folderDialogButton
            // 
            this.folderDialogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.folderDialogButton.FlatAppearance.BorderSize = 0;
            this.folderDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderDialogButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.folderDialogButton.Location = new System.Drawing.Point(757, 348);
            this.folderDialogButton.Name = "folderDialogButton";
            this.folderDialogButton.Size = new System.Drawing.Size(31, 23);
            this.folderDialogButton.TabIndex = 10;
            this.folderDialogButton.Text = "...";
            this.folderDialogButton.UseVisualStyleBackColor = false;
            this.folderDialogButton.Click += new System.EventHandler(this.folderDialogButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Manrope Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(498, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "File Path:";
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Font = new System.Drawing.Font("Manrope Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formatLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.formatLabel.Location = new System.Drawing.Point(498, 161);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(71, 22);
            this.formatLabel.TabIndex = 12;
            this.formatLabel.Text = "Format:";
            // 
            // downloadCompleteLabel
            // 
            this.downloadCompleteLabel.AutoSize = true;
            this.downloadCompleteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadCompleteLabel.Font = new System.Drawing.Font("Manrope", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.downloadCompleteLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.downloadCompleteLabel.Location = new System.Drawing.Point(669, 301);
            this.downloadCompleteLabel.Name = "downloadCompleteLabel";
            this.downloadCompleteLabel.Size = new System.Drawing.Size(119, 44);
            this.downloadCompleteLabel.TabIndex = 13;
            this.downloadCompleteLabel.Text = "Done!";
            this.downloadCompleteLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.downloadCompleteLabel.Visible = false;
            // 
            // downloadQualityBox
            // 
            this.downloadQualityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.downloadQualityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.downloadQualityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadQualityBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.downloadQualityBox.FormattingEnabled = true;
            this.downloadQualityBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.downloadQualityBox.Location = new System.Drawing.Point(498, 246);
            this.downloadQualityBox.Name = "downloadQualityBox";
            this.downloadQualityBox.Size = new System.Drawing.Size(121, 23);
            this.downloadQualityBox.TabIndex = 14;
            this.downloadQualityBox.SelectedIndexChanged += new System.EventHandler(this.downloadQualityBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Manrope Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(498, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quality:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.downloadQualityBox);
            this.Controls.Add(this.downloadCompleteLabel);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.folderDialogButton);
            this.Controls.Add(this.downloadPathTextBox);
            this.Controls.Add(this.downloadFormatBox);
            this.Controls.Add(this.videoThumbnailPictureBox);
            this.Controls.Add(this.videoTitleLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.videoLinkTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoutubeGrabber";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbnailPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox videoLinkTextBox;
        private Label label2;
        private Button submitButton;
        private Label videoTitleLabel;
        private PictureBox videoThumbnailPictureBox;
        private ComboBox downloadFormatBox;
        private Button startButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox downloadPathTextBox;
        private Button folderDialogButton;
        private Label label3;
        private Label formatLabel;
        private Label downloadCompleteLabel;
        private ComboBox downloadQualityBox;
        private Label label4;
    }
}