using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class BuyNowBtn
    {
        [JsonPropertyName("bgColorStart")]
        public string BgColorStart { get; set; }

        [JsonPropertyName("bgColorEnd")]
        public string BgColorEnd { get; set; }

        [JsonPropertyName("textContent")]
        public string TextContent { get; set; }

        [JsonPropertyName("textColor")]
        public string TextColor { get; set; }
    }
}
