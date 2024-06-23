using DuckeyBoard.Helpers;

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
        Keyboard _keyboard;

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
            _keyboard = new Keyboard();
        }

        public IEnumerable<Button> Generate()
        {
            // Generate keys each row
            // TODO: R1F
            // R1
            return CreateR1();

            // R2
            // R3
            // R4
            // R4C (Control, function & space)

        }

        private IEnumerable<Button> CreateR1()
        {
            var R1Keys = _keyboard.KeyboardKeys.Where(x => x.Row == KeyboardRow.R1);

            foreach (var R1Key in R1Keys)
                yield return CreateKey(R1Key);
        }

        private Button CreateKey(KeyboardKey key)
        {
            Button btn = new Button();
            btn.Text = key.Title;
            btn.Width = (int)(_initBtnWidth * key.Unit);
            btn.Height = _initBtnHeight;

            int x = (_initX + _margin) * (key.IndexInRow + 1);
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
