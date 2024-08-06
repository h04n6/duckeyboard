using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DuckeyBoard.TrackSettings
{
    public class TrackExtensions
    {
        [DllImport("winmm.dll")]
        public static extern int mciSendString(string command, StringBuilder buffer, int bufferSize, nint hwndCallback);

        private string _trackFilePath;

        public TrackExtensions(string trackFilePath)
        {
            _trackFilePath = trackFilePath;
        }

        private void PlayTrack(string quackFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string trackName = "quackquack";
            int openTrack = mciSendString($"open \"{quackFilePath}\" type waveaudio alias {trackName}", sb, 0, nint.Zero);
            int playTrack = mciSendString($"play {trackName}", sb, 0, nint.Zero);
            sb = new StringBuilder();
            mciSendString($"status {trackName} length", sb, 255, nint.Zero);
            int length = Convert.ToInt32(sb.ToString());
            bool IsBeingPlayed = true;
            int pos = 0;

            while (IsBeingPlayed)
            {
                sb = new StringBuilder();
                mciSendString($"status {trackName} position", sb, 255, nint.Zero);
                pos = Convert.ToInt32(sb.ToString());
                if (pos >= length)
                {
                    IsBeingPlayed = false;
                    break;
                }
            }

            var stopTrack = mciSendString($"stop {trackName}", sb, 0, nint.Zero);
            var closeTrack = mciSendString($"close {trackName}", sb, 0, nint.Zero);
        }



    }
}
