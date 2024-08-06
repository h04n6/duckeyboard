namespace DuckeyBoard.KeyboardSettings
{
    public class Keyboard
    {
        public KeyboardLayout KeyboardLayout { get; set; }
        public List<KeyboardRow> KeyboardRows { get; set; }

        public Keyboard FullSize()
        {
            return new Keyboard
            {
                KeyboardLayout = KeyboardLayout.FULL_SIZE,
                KeyboardRows = new List<KeyboardRow>
                {
                    new KeyboardRow
                    {
                        Row = KeyRow.R1F,
                        Keys = new List<KeyModel>
                        {
                            Key.ESC, Key.Blank_1U, Key.F1, Key.F2, Key.F3, Key.F4,
                            Key.Blank_1_And_A_Half_U, Key.F5, Key.F6, Key.F7, Key.F8,
                            Key.Blank_1_And_A_Half_U, Key.F9, Key.F10, Key.F11, Key.F12,
                            Key.Blank_1_And_A_Half_U,
                            Key.PrintScreen, Key.ScrollLock, Key.Pause
                        }
                    },
                    new KeyboardRow
                    {
                        Row = KeyRow.R1,
                        Keys = new List<KeyModel>
                        {
                            Key.Tilde, Key.D1, Key.D2, Key.D3, Key.D4,
                            Key.D5, Key.D6, Key.D7, Key.D8, Key.D9, Key.D0,
                            Key.Minus, Key.Plus, Key.Backspace,
                            Key.Blank_1_And_A_Half_U,
                            Key.Insert, Key.Home, Key.PageUp,
                            Key.Blank_1_And_A_Half_U,
                            Key.NumLock, Key.Divide, Key.Multiply, Key.Substract
                        }
                    },
                    new KeyboardRow
                    {
                        Row = KeyRow.R2,
                        Keys = new List<KeyModel>
                        {
                            Key.Tab, Key.Q, Key.W, Key.E, Key.R,
                            Key.T, Key.Y, Key.U, Key.I, Key.O, Key.P,
                            Key.OpenBracket, Key.CloseBracket, Key.Pipe,
                            Key.Blank_1_And_A_Half_U,
                            Key.Delete, Key.End, Key.PageDown,
                            Key.Blank_1_And_A_Half_U,
                            Key.Numpad7, Key.Numpad8, Key.Numpad9, Key.Add
                        }
                    },
                    new KeyboardRow
                    {
                        Row = KeyRow.R3,
                        Keys = new List<KeyModel>
                        {
                            Key.CapsLock, Key.A, Key.S, Key.D, Key.F,
                            Key.G, Key.H, Key.J, Key.K, Key.L, Key.Semicolon,
                            Key.Quote, Key.Enter,
                            Key.Blank_1_And_A_Half_U, Key.Blank_1U, Key.Blank_1U, Key.Blank_1U, 
                            Key.Blank_1_And_A_Half_U,
                            Key.Numpad4, Key.Numpad5, Key.Numpad6
                        }
                    },
                    new KeyboardRow
                    {
                        Row = KeyRow.R4,
                        Keys = new List<KeyModel>
                        {
                            Key.LShift, Key.Z, Key.X, Key.C, Key.V,
                            Key.B, Key.N, Key.M, Key.Comma, Key.Period, Key.Slash,
                            Key.RShift,
                            Key.Blank_1_And_A_Half_U, Key.Blank_1U,
                            Key.ArrowUp,
                            Key.Blank_1_And_A_Half_U, Key.Blank_1U,
                            Key.Numpad1, Key.Numpad2, Key.Numpad3, Key.NumpadEnter
                        }
                    },
                    new KeyboardRow
                    {
                        Row = KeyRow.R4,
                        Keys = new List<KeyModel>
                        {
                            Key.LControl, Key.LWindows, Key.LAlter, Key.Space, Key.RAlter,
                            Key.Menu, Key.RWindows, Key.RControl,
                            Key.Blank_1_And_A_Half_U,
                            Key.ArrowLeft, Key.ArrowDown, Key.ArrowRight,
                            Key.Blank_1_And_A_Half_U,
                            Key.Numpad0, Key.Decimal
                        }
                    }
                }
            };
        }

        public Keyboard TKL()
        {
            return new Keyboard
            {
                KeyboardLayout = KeyboardLayout.TKL,
                KeyboardRows = new List<KeyboardRow>
                {
                    new KeyboardRow
                    {
                        Row = KeyRow.R1F,
                        Keys = new List<KeyModel>
                        {
                            Key.ESC, Key.Blank_1U, Key.F1, Key.F2, Key.F3, Key.F4,
                            Key.Blank_1_And_A_Half_U, Key.F5, Key.F6, Key.F7, Key.F8,
                            Key.Blank_1_And_A_Half_U, Key.F9, Key.F10, Key.F11, Key.F12,
                            Key.Blank_1_And_A_Half_U,
                            Key.PrintScreen, Key.ScrollLock, Key.Pause
                        }
                    },
                    new KeyboardRow
                    {
                        Row = KeyRow.R1,
                        Keys = new List<KeyModel>
                        {
                            Key.Tilde, Key.D1, Key.D2, Key.D3, Key.D4,
                            Key.D5, Key.D6, Key.D7, Key.D8, Key.D9, Key.D0,
                            Key.Minus, Key.Plus, Key.Backspace,
                            Key.Blank_1_And_A_Half_U,
                            Key.Insert, Key.Home, Key.PageUp
                        }
                    },
                    new KeyboardRow
                    {
                        Row = KeyRow.R2,
                        Keys = new List<KeyModel>
                        {
                            Key.Tab, Key.Q, Key.W, Key.E, Key.R,
                            Key.T, Key.Y, Key.U, Key.I, Key.O, Key.P,
                            Key.OpenBracket, Key.CloseBracket, Key.Pipe,
                            Key.Blank_1_And_A_Half_U,
                            Key.Delete, Key.End, Key.PageDown
                        }
                    },
                    new KeyboardRow
                    {
                        Row = KeyRow.R3,
                        Keys = new List<KeyModel>
                        {
                            Key.CapsLock, Key.A, Key.S, Key.D, Key.F,
                            Key.G, Key.H, Key.J, Key.K, Key.L, Key.Semicolon,
                            Key.Quote, Key.Enter,
                            Key.Blank_1_And_A_Half_U, Key.Blank_1U, Key.Blank_1U, Key.Blank_1U
                        }
                    },
                    new KeyboardRow
                    {
                        Row = KeyRow.R4,
                        Keys = new List<KeyModel>
                        {
                            Key.LShift, Key.Z, Key.X, Key.C, Key.V,
                            Key.B, Key.N, Key.M, Key.Comma, Key.Period, Key.Slash,
                            Key.RShift,
                            Key.Blank_1_And_A_Half_U, Key.Blank_1U,
                            Key.ArrowUp
                        }
                    },
                    new KeyboardRow
                    {
                        Row = KeyRow.R4,
                        Keys = new List<KeyModel>
                        {
                            Key.LControl, Key.LWindows, Key.LAlter, Key.Space, Key.RAlter,
                            Key.Menu, Key.RWindows, Key.RControl,
                            Key.Blank_1_And_A_Half_U,
                            Key.ArrowLeft, Key.ArrowDown, Key.ArrowRight
                        }
                    }
                }
            };
        }
    }

    public class KeyboardRow
    {
        public KeyRow Row { get; set; }
        public List<KeyModel> Keys { get; set; }
    }
}
