using BombassSoundboard.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BombassSoundboard {
    public class AudioPlayer : IDisposable {

        private SoundPlayer player = new SoundPlayer();
        private MP3Player mp3Player = new MP3Player();

        private List<Sound> sounds;

        public AudioPlayer() {
            sounds = new List<Sound>();
        }

        public Sound getSound(String path) {
            foreach (Sound sound in sounds) {
                if (sound.location.ToLower().Equals(path.ToLower())) return sound;
            } return null;
        }

        public void playSound(Sound sound) {
            stopSound();
            if (sound.isMP3()) {
                mp3Player.Open(sound.location);
                mp3Player.Play(false);
            } else {
                player.SoundLocation = sound.location;
                player.Play();
            }
            sound.Plays++;
        }

        public void loopSound(Sound sound) {
            stopSound();
            if (sound.isMP3()) {
                mp3Player.Open(sound.location);
                mp3Player.Play(true);
            } else {
                player.SoundLocation = sound.location;
                player.PlayLooping();
            }
            sound.Plays++;
        }

        public void stopSound() {
            player.Stop();
            mp3Player.Stop();
            mp3Player.Close();
        }

        public void Dispose() {
            stopSound();
            player.Dispose();
            mp3Player.Dispose();
        }

        public void addSound(Sound sound) {
            sounds.Add(sound);
        }

        public List<Sound> getSounds() {
            return sounds;
        }

        public bool soundRegistered(String filename) {
            foreach (Sound s in sounds) {
                if (s.location.Split('\\')[s.location.Split('\\').Length - 1].Equals(filename)) return true;
            }
            return false;
        }

        public void loadSounds() {
            foreach (XmlNode node in Program.registry.GetElementsByTagName("sounds")[0].ChildNodes) {
                if (node.Name.ToLower().Equals("sound")) {
                    String soundName = "";
                    String soundPath = "";
                    int soundPlays = 0;
                    Char soundKey = '\0';
                    foreach (XmlNode prop in node.ChildNodes) {
                        switch (prop.Name.ToLower()) {
                            case "name":
                                soundName = prop.InnerText;
                                break;
                            case "path":
                                bool isValid = true;
                                foreach (Sound s in getSounds()) {
                                    if (s.location.Equals(prop.Value)) {
                                        isValid = false;
                                        break;
                                    }
                                }
                                if (!isValidSoundFile(Directory.GetCurrentDirectory() + "\\Sounds\\" + prop.InnerText)) isValid = false;
                                if (isValid) soundPath = Directory.GetCurrentDirectory() + "\\Sounds\\" + prop.InnerText;
                                break;
                            case "plays":
                                try {
                                    soundPlays = Convert.ToInt32(prop.InnerText);
                                } catch (Exception) { }
                                break;
                            case "keybind":
                                if (prop.InnerText != null && prop.InnerText.Length > 0) soundKey = prop.InnerText[0];
                                break;
                        }
                    }
                    if (soundName.Length > 0 && soundPath.Length > 0) addSound(new Sound(soundPath, soundName, soundKey,soundPlays));
                }
            }
        }

        public void loadNewSound(String filepath) {
            String filename = filepath.Split('\\')[filepath.Split('\\').Length - 1];
            if (isValidSoundFile(filepath)) {
                if (!soundRegistered(filename)) {
                    if (!File.Exists(Directory.GetCurrentDirectory() + "\\Sounds\\" + filename)) File.Copy(filepath, Directory.GetCurrentDirectory() + "\\Sounds\\" + filename);

                    XmlNode node = Program.registry.CreateNode("element", "sound", "");
                    XmlNode nameNode = Program.registry.CreateNode("element", "name", "");
                    nameNode.InnerText = filename;
                    XmlNode pathNode = Program.registry.CreateNode("element", "path", "");
                    pathNode.InnerText = filename;
                    XmlNode playsNode = Program.registry.CreateNode("element", "plays", "");
                    playsNode.InnerText = "0";
                    XmlNode keybindNode = Program.registry.CreateNode("element", "keybind", "");
                    keybindNode.InnerText = "";

                    node.AppendChild(nameNode);
                    node.AppendChild(pathNode);
                    node.AppendChild(playsNode);
                    node.AppendChild(keybindNode);
                    Program.registry.GetElementsByTagName("sounds")[0].AppendChild(node);
                    Program.registry.Save(Directory.GetCurrentDirectory() + "\\Registry.xml");

                    sounds.Add(new Sound(Directory.GetCurrentDirectory() + "\\Sounds\\" + filename));

                } else throw new InvalidSoundFileException("A sound file called " + filename + " is already registered. Either this is a duplicate or you need to change this file's name.");
            } else throw new InvalidSoundFileException("Invalid sound file: " + filepath + "\nMust be an existing .mp3 or .wav file.");
        }

        public void deleteSound(String filepath) {
            String filename = filepath.Split('\\')[filepath.Split('\\').Length - 1];
            if (File.Exists(filepath)) File.Delete(filepath);

            int foundindex = -1;
            foreach (Sound sound in sounds) {
                if (sound.location.Equals(filepath)) {
                    foundindex = sounds.IndexOf(sound);
                }
            }
            if (foundindex > -1) sounds.RemoveAt(foundindex);

            bool foundEntry = false;

            foreach (XmlNode node in Program.registry.GetElementsByTagName("sounds")[0].ChildNodes) {
                foreach (XmlNode child in node) {
                    if (child.Name.Equals("path") && child.InnerText.Equals(filename)) {
                        foundEntry = true;
                        break;
                    }
                } if (foundEntry) {
                    Program.registry.GetElementsByTagName("sounds")[0].RemoveChild(node);
                    Program.registry.Save(Directory.GetCurrentDirectory() + "\\Registry.xml");
                    break;
                }
            }
        }

        public int getTotalPlays() {
            int total = 0;
            foreach (Sound sound in sounds) total += sound.Plays;
            return total;
        }

        private static bool isValidSoundFile(String filepath) {
            return File.Exists(filepath) && filepath.Contains('.') && (new String[] { "mp3", "wav" }.Contains(filepath.Split('.')[1]));
        }
    }
}
