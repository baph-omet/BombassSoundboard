using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BombassSoundboard {
    public partial class MainWindow : Form {

        public MainWindow() {
            InitializeComponent();
            populateSounds();
        }

        private void MainWindow_Load(object sender, EventArgs e) {

        }

        public void populateSounds() {
            
        }

        private void QuitButton_Click(object sender, EventArgs e) {
            Quit();
        }

        private void QuitButton_MouseEnter(object sender, EventArgs e) {
            QuitButton.BorderStyle = BorderStyle.FixedSingle;
            StatusLabel.Text = "Quit";
        }

        private void QuitButton_MouseLeave(object sender, EventArgs e) {
            QuitButton.BorderStyle = BorderStyle.None;
            StatusLabel.Text = "";
        }

        private void Quit() {
            Program.player.Dispose();
            Close();
        }
    }
}
