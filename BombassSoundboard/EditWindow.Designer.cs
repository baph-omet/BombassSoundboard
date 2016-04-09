namespace BombassSoundboard {
    partial class EditWindow {
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OkayButton = new System.Windows.Forms.Button();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.PlaysResetButton = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(9, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(59, 13);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "Edit Sound";
            // 
            // OkayButton
            // 
            this.OkayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkayButton.Location = new System.Drawing.Point(242, 69);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(130, 35);
            this.OkayButton.TabIndex = 14;
            this.OkayButton.Text = "Ok";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // CancelButton1
            // 
            this.CancelButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton1.Location = new System.Drawing.Point(378, 69);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(130, 35);
            this.CancelButton1.TabIndex = 13;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PlaysResetButton
            // 
            this.PlaysResetButton.Location = new System.Drawing.Point(26, 69);
            this.PlaysResetButton.Name = "PlaysResetButton";
            this.PlaysResetButton.Size = new System.Drawing.Size(130, 35);
            this.PlaysResetButton.TabIndex = 12;
            this.PlaysResetButton.Text = "Reset Plays";
            this.PlaysResetButton.UseVisualStyleBackColor = true;
            this.PlaysResetButton.Click += new System.EventHandler(this.PlaysResetButton_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(472, 34);
            this.KeyBox.MaxLength = 1;
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(36, 20);
            this.KeyBox.TabIndex = 11;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(72, 34);
            this.NameBox.MaxLength = 100;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(343, 20);
            this.NameBox.TabIndex = 10;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.ForeColor = System.Drawing.Color.White;
            this.KeyLabel.Location = new System.Drawing.Point(421, 37);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(45, 13);
            this.KeyLabel.TabIndex = 9;
            this.KeyLabel.Text = "Keybind";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(31, 37);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name";
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CancelButton = this.CancelButton1;
            this.ClientSize = new System.Drawing.Size(535, 118);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.PlaysResetButton);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "EditWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditWindow";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.Button PlaysResetButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox KeyBox;
    }
}