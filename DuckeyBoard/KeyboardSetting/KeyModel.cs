using System.Text.Json.Serialization;

namespace DuckeyBoard.KeyboardSetting
{
    public class KeyModel
    {
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("extraTitle")]
        public string ExtraTitle { get; set; }
        [JsonPropertyName("unit")]
        public float HorizontalUnit { get; set; } = 1;
        [JsonPropertyName("verticalUnit")]
        public float VerticalUnit { get; set; } = 1;
        [JsonPropertyName("winKey")]
        public Keys? WinKey { get; set; }
        [JsonPropertyName("type")]
        public KeyType Type { get; set; } = KeyType.NORMAL;
        [JsonPropertyName("direction")]
        public KeyDirection Direction { get; set; } = KeyDirection.HORIZONTAL;

        // dev always counts from zero, so `index` starts from 0 :D
    }
}
