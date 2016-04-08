namespace BombassSoundboard {
    partial class MainWindow {
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
            this.QuitButton = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.LoopButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SoundBox = new System.Windows.Forms.ListView();
            this.SoundColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShortcutColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.AutoSize = true;
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.ForeColor = System.Drawing.Color.White;
            this.QuitButton.Location = new System.Drawing.Point(1078, 9);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(12, 13);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "x";
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            this.QuitButton.MouseEnter += new System.EventHandler(this.QuitButton_MouseEnter);
            this.QuitButton.MouseLeave += new System.EventHandler(this.QuitButton_MouseLeave);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(13, 615);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(38, 13);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Ready";
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(12, 560);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(198, 46);
            this.PlayButton.TabIndex = 4;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            // 
            // LoopButton
            // 
            this.LoopButton.Location = new System.Drawing.Point(216, 560);
            this.LoopButton.Name = "LoopButton";
            this.LoopButton.Size = new System.Drawing.Size(170, 46);
            this.LoopButton.TabIndex = 5;
            this.LoopButton.Text = "Loop";
            this.LoopButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StopButton.Location = new System.Drawing.Point(392, 560);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(170, 46);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            this.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadButton.Location = new System.Drawing.Point(744, 560);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(170, 46);
            this.LoadButton.TabIndex = 7;
            this.LoadButton.Text = "Load new sound...";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshButton.Location = new System.Drawing.Point(920, 560);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(170, 46);
            this.RefreshButton.TabIndex = 8;
            this.RefreshButton.Text = "Refresh sounds";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(12, 8);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(219, 28);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Bombass Soundboard";
            // 
            // SoundBox
            // 
            this.SoundBox.AllowColumnReorder = true;
            this.SoundBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SoundColumn,
            this.LocationColumn,
            this.FileTypeColumn,
            this.ShortcutColumn});
            this.SoundBox.FullRowSelect = true;
            this.SoundBox.Location = new System.Drawing.Point(12, 40);
            this.SoundBox.Name = "SoundBox";
            this.SoundBox.Size = new System.Drawing.Size(1077, 514);
            this.SoundBox.TabIndex = 10;
            this.SoundBox.UseCompatibleStateImageBehavior = false;
            this.SoundBox.View = System.Windows.Forms.View.Details;
            // 
            // SoundColumn
            // 
            this.SoundColumn.Text = "Sound";
            this.SoundColumn.Width = 261;
            // 
            // LocationColumn
            // 
            this.LocationColumn.Text = "Location";
            this.LocationColumn.Width = 326;
            // 
            // FileTypeColumn
            // 
            this.FileTypeColumn.Text = "File Type";
            this.FileTypeColumn.Width = 224;
            // 
            // ShortcutColumn
            // 
            this.ShortcutColumn.Text = "Shortcut Key";
            this.ShortcutColumn.Width = 275;
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemoveButton.Location = new System.Drawing.Point(568, 560);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(170, 46);
            this.RemoveButton.TabIndex = 11;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1104, 640);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.SoundBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.LoopButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.QuitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "Bombass Soundboard";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label QuitButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button LoopButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListView SoundBox;
        private System.Windows.Forms.ColumnHeader SoundColumn;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.ColumnHeader LocationColumn;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.ColumnHeader FileTypeColumn;
        private System.Windows.Forms.ColumnHeader ShortcutColumn;
        private System.Windows.Forms.Button RemoveButton;
    }
}

