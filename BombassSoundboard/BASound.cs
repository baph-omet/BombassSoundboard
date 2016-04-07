using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BombassSoundboard {
    public class BASound {
        public String name { get; set; }
        public String location { get; }

        public Char keybind { get; set; }

        public BASound(String location) : this(location, location.Split('\\')[location.Split('\\').Length - 1], '\0') { }
        public BASound(String location, String name) : this(location, name, '\0') { }
        public BASound(String location, String name, Char keybind) {
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
    }
}
