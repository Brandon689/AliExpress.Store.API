using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class RecommendModule
    {
        [JsonPropertyName("MORE_FROM_THIS_SELLER")]
        public string MOREFROMTHISSELLER { get; set; }

        [JsonPropertyName("YOU_MAY_LIKE")]
        public string YOUMAYLIKE { get; set; }

        [JsonPropertyName("TOP_SELLING")]
        public string TOPSELLING { get; set; }

        [JsonPropertyName("FROM_OTHER_SELLER")]
        public string FROMOTHERSELLER { get; set; }

        [JsonPropertyName("VIEW_MORE_LINK")]
        public string VIEWMORELINK { get; set; }

        [JsonPropertyName("PRODUCT_SOLD")]
        public string PRODUCTSOLD { get; set; }
    }
}
