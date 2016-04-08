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
        public String name {
            get {
                return name;
            }
            set {
                update("name", value);
                name = value;
            }
        }
        public String location { get; }

        public Char keybind {
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
        public Sound(String location, String name, Char keybind) {
            if (!File.Exists(location)) throw new ArgumentException("Invalid file location. No file located at " + location);
            else if (!(new String[] { "wav", "mp3" }.Contains(location.Split('.')[1].ToLower()))) throw new ArgumentException("Invalid file type. Must be either .wav or .mp3");
            this.location = location;
            this.name = name;
            this.keybind = keybind;
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

            foreach (XmlNode n in Program.registry.ChildNodes) {
                foreach (XmlNode child in n.ChildNodes) {
                    if (child.Name.Equals("path") && child.InnerText.Equals(location)) node = n;
                }
            }

            if (node != null) foreach (XmlNode child in node.ChildNodes) if (child.Name.Equals(property)) child.InnerText = newValue;
        }
    }
}
