namespace DuckeyBoard.Helpers
{
    public class KeyboardKey
    {
        public string Code { get; set; } = string.Empty;
        public string Title { get; set; }
        public string ExtraTitle { get; set; }
        public int Unit { get; set; }
        public KeyboardRow Row { get; set; }
        public int IndexInRow { get; set; }
    }
}
