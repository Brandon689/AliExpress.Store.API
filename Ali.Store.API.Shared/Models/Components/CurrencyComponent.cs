using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class CurrencyComponent
    {
        [JsonPropertyName("baseCurrencyCode")]
        public string BaseCurrencyCode { get; set; }

        [JsonPropertyName("enableTransaction")]
        public bool? EnableTransaction { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("symbolFront")]
        public bool? SymbolFront { get; set; }

        [JsonPropertyName("currencyRate")]
        public double? CurrencyRate { get; set; }

        [JsonPropertyName("baseSymbolFront")]
        public bool? BaseSymbolFront { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("baseCurrencySymbol")]
        public string BaseCurrencySymbol { get; set; }

        [JsonPropertyName("multiCurrency")]
        public bool? MultiCurrency { get; set; }
    }
}
