using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class BannerComponent
    {
        [JsonPropertyName("promotionBannerInfo")]
        public PromotionBannerInfo PromotionBannerInfo { get; set; }

        [JsonPropertyName("bannerType")]
        public string BannerType { get; set; }
    }
}
