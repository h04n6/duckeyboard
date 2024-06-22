using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DuckeyBoard.CustomControls
{
    public class KeyboardControl
    {
        int _initX;
        int _initY;
        int _initBtnWidth;
        int _initBtnHeight;
        List<Button> _buttons;

        public KeyboardControl(
            int initX,
            int initY,
            int initBtnWidth = 45,
            int initBtnHeight = 45)
        {
            _initX = initX;
            _initY = initY;
            _initBtnWidth = initBtnWidth;
            _initBtnHeight = initBtnHeight;
            _buttons = new List<Button>();
        }

        public List<Button> Generate()
        {
            // Generate keys each row
            // TODO: R1F
            // R1
            

            // R2
            // R3
            // R4
            // R4C (Control, function & space)

        }

        private List<Button> CreateR1()
        {
            List<string> R1Title = new List<string>()
            {

            };

            for (int i = 0; i < 12; i++)
            {
                CreateKey()
            }
        }

        public Button CreateKey(string title, float u = 1)
        {
            Button btn = new Button();
            btn.Text = title;
            btn.Width = (int)(_initBtnWidth * u);
            btn.Height = _initBtnHeight;

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
