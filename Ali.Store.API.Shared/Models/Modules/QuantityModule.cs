using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class QuantityModule
    {
        [JsonPropertyName("LOT")]
        public string LOT { get; set; }

        [JsonPropertyName("LOTS")]
        public string LOTS { get; set; }

        [JsonPropertyName("BUY_LIMIT")]
        public string BUYLIMIT { get; set; }

        [JsonPropertyName("QUANTITY")]
        public string QUANTITY { get; set; }

        [JsonPropertyName("OFF_OR_MORE")]
        public string OFFORMORE { get; set; }

        [JsonPropertyName("ONLY_QUANTITY_LEFT")]
        public string ONLYQUANTITYLEFT { get; set; }

        [JsonPropertyName("ADDTIONAL")]
        public string ADDTIONAL { get; set; }

        [JsonPropertyName("QUANTITY_AVAILABLE")]
        public string QUANTITYAVAILABLE { get; set; }
    }
}
