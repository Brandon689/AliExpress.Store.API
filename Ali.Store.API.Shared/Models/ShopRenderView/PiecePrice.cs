using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class PiecePrice
    {
        [JsonPropertyName("amount")]
        public double? Amount { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}
