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
            result.Add(new ()
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


            return result;
        }
    }
}
