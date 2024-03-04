using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class RecommendComponent
    {
        [JsonPropertyName("similarPageSize")]
        public int? SimilarPageSize { get; set; }

        [JsonPropertyName("afChannel")]
        public string AfChannel { get; set; }

        [JsonPropertyName("similarScenario")]
        public string SimilarScenario { get; set; }

        [JsonPropertyName("hideStoreRecommend")]
        public bool? HideStoreRecommend { get; set; }

        [JsonPropertyName("hideTopSelling")]
        public bool? HideTopSelling { get; set; }
    }
}
