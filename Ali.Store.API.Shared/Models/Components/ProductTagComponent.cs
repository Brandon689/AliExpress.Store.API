using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class ProductTagComponent
    {
        [JsonPropertyName("topItem")]
        public bool? TopItem { get; set; }

        [JsonPropertyName("invalidBuyNow")]
        public bool? InvalidBuyNow { get; set; }

        [JsonPropertyName("switchInfo")]
        public SwitchInfo SwitchInfo { get; set; }

        [JsonPropertyName("rechargeProduct")]
        public bool? RechargeProduct { get; set; }

        [JsonPropertyName("x3MoneyBack")]
        public bool? X3MoneyBack { get; set; }

        [JsonPropertyName("f1Scene")]
        public bool? F1Scene { get; set; }

        [JsonPropertyName("hideMessage")]
        public bool? HideMessage { get; set; }

        [JsonPropertyName("otherPCTagMap")]
        public OtherPCTagMap OtherPCTagMap { get; set; }

        [JsonPropertyName("boutique")]
        public bool? Boutique { get; set; }

        [JsonPropertyName("hideBuyNow")]
        public bool? HideBuyNow { get; set; }

        [JsonPropertyName("promotionEnhanceInfoBanner")]
        public PromotionEnhanceInfoBanner PromotionEnhanceInfoBanner { get; set; }

        [JsonPropertyName("madeInItaly")]
        public bool? MadeInItaly { get; set; }

        [JsonPropertyName("installment")]
        public bool? Installment { get; set; }

        [JsonPropertyName("ruHidePruduct")]
        public bool? RuHidePruduct { get; set; }

        [JsonPropertyName("frMall")]
        public bool? FrMall { get; set; }

        [JsonPropertyName("choiceProduct")]
        public bool? ChoiceProduct { get; set; }
    }
}
