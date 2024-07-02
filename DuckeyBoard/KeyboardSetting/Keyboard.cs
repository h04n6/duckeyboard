namespace DuckeyBoard.KeyboardSetting
{
    public class Keyboard
    {
        public KeyboardLayout KeyboardLayout { get; set; }
        public List<KeyRow> Rows { get; set; }
        public List<KeyModel> Keys { get; set; }

        public Keyboard FullSize()
        {
            List<KeyModel> result = new List<KeyModel>();
            // R1F
            result.AddRange(new List<KeyModel>() {
                Key.ESC, Key.F1, Key.F2, Key.F3, Key.F4,
                Key.F5, Key.F6, Key.F7, Key.F8, Key.F9, Key.F10,
                Key.F11, Key.F12
            });
            // R1
            result.AddRange(new List<KeyModel>() {
                Key.Tilde, Key.D1, Key.D2, Key.D3, Key.D4,
                Key.D5, Key.D6, Key.D7, Key.D8, Key.D9, Key.D0,
                Key.Minus, Key.Plus, Key.Backspace
            });
            // R2
            result.AddRange(new List<KeyModel>() {
                Key.Tab, Key.Q, Key.W, Key.E, Key.R,
                Key.T, Key.Y, Key.U, Key.I, Key.O, Key.P,
                Key.OpenBracket, Key.CloseBracket, Key.Pipe 
            });

            return new Keyboard
            {
                KeyboardLayout = KeyboardLayout.FULL_SIZE,
                Rows = new List<KeyRow> { 
                    KeyRow.R1F, 
                    KeyRow.R1,
                    KeyRow.R2,
                    KeyRow.R3,
                    KeyRow.R4,
                    KeyRow.R4F,
                },
                Keys = result
            };
        }
    }
}
