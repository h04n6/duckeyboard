using DuckeyBoard.Helpers;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace DuckeyBoard.CustomControls
{
    public class KeyboardControl
    {
        int _initX;
        int _initY;
        int _margin;
        int _initBtnWidth;
        int _initBtnHeight;
        List<Button> _buttons;
        Fullsize _keyboard;

        public KeyboardControl(
            int initX,
            int initY,
            int margin = 3,
            int initBtnWidth = 45,
            int initBtnHeight = 45)
        {
            _initX = initX;
            _initY = initY;
            _margin = margin;
            _initBtnWidth = initBtnWidth;
            _initBtnHeight = initBtnHeight;
            _buttons = new List<Button>();
            _keyboard = new Fullsize();
        }

        public IEnumerable<Button> Generate()
        {
            // Generate keys each row
            // TODO: R1F
            // R1
            // return CreateR1();
            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Helpers\KeyboardTemplate\Fullsize.json");
            //string jsonData = File.ReadAllText(path);
            //List<Key> keyboardKeys = JsonSerializer.Deserialize<List<Key>>(jsonData);

            foreach (var key in _keyboard.GenerateKeys())
                yield return CreateKey(key);

            // R2
            // R3
            // R4
            // R4C (Control, function & space)

        }

        private IEnumerable<Button> CreateR1()
        {
            var R1Keys = _keyboard.KeyboardKeys.Where(x => x.Row == KeyRow.R1F);

            foreach (var R1Key in R1Keys)
                yield return CreateKey(R1Key);
        }

        private Button CreateKey(Key key)
        {
            Button btn = new Button();
            btn.Text = key.Title;
            btn.Width = (int)(_initBtnWidth * key.Unit);
            btn.Height = _initBtnHeight;

            int x = (int)((_initX + _margin) * (key.IndexInRow + 1));
            int y = (_initY + _margin) * (key.RowIndex + 1);
            btn.Location = new Point(x, y);

            btn.Click += Btn_Key_Click;

            return btn;
        }

        private void Btn_Key_Click(object? sender, EventArgs e)
        {
            // TODO: open an popup and register a specified sound for this key

            throw new NotImplementedException();
        }
    }
}
