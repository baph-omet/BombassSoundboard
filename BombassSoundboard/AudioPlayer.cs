using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BombassSoundboard {
    public class AudioPlayer : IDisposable {

        private SoundPlayer player = new SoundPlayer();
        private MP3Player mp3Player = new MP3Player();

        private List<BASound> sounds;

        public AudioPlayer() {
            sounds = new List<BASound>();
        }

        public void playSound(BASound sound) {
            stopSound();
            if (sound.isMP3()) {
                mp3Player.Open(sound.location);
                mp3Player.Play(false);
            } else {
                player.SoundLocation = sound.location;
                player.Play();
            }
        }

        public void loopSound(BASound sound) {
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

        public void addSound(BASound sound) {
            sounds.Add(sound);
        }

        public List<BASound> getSounds() {
            return sounds;
        }
    }
}
