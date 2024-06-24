namespace DuckeyBoard.Helpers
{
    public class Keyboard
    {
        public List<KeyboardKey> KeyboardKeys { get; set; }

        public Keyboard()
        {
            KeyboardKeys = GenerateKeys();
        }

        public List<KeyboardKey> GenerateKeys()
        {
            List<KeyboardKey> result = new List<KeyboardKey>();

            #region R1F
            result.Add(new()
            {
                Title = "ESC",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "F1",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "F2",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "F3",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "F4",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "F5",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "F6",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "F7",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "F8",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "F9",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "F10",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "F11",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "12",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 0
            });
            #endregion

            #region R1
            result.Add(new()
            {
                Title = "`",
                ExtraTitle = "~",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "1",
                ExtraTitle = "!",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "2",
                ExtraTitle = "@",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "3",
                ExtraTitle = "#",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "4",
                ExtraTitle = "$",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "5",
                ExtraTitle = "%",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "6",
                ExtraTitle = "^",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "7",
                ExtraTitle = "&",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "8",
                ExtraTitle = "*",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "9",
                ExtraTitle = "(",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "0",
                ExtraTitle = ")",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "-",
                ExtraTitle = "_",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "=",
                ExtraTitle = "+",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "backspace",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 0
            });
            #endregion

            return result;
        }
    }
}
