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
        public float Unit { get; set; }
        [JsonPropertyName("row")]
        public KeyRow Row { get; set; }
        [JsonPropertyName("rowIndex")]
        public int RowIndex { get; set; }
        [JsonPropertyName("indexInRow")]
        public float IndexInRow { get; set; }
        [JsonPropertyName("winKey")]
        public Keys? WinKey { get; set; }
        [JsonPropertyName("isBlank")]
        public bool IsBlank { get; set; } = false;

        // dev always counts from zero, so `index` starts from 0 :D
    }
}
