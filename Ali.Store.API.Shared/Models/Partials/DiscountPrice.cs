using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class DiscountPrice
    {
        [JsonPropertyName("actMinPrice")]
        public double? ActMinPrice { get; set; }

        [JsonPropertyName("actCurrencyFormatPrice")]
        public string ActCurrencyFormatPrice { get; set; }

        [JsonPropertyName("minActivityAmount")]
        public MinActivityAmount MinActivityAmount { get; set; }

        [JsonPropertyName("actMultiCurrencyMinPrice")]
        public string ActMultiCurrencyMinPrice { get; set; }

        [JsonPropertyName("minActMultiCurrencyPrice")]
        public double? MinActMultiCurrencyPrice { get; set; }

        [JsonPropertyName("maxActMultiCurrencyPrice")]
        public double? MaxActMultiCurrencyPrice { get; set; }

        [JsonPropertyName("maxActivityAmount")]
        public MaxActivityAmount MaxActivityAmount { get; set; }

        [JsonPropertyName("actMinDisplayPrice")]
        public string ActMinDisplayPrice { get; set; }

        [JsonPropertyName("actMaxDisplayPrice")]
        public string ActMaxDisplayPrice { get; set; }

        [JsonPropertyName("actMaxPrice")]
        public double? ActMaxPrice { get; set; }

        [JsonPropertyName("actMultiCurrencyDisplayPrice")]
        public string ActMultiCurrencyDisplayPrice { get; set; }

        [JsonPropertyName("actMultiCurrencyMaxPrice")]
        public string ActMultiCurrencyMaxPrice { get; set; }
    }
}
