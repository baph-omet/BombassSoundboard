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

        public void playSound(Sound sound) {
            stopSound();
            if (sound.isMP3()) {
                mp3Player.Open(sound.location);
                mp3Player.Play(false);
            } else {
                player.SoundLocation = sound.location;
                player.Play();
            }
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
        }

        public void stopSound() {
            player.Stop();
            mp3Player.Stop();
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
                if (s.location.Equals(filename)) return true;
            }
            return false;
        }

        public void loadSounds() {
            foreach (XmlNode node in Program.registry.ChildNodes) {
                if (node.Name.ToLower().Equals("sound")) {
                    String soundName = "";
                    String soundPath = "";
                    Char soundKey = '\0';
                    foreach (XmlNode prop in node.ChildNodes) {
                        switch (prop.Name.ToLower()) {
                            case "name":
                                soundName = prop.Value;
                                break;
                            case "path":
                                bool isValid = true;
                                foreach (Sound s in getSounds()) {
                                    if (s.location.Equals(prop.Value)) {
                                        isValid = false;
                                        break;
                                    }
                                }
                                if (!isValidSoundFile(Directory.GetCurrentDirectory() + "\\Sounds\\" + prop.Value)) isValid = false;
                                if (isValid) soundPath = prop.Value;
                                break;
                            case "keybind":
                                if (prop.Value != null && prop.Value.Length > 0) soundKey = prop.Value[0];
                                break;
                        }
                    }
                    if (soundName.Length > 0 && soundPath.Length > 0) addSound(new Sound(soundPath, soundName, soundKey));
                }
            }
        }

        public void loadNewSound(String filepath) {
            String filename = filepath.Split('\\')[filepath.Split('\\').Length - 1];
            if (isValidSoundFile(filepath)) {
                if (!soundRegistered(filename)) {
                    File.Copy(filepath, Directory.GetCurrentDirectory() + "\\Sounds\\" + filename);

                    XmlNode node = Program.registry.CreateNode("element", "sound", "");
                    XmlNode nameNode = Program.registry.CreateNode("element", "name", "");
                    nameNode.InnerText = filename;
                    XmlNode pathNode = Program.registry.CreateNode("element", "path", "");
                    pathNode.InnerText = filename;
                    XmlNode keybindNode = Program.registry.CreateNode("element", "keybind", "");
                    keybindNode.InnerText = "";

                    node.AppendChild(nameNode);
                    node.AppendChild(pathNode);
                    node.AppendChild(keybindNode);
                    Program.registry.AppendChild(node);

                } else throw new InvalidSoundFileException("A sound file called " + filename + " is already registered. Either this is a duplicate or you need to change this file's name.");
            } else throw new InvalidSoundFileException("Invalid sound file: " + filepath + "\nMust be an existing .mp3 or .wav file.");
        }

        private static bool isValidSoundFile(String filepath) {
            return !File.Exists(filepath) || !filepath.Contains('.') || !(new String[] { "mp3", "wav" }.Contains(filepath.Split('.')[1]));
        }
    }
}
