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
            registry = new XmlDocument();

            string registrypath = Directory.GetCurrentDirectory() + "\\Registry.xml";
            if (!File.Exists(registrypath)) File.Copy("Registry.xml", registrypath);
            registry.Load(registrypath);

            player.loadSounds();
        }
    }
}
