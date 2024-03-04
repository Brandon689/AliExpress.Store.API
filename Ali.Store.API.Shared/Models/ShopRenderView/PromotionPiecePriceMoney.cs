using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class PromotionPiecePriceMoney
    {
        [JsonPropertyName("amount")]
        public double? Amount { get; set; }

        [JsonPropertyName("cent")]
        public int? Cent { get; set; }

        [JsonPropertyName("centFactor")]
        public int? CentFactor { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}
