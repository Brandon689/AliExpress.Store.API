using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class Price
    {
        [JsonPropertyName("decimal_point")]
        public string DecimalPoint { get; set; }

        [JsonPropertyName("comma_style")]
        public string CommaStyle { get; set; }

        [JsonPropertyName("symbol_position")]
        public string SymbolPosition { get; set; }
    }
}
