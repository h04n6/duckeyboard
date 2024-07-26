using DuckeyBoard.KeyboardSetting;
using DuckeyBoard.Utilities;

namespace DuckeyBoard.CustomControls
{
    public class KeyboardControl
    {
        private int _initX;
        private int _initY;
        private int _margin;
        private int _initBtnWidth;
        private int _initBtnHeight;

        public int KeyboardHeight { get; set; }
        public int KeyboardWidth { get; set; }
        public KeyboardLayout KeyboardLayout { get; set; }
        public IEnumerable<Button> Keyboard { get; set; }

        public KeyboardControl(
            KeyboardLayout keyboardLayout,
            int initX,
            int initY,
            int margin = 12,
            int initBtnWidth = 48,
            int initBtnHeight = 48)
        {
            _initX = initX;
            _initY = initY;
            _margin = margin;
            _initBtnWidth = initBtnWidth;
            _initBtnHeight = initBtnHeight;
            KeyboardLayout = keyboardLayout;
            Keyboard = Generate(KeyboardLayout);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyboardLayoutEnum"></param>
        /// <returns></returns>
        private IEnumerable<Button> Generate(KeyboardLayout keyboardLayoutEnum)
        {
            Keyboard keyboard = new Keyboard();
            switch (keyboardLayoutEnum)
            {
                case KeyboardLayout.FULL_SIZE:
                    return CreateKeys(keyboard.FullSize());
                default:
                    return CreateKeys(keyboard.FullSize());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyboard"></param>
        /// <returns></returns>
        private List<Button> CreateKeys(Keyboard keyboard)
        {
            int maxWidthUnit = 0;
            List<Button> keys = new List<Button>();
            foreach (var (row, rowIndex) in keyboard.KeyboardRows.WithIndex())
            {
                float totalHorizontalUnit = 1;
                foreach (var key in row.Keys)
                {
                    // init button
                    Button btn = new Button();
                    btn.Text = key.Title;
                    btn.Width = (int)(_initBtnWidth * key.HorizontalUnit);
                    btn.Height = (int)(_initBtnHeight * key.VerticalUnit);

                    if (key.Type == KeyType.BLANK)
                    {
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
                        btn.BackColorChanged += (s, e) =>
                        {
                            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
                        };
                        btn.Enabled = false;
                    }

                    // location of button
                    int x = (int)(_initX * totalHorizontalUnit);
                    int y = _initY * rowIndex;
                    if (row.Row != KeyRow.R1F)
                        y += _initBtnHeight / 2;
                    btn.Location = new Point(x, y);

                    // assign name with WinKey enum to do event logic
                    btn.Name = $"btn{key.WinKey}";

                    // handle click event of button
                    btn.Click += Btn_Key_Click;

                    // save the total unit length of previous buttons
                    // to calculate the next button localtion
                    totalHorizontalUnit += key.HorizontalUnit;

                    btn.Margin = new Padding(20);
                    keys.Add(btn);
                    // yield return btn;
                }

                if (maxWidthUnit < totalHorizontalUnit)
                    maxWidthUnit = (int)totalHorizontalUnit;
            }

            KeyboardWidth = (maxWidthUnit * _initBtnWidth) + 50;
            KeyboardHeight = (keyboard.KeyboardRows.Count() * _initBtnHeight) + 50;

            return keys;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Key_Click(object? sender, EventArgs e)
        {
            // TODO: 
        }
    }
}
