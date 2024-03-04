using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class WebCouponInfoComponent
    {
        [JsonPropertyName("usingNewCouponApi")]
        public bool? UsingNewCouponApi { get; set; }

        [JsonPropertyName("couponList")]
        public List<object> CouponList { get; set; }

        [JsonPropertyName("promotionPanelDTO")]
        public PromotionPanelDTO PromotionPanelDTO { get; set; }

        [JsonPropertyName("couponAttributes")]
        public CouponAttributes CouponAttributes { get; set; }
    }
}
