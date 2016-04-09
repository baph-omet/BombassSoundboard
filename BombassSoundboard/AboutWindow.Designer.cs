namespace BombassSoundboard {
    partial class AboutWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLablel = new System.Windows.Forms.Label();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CloseButton1 = new System.Windows.Forms.Button();
            this.Infobox = new System.Windows.Forms.RichTextBox();
            this.BlogLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TitleLablel
            // 
            this.TitleLablel.AutoSize = true;
            this.TitleLablel.Font = new System.Drawing.Font("Microsoft NeoGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLablel.ForeColor = System.Drawing.Color.White;
            this.TitleLablel.Location = new System.Drawing.Point(83, 28);
            this.TitleLablel.Name = "TitleLablel";
            this.TitleLablel.Size = new System.Drawing.Size(385, 49);
            this.TitleLablel.TabIndex = 1;
            this.TitleLablel.Text = "Bombass Soundboard";
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GitHubLinkLabel.Location = new System.Drawing.Point(511, 253);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(117, 13);
            this.GitHubLinkLabel.TabIndex = 2;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "View Project on GitHub";
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // CloseButton1
            // 
            this.CloseButton1.Location = new System.Drawing.Point(634, 248);
            this.CloseButton1.Name = "CloseButton1";
            this.CloseButton1.Size = new System.Drawing.Size(75, 23);
            this.CloseButton1.TabIndex = 3;
            this.CloseButton1.Text = "Close";
            this.CloseButton1.UseVisualStyleBackColor = true;
            this.CloseButton1.Click += new System.EventHandler(this.CloseButton1_Click);
            // 
            // Infobox
            // 
            this.Infobox.BackColor = System.Drawing.Color.Gray;
            this.Infobox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Infobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infobox.Location = new System.Drawing.Point(13, 83);
            this.Infobox.Name = "Infobox";
            this.Infobox.ReadOnly = true;
            this.Infobox.Size = new System.Drawing.Size(696, 159);
            this.Infobox.TabIndex = 4;
            this.Infobox.Text = resources.GetString("Infobox.Text");
            // 
            // BlogLinkLabel
            // 
            this.BlogLinkLabel.AutoSize = true;
            this.BlogLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BlogLinkLabel.Location = new System.Drawing.Point(399, 253);
            this.BlogLinkLabel.Name = "BlogLinkLabel";
            this.BlogLinkLabel.Size = new System.Drawing.Size(95, 13);
            this.BlogLinkLabel.TabIndex = 5;
            this.BlogLinkLabel.TabStop = true;
            this.BlogLinkLabel.Text = "Check out my blog";
            this.BlogLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BlogLinkLabel_LinkClicked);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(721, 283);
            this.Controls.Add(this.BlogLinkLabel);
            this.Controls.Add(this.Infobox);
            this.Controls.Add(this.CloseButton1);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.TitleLablel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutWindow";
            this.Text = "AboutWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLablel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.Button CloseButton1;
        private System.Windows.Forms.RichTextBox Infobox;
        private System.Windows.Forms.LinkLabel BlogLinkLabel;
    }
}