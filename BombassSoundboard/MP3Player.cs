using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BombassSoundboard {
    public class MP3Player : IDisposable {
        /// <summary>
        /// The path to the loaded file. This is also the alias used to identify the stream.
        /// </summary>
        private string path = "";
        private bool open = false;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        [DllImport("winmm.dll")]
        private static extern bool mciGetErrorString(int errorCode, StringBuilder errorText, int errorTextSize);

        public MP3Player() {}

        public void Open(String path) {
            this.path = path;
            const string FORMAT = @"open ""{0}""";// type mpegvideo alias {0}";
            SendCommand(String.Format(FORMAT, path));
            open = true;
        }

        /// <summary>
        /// Pauses playback of the loaded audio file.
        /// </summary>
        /// <exception cref="MultiMediaException"></exception>
        public void Pause() {
            SendCommand("pause \"" + path + "\"");
        }

        /// <summary>
        /// Closes the loaded audio file.
        /// </summary>
        /// <exception cref="MultiMediaException"></exception>
        public void Close() {
            if (open && path.Length > 0) SendCommand("close \"" + path + "\"");
            open = false;
        }

        /// <summary>
        /// Plays the loaded audio file.
        /// </summary>
        /// <param name="loop">Whether to loop playback.</param>
        /// <exception cref="MultiMediaException"></exception>
        public void Play(bool loop) {
            string command = "play \"" + path + "\"";
            if (loop) command += " REPEAT";
            SendCommand(command);
        }

        /// <summary>
        /// Stops playback of the loaded audio file.
        /// </summary>
        /// <exception cref="MultiMediaException"></exception>
        public void Stop() {
            if (open && path.Length > 0) SendCommand("stop \"" + path + "\"");
        }

        /// <summary>
        /// Sends a command to the multimedia control interface.
        /// </summary>
        /// <param name="command">The command to send.</param>
        /// <exception cref="MultiMediaException"></exception>
        private static void SendCommand(string command) {
            long errorData = mciSendString(command, null, 0, IntPtr.Zero);
            var errorCode = GetLowInt(errorData);

            if (errorCode != 0) {
                var SB = new StringBuilder(1000);
                mciGetErrorString(errorCode, SB, SB.Capacity);
                throw new Exception(SB.ToString());
            }
        }

        /// <summary>
        /// Gets the low order of a 64 bit integer.
        /// </summary>
        private static int GetLowInt(long intValue) {
            long tmp = intValue << 32;
            return Convert.ToInt32(tmp >> 32);
        }

        public void Dispose() {
            Close();
        }
    }
}
