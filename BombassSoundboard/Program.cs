using BombassSoundboard.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BombassSoundboard {
    public static class Program {

        public static AudioPlayer player;
        public static XmlDocument registry;

        public static MainWindow window;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            try {
                initialize();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                window = new MainWindow();
                Application.Run(window);
            } catch (Exception e) {
                MessageBox.Show("An unexpected error occurred. Here are the details:\n" + e.ToString(), "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void initialize() {
            player = new AudioPlayer();
            registry = new XmlDocument();

            string registrypath = Directory.GetCurrentDirectory() + "\\Registry.xml";
            if (!File.Exists(registrypath)) {
                XmlDocument reg = new XmlDocument();
                reg.AppendChild(reg.CreateNode("element", "sounds", ""));
                reg.Save(registrypath);
            }
                //File.Copy("Registry.xml", registrypath);
            registry.Load(registrypath);

            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Sounds")) Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Sounds");

            player.loadSounds();
        }
    }
}
