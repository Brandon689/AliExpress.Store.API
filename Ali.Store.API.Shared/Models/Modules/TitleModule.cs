using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class TitleModule
    {
        [JsonPropertyName("REVIEWS")]
        public string REVIEWS { get; set; }

        [JsonPropertyName("VIEW_ALL_REVIEWS")]
        public string VIEWALLREVIEWS { get; set; }

        [JsonPropertyName("REVIEW")]
        public string REVIEW { get; set; }

        [JsonPropertyName("VIEW_OTHER_TITLE")]
        public string VIEWOTHERTITLE { get; set; }

        [JsonPropertyName("VIEW_EN_TITLE")]
        public string VIEWENTITLE { get; set; }

        [JsonPropertyName("FREEBIE_REVIEW")]
        public string FREEBIEREVIEW { get; set; }

        [JsonPropertyName("FREEBIE_REVIEWS")]
        public string FREEBIEREVIEWS { get; set; }
    }
}
