using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class Common
    {
        [JsonPropertyName("recommendationsFrom")]
        public string RecommendationsFrom { get; set; }

        [JsonPropertyName("sharePc")]
        public string SharePc { get; set; }

        [JsonPropertyName("skuEditSelection")]
        public string SkuEditSelection { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("specification")]
        public string Specification { get; set; }

        [JsonPropertyName("skuSelections")]
        public string SkuSelections { get; set; }

        [JsonPropertyName("feedback")]
        public string Feedback { get; set; }

        [JsonPropertyName("youMayAlsoLike")]
        public string YouMayAlsoLike { get; set; }

        [JsonPropertyName("deliveryBlockTitle")]
        public string DeliveryBlockTitle { get; set; }

        [JsonPropertyName("outOfStock")]
        public string OutOfStock { get; set; }

        [JsonPropertyName("topSellingsFrom")]
        public string TopSellingsFrom { get; set; }

        [JsonPropertyName("similarRecommond")]
        public string SimilarRecommond { get; set; }

        [JsonPropertyName("youMayAlsoLikeSeeMore")]
        public string YouMayAlsoLikeSeeMore { get; set; }

        [JsonPropertyName("qanda")]
        public string Qanda { get; set; }
    }
}
