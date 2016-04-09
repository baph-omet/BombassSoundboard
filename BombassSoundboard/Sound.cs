using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BombassSoundboard {
    public class Sound {
        private String name;
        public String Name {
            get {
                return name;
            }
            set {
                update("name", value);
                name = value;
            }
        }
        public String location { get; }

        private int plays;
        public int Plays {
            get { return plays; }
            set {
                if (value >= 0) {
                    update("plays", value.ToString());
                    plays = value;
                }
            }
        }

        private Char keybind;
        public Char Keybind {
            get {
                return keybind;
            }
            set {
                update("keybind", value.ToString());
                keybind = value;
            }
        }

        public Sound(String location) : this(location, location.Split('\\')[location.Split('\\').Length - 1], '\0') { }
        public Sound(String location, String name) : this(location, name, '\0') { }
        public Sound(String location, String name, Char keybind) : this(location,name,keybind,0) { }
        public Sound(String location, String name, Char keybind, int plays) {
            if (!File.Exists(location)) throw new ArgumentException("Invalid file location. No file located at " + location);
            else if (!(new String[] { "wav", "mp3" }.Contains(location.Split('.')[1].ToLower()))) throw new ArgumentException("Invalid file type. Must be either .wav or .mp3");
            this.location = location;
            this.Name = name;
            this.Keybind = keybind;
            this.Plays = plays;
        }

        public void play() {
            SoundPlayer player = new SoundPlayer(location);
            player.Play();
        }

        public bool isMP3() {
            return location.Split('.')[1].ToLower().Equals("mp3");
        }

        private void update(String property, String newValue) {
            XmlNode node = null;

            String filename = location.Split('\\')[location.Split('\\').Length - 1];

            foreach (XmlNode n in Program.registry.GetElementsByTagName("sounds")[0].ChildNodes) {
                foreach (XmlNode child in n.ChildNodes) {
                    if (child.Name.Equals("path") && child.InnerText.Equals(filename)) {
                        node = n;
                        break;
                    }
                }
                if (node != null) break;
            }

            if (node != null) {
                foreach (XmlNode child in node.ChildNodes) {
                    if (child.Name.Equals(property)) {
                        child.InnerText = newValue;
                        Program.registry.Save(Directory.GetCurrentDirectory() + "\\Registry.xml");
                        break;
                    }
                }
            }
        }
    }
}
