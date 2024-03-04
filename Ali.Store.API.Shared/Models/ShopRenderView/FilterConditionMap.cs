using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class FilterConditionMap
    {
        [JsonPropertyName("Free shipping")]
        public string FreeShipping { get; set; }

        [JsonPropertyName("New Arrivals")]
        public string NewArrivals { get; set; }

        [JsonPropertyName("Top Selling")]
        public string TopSelling { get; set; }

        [JsonPropertyName("Sale Items")]
        public string SaleItems { get; set; }
    }
}
