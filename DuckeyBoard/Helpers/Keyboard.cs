namespace DuckeyBoard.Helpers
{
    public class Keyboard
    {
        public List<KeyboardKey> KeyboardKeys { get; set; }

        public Keyboard()
        {
            // KeyboardKeys = GenerateKeys();
        }

        /*public List<KeyboardKey> GenerateKeys()
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
                IndexInRow = 1.75F
            });
            result.Add(new()
            {
                Title = "F2",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 2.75F
            });
            result.Add(new()
            {
                Title = "F3",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 3.75F
            });
            result.Add(new()
            {
                Title = "F4",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 4.75F
            });
            result.Add(new()
            {
                Title = "F5",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 6F
            });
            result.Add(new()
            {
                Title = "F6",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 7
            });
            result.Add(new()
            {
                Title = "F7",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 8
            });
            result.Add(new()
            {
                Title = "F8",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 9
            });
            result.Add(new()
            {
                Title = "F9",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 10.75F
            });
            result.Add(new()
            {
                Title = "F10",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 11.75F
            });
            result.Add(new()
            {
                Title = "F11",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 12.75F
            });
            result.Add(new()
            {
                Title = "12",
                ExtraTitle = "",
                Unit = 1,
                Row = KeyboardRow.R1F,
                RowIndex = 0,
                IndexInRow = 13.75F
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
                IndexInRow = 1
            });
            result.Add(new()
            {
                Title = "2",
                ExtraTitle = "@",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 2
            });
            result.Add(new()
            {
                Title = "3",
                ExtraTitle = "#",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 3
            });
            result.Add(new()
            {
                Title = "4",
                ExtraTitle = "$",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 4
            });
            result.Add(new()
            {
                Title = "5",
                ExtraTitle = "%",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 5
            });
            result.Add(new()
            {
                Title = "6",
                ExtraTitle = "^",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 6
            });
            result.Add(new()
            {
                Title = "7",
                ExtraTitle = "&",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 7
            });
            result.Add(new()
            {
                Title = "8",
                ExtraTitle = "*",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 8
            });
            result.Add(new()
            {
                Title = "9",
                ExtraTitle = "(",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 9
            });
            result.Add(new()
            {
                Title = "0",
                ExtraTitle = ")",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 10
            });
            result.Add(new()
            {
                Title = "-",
                ExtraTitle = "_",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 11
            });
            result.Add(new()
            {
                Title = "=",
                ExtraTitle = "+",
                Unit = 1,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 12
            });
            result.Add(new()
            {
                Title = "backspace",
                ExtraTitle = "",
                Unit = 2,
                Row = KeyboardRow.R1,
                RowIndex = 1,
                IndexInRow = 13
            });
            #endregion

            return result;
        }*/
    }
}
