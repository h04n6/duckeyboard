using DuckeyBoard.KeyboardSetting;
using System.Diagnostics;

namespace DuckeyBoard.CustomControls
{
    public class KeyboardControl
    {
        private int _initX;
        private int _initY;
        private int _margin;
        private int _initBtnWidth;
        private int _initBtnHeight;

        public KeyboardControl(
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
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyboardLayoutEnum"></param>
        /// <returns></returns>
        public IEnumerable<Button> Generate(KeyboardLayout keyboardLayoutEnum)
        {
            Keyboard keyboard = new Keyboard();
            switch(keyboardLayoutEnum)
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
        private IEnumerable<Button> CreateKeys(Keyboard keyboard)
        {
            foreach (var row in keyboard.Rows)
            {
                var keys = keyboard.Keys
                    .Where(x => x.Row == row)
                    .OrderBy(x => x.IndexInRow);
                float totalUnit = 1;
                foreach (var key in keys)
                {
                    // init button
                    Button btn = new Button();
                    btn.Text = key.Title;
                    btn.Width = (int)(_initBtnWidth * key.Unit);
                    btn.Height = _initBtnHeight;

                    // location of button
                    int x = (int)(_initX * totalUnit);

                    if (row == KeyRow.R1F && keyboard.KeyboardLayout == KeyboardLayout.FULL_SIZE)
                        x = (int)(_initX * (key.IndexInRow + 1));
                    
                    int y = _initY * (key.RowIndex + 1);

                    btn.Location = new Point(x, y);
                    
                    // assign name with WinKey enum to do event logic
                    btn.Name = $"btn{key.WinKey}";

                    // handle click event of button
                    btn.Click += Btn_Key_Click;

                    // save the total unit length of previous buttons
                    // to calculate the next button localtion
                    totalUnit += key.Unit;

                    yield return btn;
                }
            }
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
