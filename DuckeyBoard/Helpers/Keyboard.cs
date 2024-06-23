using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                IndexInRow = 0
            });
            result.Add(new()
            {
                Title = "1",
                ExtraTitle = "!",
                Unit = 1,
                Row = KeyboardRow.R1,
                IndexInRow = 1
            });
            result.Add(new()
            {
                Title = "2",
                ExtraTitle = "@",
                Unit = 1,
                Row = KeyboardRow.R1,
                IndexInRow = 2
            });


            return result;
        }
    }
}
