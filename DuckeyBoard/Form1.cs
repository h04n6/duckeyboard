using DuckeyBoard.CustomControls;
using System.Media;
using System.Runtime.InteropServices;

namespace DuckeyBoard
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        KeyboardListener _keyboardHook;


        // public static readonly string appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static readonly string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string quackFilePath = Path.Combine(appDirectory, @"quack.wav");

        public static SoundPlayer simpleSound = new SoundPlayer(quackFilePath);

        public Form1()
        {
            InitializeComponent();

            KeyboardControl keyboardControl = new KeyboardControl(50, 50);
            this.Controls.AddRange(keyboardControl.Generate().ToArray());

            ListBox listBox1 = new ListBox();
            listBox1.Location = new Point(10, 10);
            listBox1.Size = new Size(200, 200);
            this.Controls.Add(listBox1);

            _keyboardHook = new KeyboardListener();
            _keyboardHook.Install();

            _keyboardHook.KeyDown += (sender, e) =>
            {
                listBox1.Items.Add("KeyDown: " + e.KeyCode);

                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            };

            _keyboardHook.KeyUp += (sender, e) =>
            {
                listBox1.Items.Add("KeyUp: " + e.KeyCode);

                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            };

            _keyboardHook.KeyUp += (sender, e) =>
            {
                
            };

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

        protected override void WndProc(ref Message m)
        {
            // Catch when a Hot key is pressed
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == 1)
                {
                    MessageBox.Show("A was pressed");
                    // simpleSound.Play();
                }
            }

            base.WndProc(ref m);
        }
    }
}