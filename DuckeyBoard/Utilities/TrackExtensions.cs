using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DuckeyBoard.Utilities
{
    public class TrackExtensions
    {
        [DllImport("winmm.dll")]
        public static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        private string _trackFilePath;

        public TrackExtensions(string trackFilePath)
        {
            this._trackFilePath = trackFilePath;
        }

        private void PlayTrack(string quackFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string trackName = "quackquack";
            int openTrack = mciSendString($"open \"{quackFilePath}\" type waveaudio alias {trackName}", sb, 0, IntPtr.Zero);
            int playTrack = mciSendString($"play {trackName}", sb, 0, IntPtr.Zero);
            sb = new StringBuilder();
            mciSendString($"status {trackName} length", sb, 255, IntPtr.Zero);
            int length = Convert.ToInt32(sb.ToString());
            bool IsBeingPlayed = true;
            int pos = 0;

            while (IsBeingPlayed)
            {
                sb = new StringBuilder();
                mciSendString($"status {trackName} position", sb, 255, IntPtr.Zero);
                pos = Convert.ToInt32(sb.ToString());
                if (pos >= length)
                {
                    IsBeingPlayed = false;
                    break;
                }
            }

            var stopTrack = mciSendString($"stop {trackName}", sb, 0, IntPtr.Zero);
            var closeTrack = mciSendString($"close {trackName}", sb, 0, IntPtr.Zero);
        }

    }
}
