using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombassSoundboard {
    public partial class EditWindow : Form {

        private Sound sound;

        public EditWindow(Sound sound) {
            InitializeComponent();
            this.sound = sound;
            NameBox.Text = sound.Name;
            if (sound.Keybind != 0) KeyBox.Text = sound.Keybind.ToString();
        }

        private void PlaysResetButton_Click(object sender, EventArgs e) {
            sound.Plays = 0;
            MessageBox.Show("Play count for \"" + sound.Name + "\" has been reset to zero.");
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void OkayButton_Click(object sender, EventArgs e) {
            if (NameBox.Text.Length > 0 && !NameBox.Text.Equals(sound.Name)) {
                sound.Name = NameBox.Text;
            }
            if (KeyBox.Text.Length > 0) {
                if (KeyBox.Text[0] != sound.Keybind) {
                    sound.Keybind = KeyBox.Text[0];
                }
            } else {
                sound.Keybind = '\0';
            }
            Close();
        }

        private void EditWindow_FormClosing(object sender, FormClosingEventArgs e) {
            Program.window.populateSounds();
        }

        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }
    }
}
