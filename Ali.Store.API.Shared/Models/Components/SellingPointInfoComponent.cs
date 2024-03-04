using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class SellingPointInfoComponent
    {
        [JsonPropertyName("viewMoreText")]
        public string ViewMoreText { get; set; }

        [JsonPropertyName("limitCnt")]
        public int? LimitCnt { get; set; }

        [JsonPropertyName("viewLessText")]
        public string ViewLessText { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
