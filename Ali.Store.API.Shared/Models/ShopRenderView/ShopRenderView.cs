using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class ShopRenderView
    {
        [JsonPropertyName("api")]
        public string Api { get; set; }

        [JsonPropertyName("data")]
        public DataContainer Baka { get; set; }

        [JsonPropertyName("ret")]
        public List<string> Ret { get; set; }

        [JsonPropertyName("v")]
        public string V { get; set; }
    }
}
