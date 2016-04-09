using BombassSoundboard.Exceptions;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BombassSoundboard {
    public partial class MainWindow : Form {

        private bool allowkeys = true;

        public MainWindow() {
            InitializeComponent();
            populateSounds();
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            populateSounds();
        }

        public void populateSounds() {
            SoundBox.Items.Clear();
            foreach (Sound sound in Program.player.getSounds()) {
                String filetype = "WAV audio file";
                if (sound.isMP3()) filetype = "MP3 audio file";
                SoundBox.Items.Add(new ListViewItem(new[] { sound.Name, sound.location, filetype, sound.Keybind.ToString(),sound.Plays.ToString()}));
            }
        }

        private void QuitButton_Click(object sender, EventArgs e) {
            Quit();
        }

        private void QuitButton_MouseEnter(object sender, EventArgs e) {
            QuitButton.BorderStyle = BorderStyle.FixedSingle;
        }

        private void QuitButton_MouseLeave(object sender, EventArgs e) {
            QuitButton.BorderStyle = BorderStyle.None;
        }

        private void Quit() {
            Program.player.Dispose();
            Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            populateSounds();
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

        private void PlayButton_Click(object sender, EventArgs e) {
            foreach (ListViewItem sound in SoundBox.SelectedItems) {
                Sound s = Program.player.getSound(sound.SubItems[1].Text);
                Program.player.playSound(s);
                sound.SubItems[4].Text = s.Plays.ToString();
            }
        }

        private void StopButton_Click(object sender, EventArgs e) {
            Program.player.stopSound();
        }

        private void LoadButton_Click(object sender, EventArgs e) {
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK) {
                    foreach (String filename in dialog.FileNames) {
                        try {
                            Program.player.loadNewSound(filename);
                        } catch (InvalidSoundFileException ex) {
                            MessageBox.Show(ex.Message, "Ya dun goof'd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    populateSounds();
                }
            }
        }

        private void LoopButton_Click(object sender, EventArgs e) {
            foreach (ListViewItem sound in SoundBox.SelectedItems) {
                Sound s = Program.player.getSound(sound.SubItems[1].Text);
                Program.player.loopSound(s);
                sound.SubItems[4].Text = s.Plays.ToString();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e) {
            foreach (ListViewItem sound in SoundBox.SelectedItems) {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the sound \"" + sound.SubItems[0].Text + "\"? This will permanently remove it from the program.","Yo, Hold Up",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) {
                    Program.player.deleteSound(sound.SubItems[1].Text);
                }
                populateSounds();
            }
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e) {
            allowkeys = true;
        }

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e) {
            if (allowkeys) {
                //MessageBox.Show("You pressed: \"" + e.KeyChar + "\"");
                foreach (Sound sound in Program.player.getSounds()) {
                    if (sound.Keybind == e.KeyChar) {
                        Program.player.playSound(sound);
                        populateSounds();
                        allowkeys = false;
                        break;
                    }
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e) {
            if (SoundBox.SelectedItems.Count == 1) {
                Sound sound = Program.player.getSound(SoundBox.SelectedItems[0].SubItems[1].Text);
                EditWindow editor = new EditWindow(sound);
                editor.ShowDialog();
            }
        }

        private void MainWindow_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (String path in files) {
                    try {
                        Program.player.loadNewSound(path);
                    } catch (InvalidSoundFileException ex) {
                        MessageBox.Show(ex.Message, "Ya dun goof'd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                populateSounds();
            }
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e) {
            if (allowkeys) {
                switch (e.KeyCode) {
                    case Keys.Delete:
                        if (SoundBox.SelectedItems.Count > 0) {
                            foreach (ListViewItem sound in SoundBox.SelectedItems) {
                                DialogResult result = MessageBox.Show("Are you sure you want to delete the sound \"" + sound.SubItems[0].Text + "\"? This will permanently remove it from the program.", "Yo, Hold Up", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (result == DialogResult.Yes) {
                                    Program.player.deleteSound(sound.SubItems[1].Text);
                                }
                                populateSounds();
                            }
                        }
                        break;
                    case Keys.Enter:
                    case Keys.Space:
                        if (SoundBox.SelectedItems.Count > 0) {
                            foreach (ListViewItem sound in SoundBox.SelectedItems) {
                                Sound s = Program.player.getSound(sound.SubItems[1].Text);
                                Program.player.playSound(s);
                                sound.SubItems[4].Text = s.Plays.ToString();
                                populateSounds();
                            }
                        }
                        break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            AboutWindow about = new AboutWindow();
            about.ShowDialog();
        }
    }
}
