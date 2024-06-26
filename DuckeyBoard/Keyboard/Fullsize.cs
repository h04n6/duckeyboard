namespace DuckeyBoard.Helpers
{
    public class Fullsize
    {
        public List<Key> KeyboardKeys { get; set; }

        public Fullsize()
        {
            KeyboardKeys = GenerateKeys();
        }

        public List<Key> GenerateKeys()
        {
            List<Key> result = new List<Key>();

            #region R1F
            result.Add(new()
            {
                Title = "ESC",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 0,
                WinKey = Keys.Escape
            });
            result.Add(new()
            {
                Title = "F1",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 1.75F,
                WinKey = Keys.F1
            });
            result.Add(new()
            {
                Title = "F2",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 2.75F,
                WinKey = Keys.F2
            });
            result.Add(new()
            {
                Title = "F3",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 3.75F,
                WinKey = Keys.F3
            });
            result.Add(new()
            {
                Title = "F4",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 4.75F,
                WinKey = Keys.F4
            });
            result.Add(new()
            {
                Title = "F5",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 6F,
                WinKey = Keys.F5
            });
            result.Add(new()
            {
                Title = "F6",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 7,
                WinKey = Keys.F6
            });
            result.Add(new()
            {
                Title = "F7",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 8,
                WinKey = Keys.F7
            });
            result.Add(new()
            {
                Title = "F8",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 9,
                WinKey = Keys.F8
            });
            result.Add(new()
            {
                Title = "F9",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 10.75F,
                WinKey = Keys.F9
            });
            result.Add(new()
            {
                Title = "F10",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 11.75F,
                WinKey = Keys.F10
            });
            result.Add(new()
            {
                Title = "F11",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 12.75F,
                WinKey = Keys.F11
            });
            result.Add(new()
            {
                Title = "12",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyRow.R1F,
                RowIndex = 0,
                IndexInRow = 13.75F,
                WinKey = Keys.F12
            });
            #endregion

            #region R1
            result.Add(new()
            {
                Title = "`",
                ExtraTitle = "~",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "1",
                ExtraTitle = "!",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 1
            });
            result.Add(new()
            {
                Title = "2",
                ExtraTitle = "@",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 2
            });
            result.Add(new()
            {
                Title = "3",
                ExtraTitle = "#",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 3
            });
            result.Add(new()
            {
                Title = "4",
                ExtraTitle = "$",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 4
            });
            result.Add(new()
            {
                Title = "5",
                ExtraTitle = "%",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 5
            });
            result.Add(new()
            {
                Title = "6",
                ExtraTitle = "^",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 6
            });
            result.Add(new()
            {
                Title = "7",
                ExtraTitle = "&",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 7
            });
            result.Add(new()
            {
                Title = "8",
                ExtraTitle = "*",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 8
            });
            result.Add(new()
            {
                Title = "9",
                ExtraTitle = "(",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 9
            });
            result.Add(new()
            {
                Title = "0",
                ExtraTitle = ")",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 10
            });
            result.Add(new()
            {
                Title = "-",
                ExtraTitle = "_",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 11
            });
            result.Add(new()
            {
                Title = "=",
                ExtraTitle = "+",
                Unit = 1,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 12
            });
            result.Add(new()
            {
                Title = "backspace",
                ExtraTitle = "",
                Unit = 2,
                Row = KeyRow.R1,
                RowIndex = 1,
                IndexInRow = 13
            });
            #endregion

            return result;
        }
    }
}
