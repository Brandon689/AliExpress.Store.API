using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class Material
    {
        [JsonPropertyName("materialCode")]
        public string MaterialCode { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
