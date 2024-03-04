using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class CAINIAOFULFILLMENTSTD
    {
        [JsonPropertyName("expressionExt")]
        public string ExpressionExt { get; set; }

        [JsonPropertyName("allowBuyNowArouseLayer")]
        public bool? AllowBuyNowArouseLayer { get; set; }

        [JsonPropertyName("discountExt")]
        public string DiscountExt { get; set; }

        [JsonPropertyName("xdays")]
        public bool? Xdays { get; set; }

        [JsonPropertyName("choiceMindList")]
        public List<ChoiceMindList> ChoiceMindList { get; set; }

        [JsonPropertyName("promotionId")]
        public string PromotionId { get; set; }

        [JsonPropertyName("allowArouseLayer")]
        public bool? AllowArouseLayer { get; set; }

        [JsonPropertyName("shippingFeeText")]
        public string ShippingFeeText { get; set; }

        [JsonPropertyName("serviceDetails")]
        public ServiceDetails ServiceDetails { get; set; }
    }
}
