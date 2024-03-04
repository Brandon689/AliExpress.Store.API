using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class Detail
    {
        [JsonPropertyName("viewMoreText")]
        public string ViewMoreText { get; set; }

        [JsonPropertyName("titleColor")]
        public string TitleColor { get; set; }

        [JsonPropertyName("actionTarget")]
        public string ActionTarget { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }
}
