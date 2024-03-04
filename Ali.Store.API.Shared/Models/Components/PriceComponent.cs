using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class PriceComponent
    {
        [JsonPropertyName("skuJson")]
        public string SkuJson { get; set; }

        [JsonPropertyName("vatDesc")]
        public string VatDesc { get; set; }

        [JsonPropertyName("displayBulkInfo")]
        public bool? DisplayBulkInfo { get; set; }

        [JsonPropertyName("skuPriceList")]
        public List<SkuPriceList> SkuPriceList { get; set; }

        [JsonPropertyName("discountPrice")]
        public DiscountPrice DiscountPrice { get; set; }

        [JsonPropertyName("origPrice")]
        public OrigPrice OrigPrice { get; set; }

        [JsonPropertyName("priceLocalConfig")]
        public string PriceLocalConfig { get; set; }
    }
}
