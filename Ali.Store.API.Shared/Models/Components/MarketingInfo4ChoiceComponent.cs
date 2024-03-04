using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class MarketingInfo4ChoiceComponent
    {
        [JsonPropertyName("bgColorStart")]
        public string BgColorStart { get; set; }

        [JsonPropertyName("bgColorEnd")]
        public string BgColorEnd { get; set; }

        [JsonPropertyName("blockIcon")]
        public BlockIcon BlockIcon { get; set; }
    }
}
