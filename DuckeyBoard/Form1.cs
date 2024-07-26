using DuckeyBoard.CustomControls;
using DuckeyBoard.KeyboardSetting;
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
            string quackFilePath = Path.Combine(appDirectory, @"resources\sound\quack.wav");

            KeyboardControl keyboardControl = new KeyboardControl(KeyboardLayout.FULL_SIZE, 48, 48);
            Panel panelKeyboard = new Panel();
            panelKeyboard.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            panelKeyboard.Width = keyboardControl.KeyboardWidth;
            panelKeyboard.Height = keyboardControl.KeyboardHeight;
            panelKeyboard.Controls.AddRange(keyboardControl.Keyboard.ToArray());
            this.containerMain.Panel2.Controls.Add(panelKeyboard);

            //ListBox listBox = new ListBox();
            //listBox.Location = new Point(1200, 10);
            //listBox.Width = 100;
            //listBox.Height = 250;
            //this.Controls.Add(listBox);

            _keyboardHook = new KeyboardListener();
            _keyboardHook.Install();

            _keyboardHook.KeyDown += (sender, e) =>
            {
                if (!IsUnikey(e.KeyCode))
                {
                    Task.Run(() => PlayTrack(quackFilePath));

                    // listBox.Items.Add($"{e.KeyCode} - {e.KeyValue} - {e.KeyData}");   
                }

                foreach (var button in this.Controls.OfType<Button>())
                {
                    if (button.Name == $"btn{e.KeyCode}")
                        button.BackColor = Color.Red;
                }
            };

            _keyboardHook.KeyUp += (sender, e) =>
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    if (button.Name == $"btn{e.KeyCode}")
                        button.BackColor = Color.White;
                }
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="quackFilePath"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private bool IsUnikey(Keys key)
        {
            // when typing with unikey, a bracket & a backspace is pressed
            List<Keys> unikeys = new List<Keys>() {
                Keys.Back,
                Keys.Packet
            };

            if (unikeys.Contains(key))
                return true;

            return false;
        }
    }
}