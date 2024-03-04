using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class PromotionBannerInfo
    {
        [JsonPropertyName("endTimer")]
        public EndTimer EndTimer { get; set; }

        [JsonPropertyName("priceAreaColor")]
        public string PriceAreaColor { get; set; }

        [JsonPropertyName("atmosphereCode")]
        public string AtmosphereCode { get; set; }

        [JsonPropertyName("supplementaryList")]
        public List<SupplementaryList> SupplementaryList { get; set; }

        [JsonPropertyName("background")]
        public Background Background { get; set; }

        [JsonPropertyName("activityStatus")]
        public int? ActivityStatus { get; set; }

        [JsonPropertyName("separator")]
        public Separator Separator { get; set; }

        [JsonPropertyName("slogan")]
        public Slogan Slogan { get; set; }
    }
}
