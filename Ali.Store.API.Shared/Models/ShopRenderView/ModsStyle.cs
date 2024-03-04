using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class ModsStyle
    {
        [JsonPropertyName("price")]
        public Price Price { get; set; }
    }
}
