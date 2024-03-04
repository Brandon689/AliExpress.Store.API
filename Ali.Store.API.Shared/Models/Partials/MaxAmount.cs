using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class MaxAmount
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("formatedAmount")]
        public string FormatedAmount { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }
}
