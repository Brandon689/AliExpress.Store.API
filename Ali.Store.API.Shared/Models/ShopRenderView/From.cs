using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class From
    {
        [JsonPropertyName("thousandsChar")]
        public string ThousandsChar { get; set; }

        [JsonPropertyName("decimalPointChar")]
        public string DecimalPointChar { get; set; }

        [JsonPropertyName("currencySymbolPosition")]
        public string CurrencySymbolPosition { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("showDecimal")]
        public bool? ShowDecimal { get; set; }
    }
}
