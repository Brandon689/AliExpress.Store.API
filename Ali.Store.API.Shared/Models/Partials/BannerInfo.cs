using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class BannerInfo
    {
        [JsonPropertyName("promotionBanner")]
        public PromotionBanner PromotionBanner { get; set; }
    }
}
