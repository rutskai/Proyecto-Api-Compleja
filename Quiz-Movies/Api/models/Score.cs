using System.Text.Json.Serialization;

namespace Models
{
    public class Score
    {
        public int? Points { get; set; }
        public string Message {get; set; } = "";
        
        [JsonPropertyName("Date")]
        public string DateString => Date.ToString("yyyy-MM-dd");

        [JsonIgnore]
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
