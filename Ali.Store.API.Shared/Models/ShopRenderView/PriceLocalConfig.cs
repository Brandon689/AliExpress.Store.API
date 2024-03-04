using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class PriceLocalConfig
    {
        [JsonPropertyName("single")]
        public Single Single { get; set; }

        [JsonPropertyName("separatorStr")]
        public string SeparatorStr { get; set; }

        [JsonPropertyName("from")]
        public From From { get; set; }

        [JsonPropertyName("to")]
        public To To { get; set; }

        [JsonPropertyName("useful")]
        public bool? Useful { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
