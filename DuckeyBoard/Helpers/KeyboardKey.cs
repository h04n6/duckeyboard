using System.Text.Json.Serialization;

namespace DuckeyBoard.Helpers
{
    public class KeyboardKey
    {
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("extraTitle")]
        public string ExtraTitle { get; set; }
        [JsonPropertyName("unit")]
        public int Unit { get; set; }
        [JsonPropertyName("row")]
        public string Row { get; set; }
        [JsonPropertyName("rowIndex")]
        public int RowIndex { get; set; }
        [JsonPropertyName("indexInRow")]
        public float IndexInRow { get; set; }

        // dev always counts from zero, so `index` starts from 0 :D
    }
}
