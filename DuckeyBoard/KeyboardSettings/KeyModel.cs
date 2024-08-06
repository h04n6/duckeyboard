using DuckeyBoard.TrackSettings;
using System.Text.Json.Serialization;

namespace DuckeyBoard.KeyboardSettings
{
    public class KeyModel
    {
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("extraTitle")]
        public string ExtraTitle { get; set; }
        [JsonIgnore]
        [JsonPropertyName("unit")]
        public float HorizontalUnit { get; set; } = 1;
        [JsonIgnore]
        [JsonPropertyName("verticalUnit")]
        public float VerticalUnit { get; set; } = 1;
        [JsonIgnore]
        [JsonPropertyName("winKey")]
        public Keys? WinKey { get; set; }
        [JsonIgnore]
        [JsonPropertyName("type")]
        public KeyType Type { get; set; } = KeyType.NORMAL;
        [JsonIgnore]
        [JsonPropertyName("direction")]
        public KeyDirection Direction { get; set; } = KeyDirection.HORIZONTAL;
        public TrackModel Track { get; set; }
    }
}
