using DuckeyBoard.CustomControls;
using DuckeyBoard.KeyboardSetting;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;

namespace DuckeyBoard
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("winmm.dll")]
        public static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        KeyboardListener _keyboardHook;


        // public static readonly string appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


        public Form1()
        {

            InitializeComponent();
            // Register Hotkey
            // Set an unique id for the Hotkey, it will be used to identify which hotkey was pressed in code to execute something
            //int uniqueHotKeyId = 1;
            //int hotKeyCode = (int)Keys.A;
            //Boolean hotKeyRegistered = RegisterHotKey(this.Handle, uniqueHotKeyId, 0x0000, hotKeyCode);
            //if (hotKeyRegistered)
            //    Console.WriteLine("Global HotKey was successfully registered!");
            //else
            //    Console.WriteLine("[ERROR] Global HotKey was couldn't be registered!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // string quackFilePath = Path.Combine(appDirectory, @"resources\sound\quack.wav");
            string quackFilePath = @"C:\Users\HOANGHD\Downloads\quack.wav";

            SoundPlayer simpleSound = new SoundPlayer();

            KeyboardControl keyboardControl = new KeyboardControl(50, 50);
            this.Controls.AddRange(keyboardControl.Generate(KeyboardLayout.FULL_SIZE).ToArray());

            _keyboardHook = new KeyboardListener();
            _keyboardHook.Install();

            _keyboardHook.KeyDown += (sender, e) =>
            {
                Task.Run(() => PlayTrackAsync());

                foreach (var button in this.Controls.OfType<Button>())
                {
                    if (button.Name == $"btn{e.KeyCode}")
                        button.BackColor = Color.Red;
                }
                //Debug.WriteLine("openTrack: " + openTrack.ToString());
                //Debug.WriteLine("playtrack: " + playTrack.ToString());
            };

            _keyboardHook.KeyUp += (sender, e) =>
            {
                // PlayTrackAsync();

                foreach (var button in this.Controls.OfType<Button>())
                {
                    if (button.Name == $"btn{e.KeyCode}")
                        button.BackColor = Color.White;
                }
                // MessageBox.Show("err: " + err.ToString());

                //var stopTrack = mciSendString($"stop {trackName}", sb, 0, IntPtr.Zero);
                //var closeTrack = mciSendString($"close {trackName}", sb, 0, IntPtr.Zero);

                StringBuilder sb = new StringBuilder();
                var stopTrack = mciSendString($"stop cachcach", sb, 0, IntPtr.Zero);
                var closeTrack = mciSendString($"close cachcach", sb, 0, IntPtr.Zero);
            };
        }

        // TODO: 
        private async Task PlayTrackAsync()
        {
            StringBuilder sb = new StringBuilder();
            string quackFilePath = @"C:\Users\HOANGHD\Downloads\clack.wav";
            string trackName = "cachcach";
            int openTrack = mciSendString($"open \"{quackFilePath}\" type waveaudio alias {trackName}", sb, 0, IntPtr.Zero);
            // int openTrack = mciSendString($"open \"{quackFilePath}\" alias {trackName}", sb, 0, IntPtr.Zero);
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

            Debug.WriteLine("quack ");
        }

        //protected override void WndProc(ref Message m)
        //{
        //    // Catch when a Hot key is pressed
        //    if (m.Msg == 0x0312)
        //    {
        //        int id = m.WParam.ToInt32();
        //        if (id == 1)
        //        {
        //            MessageBox.Show("A was pressed");
        //            // simpleSound.Play();
        //        }
        //    }

        //    base.WndProc(ref m);
        //}
    }
}