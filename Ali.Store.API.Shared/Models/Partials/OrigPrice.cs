using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class OrigPrice
    {
        [JsonPropertyName("minAmount")]
        public MinAmount MinAmount { get; set; }

        [JsonPropertyName("minMultiCurrencyPrice")]
        public double? MinMultiCurrencyPrice { get; set; }

        [JsonPropertyName("minPrice")]
        public double? MinPrice { get; set; }

        [JsonPropertyName("maxPrice")]
        public double? MaxPrice { get; set; }

        [JsonPropertyName("multiCurrencyFormatPrice")]
        public string MultiCurrencyFormatPrice { get; set; }

        [JsonPropertyName("maxAmount")]
        public MaxAmount MaxAmount { get; set; }

        [JsonPropertyName("currencyFormatPrice")]
        public string CurrencyFormatPrice { get; set; }
    }
}
