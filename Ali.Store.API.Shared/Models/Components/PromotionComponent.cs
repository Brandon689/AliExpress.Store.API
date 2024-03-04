using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class PromotionComponent
    {
        [JsonPropertyName("discountPromotion")]
        public bool? DiscountPromotion { get; set; }

        [JsonPropertyName("activity")]
        public bool? Activity { get; set; }

        [JsonPropertyName("fixedPromotionLeftHours")]
        public int? FixedPromotionLeftHours { get; set; }

        [JsonPropertyName("discount")]
        public int? Discount { get; set; }

        [JsonPropertyName("fixedFreeShipping")]
        public bool? FixedFreeShipping { get; set; }

        [JsonPropertyName("regularPriceActivity")]
        public bool? RegularPriceActivity { get; set; }

        [JsonPropertyName("fixedPromotionLeftSecs")]
        public int? FixedPromotionLeftSecs { get; set; }

        [JsonPropertyName("promotionLeftMinutes")]
        public int? PromotionLeftMinutes { get; set; }

        [JsonPropertyName("promotionLeftSecs")]
        public int? PromotionLeftSecs { get; set; }

        [JsonPropertyName("discountTips")]
        public string DiscountTips { get; set; }

        [JsonPropertyName("fixedPromotionLeftMinutes")]
        public int? FixedPromotionLeftMinutes { get; set; }

        [JsonPropertyName("coinsEnough")]
        public bool? CoinsEnough { get; set; }

        [JsonPropertyName("fireDeals")]
        public bool? FireDeals { get; set; }

        [JsonPropertyName("purchaseLimitMaxTips")]
        public string PurchaseLimitMaxTips { get; set; }

        [JsonPropertyName("superDeals")]
        public bool? SuperDeals { get; set; }

        [JsonPropertyName("fixedPromotionLeftDays")]
        public int? FixedPromotionLeftDays { get; set; }

        [JsonPropertyName("promotionLeftHours")]
        public int? PromotionLeftHours { get; set; }

        [JsonPropertyName("hbaFreeShipping")]
        public bool? HbaFreeShipping { get; set; }

        [JsonPropertyName("showStockPrompt")]
        public bool? ShowStockPrompt { get; set; }

        [JsonPropertyName("enableMultiDiscount")]
        public bool? EnableMultiDiscount { get; set; }

        [JsonPropertyName("purchaseLimitNumMax")]
        public int? PurchaseLimitNumMax { get; set; }

        [JsonPropertyName("discountRatioTips")]
        public string DiscountRatioTips { get; set; }

        [JsonPropertyName("displayIcon")]
        public bool? DisplayIcon { get; set; }

        [JsonPropertyName("preSale")]
        public bool? PreSale { get; set; }

        [JsonPropertyName("promotionLeftDays")]
        public int? PromotionLeftDays { get; set; }

        [JsonPropertyName("availableGroupShareActivity")]
        public bool? AvailableGroupShareActivity { get; set; }

        [JsonPropertyName("coinPreSale")]
        public bool? CoinPreSale { get; set; }

        [JsonPropertyName("fixedDiscountPromotion")]
        public bool? FixedDiscountPromotion { get; set; }

        [JsonPropertyName("comingSoon")]
        public bool? ComingSoon { get; set; }

        [JsonPropertyName("allProduct")]
        public bool? AllProduct { get; set; }

        [JsonPropertyName("memberPriceActivity")]
        public bool? MemberPriceActivity { get; set; }
    }
}
