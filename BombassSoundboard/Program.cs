using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombassSoundboard {
    public static class Program {

        public static AudioPlayer player;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        private static void initialize() {
            player = new AudioPlayer();
            loadSounds();
        }

        public static void loadSounds() {
            foreach (String filename in Directory.GetFiles(Directory.GetCurrentDirectory())) {
                String extension = filename.Split('.')[1].ToLower();
                if ((new String[] { "wav", "mp3" }).Contains(extension)) {
                    //TODO: load sound from XML file
                }
            }
        }
    }
}
