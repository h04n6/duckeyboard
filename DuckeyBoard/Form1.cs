using DuckeyBoard.CustomControls;
using DuckeyBoard.KeyboardSettings;
using System.Runtime.InteropServices;
using System.Text;

namespace DuckeyBoard
{
    public partial class Form1 : Form
    {


        KeyboardListener _keyboardHook;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxKeyboardLayout.DisplayMember = "Text";
            cbxKeyboardLayout.ValueMember = "Value";

            cbxKeyboardLayout.Items.Add(new { Text = "Fullsize", Value = KeyboardLayout.FULL_SIZE });
            cbxKeyboardLayout.Items.Add(new { Text = "TKL", Value = KeyboardLayout.TKL });
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxKeyboardLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbxKeyboardSeleted = cbxKeyboardLayout.SelectedItem as dynamic;
            if (cbxKeyboardSeleted != null) {
                switch (cbxKeyboardSeleted.Value)
                {
                    case KeyboardLayout.FULL_SIZE:
                        GenerateKeyboardControl(KeyboardLayout.FULL_SIZE);
                        break;
                    case KeyboardLayout.TKL:
                        GenerateKeyboardControl(KeyboardLayout.TKL);
                        break;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyboardLayout"></param>
        private void GenerateKeyboardControl(KeyboardLayout keyboardLayout)
        {
            foreach (Control item in this.containerMain.Panel2.Controls)
            {
                this.containerMain.Panel2.Controls.Remove(item);
            }

            KeyboardControl keyboardControl = new KeyboardControl(keyboardLayout, 48, 48);
            Panel panelKeyboard = new Panel();
            panelKeyboard.Anchor = AnchorStyles.None;
            panelKeyboard.Width = keyboardControl.KeyboardWidth;
            panelKeyboard.Height = keyboardControl.KeyboardHeight;
            panelKeyboard.Controls.AddRange(keyboardControl.Keyboard.ToArray());
            panelKeyboard.Location = new Point(
                this.containerMain.Panel2.Width / 2 - panelKeyboard.Size.Width / 2,
                this.containerMain.Panel2.Height / 2 - panelKeyboard.Size.Height / 2);
            this.containerMain.Panel2.Controls.Add(panelKeyboard);

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string quackFilePath = Path.Combine(appDirectory, @"resources\sound\quack.wav");

            _keyboardHook = new KeyboardListener();
            _keyboardHook.Install();
            _keyboardHook.KeyDown += (sender, e) =>
            {
                if (!IsUnikey(e.KeyCode))
                {
                    Task.Run(() => PlayTrack(quackFilePath));
                }

                foreach (var button in panelKeyboard.Controls.OfType<Button>())
                {
                    if (button.Name == $"btn{e.KeyCode}")
                        button.BackColor = Color.Red;
                }
            };
            _keyboardHook.KeyUp += (sender, e) =>
            {
                foreach (var button in panelKeyboard.Controls.OfType<Button>())
                {
                    if (button.Name == $"btn{e.KeyCode}")
                        button.BackColor = Color.White;
                }
            };
        }
    }
}