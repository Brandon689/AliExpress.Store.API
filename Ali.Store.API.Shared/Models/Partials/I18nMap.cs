using Ali.Store.API.Models.Modules;
using Ali.Store.API.Models.Partial;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class I18nMap
    {
        [JsonPropertyName("SKUModule")]
        public SKUModule SKUModule { get; set; }

        [JsonPropertyName("priceGuarantee")]
        public PriceGuarantee PriceGuarantee { get; set; }

        [JsonPropertyName("ActionModule")]
        public ActionModule ActionModule { get; set; }

        [JsonPropertyName("StoreModule")]
        public StoreModule StoreModule { get; set; }

        [JsonPropertyName("RecommendModule")]
        public RecommendModule RecommendModule { get; set; }

        [JsonPropertyName("StoreInfo")]
        public StoreInfo StoreInfo { get; set; }

        [JsonPropertyName("ItemDetailResp")]
        public ItemDetailResp ItemDetailResp { get; set; }

        [JsonPropertyName("bpFreeReturn30")]
        public BpFreeReturn30 BpFreeReturn30 { get; set; }

        [JsonPropertyName("bpLocalDomesticReturn")]
        public BpLocalDomesticReturn BpLocalDomesticReturn { get; set; }

        [JsonPropertyName("PriceModule")]
        public PriceModule PriceModule { get; set; }

        [JsonPropertyName("ShippingModule")]
        public ShippingModule ShippingModule { get; set; }

        [JsonPropertyName("BuyerProtectionModule")]
        public BuyerProtectionModule BuyerProtectionModule { get; set; }

        [JsonPropertyName("bpSpainFreeReturn")]
        public BpSpainFreeReturn BpSpainFreeReturn { get; set; }

        [JsonPropertyName("Common")]
        public Common Common { get; set; }

        [JsonPropertyName("buyerProtection")]
        public BuyerProtection BuyerProtection { get; set; }

        [JsonPropertyName("QuantityModule")]
        public QuantityModule QuantityModule { get; set; }

        [JsonPropertyName("OtherServiceModule")]
        public OtherServiceModule OtherServiceModule { get; set; }

        [JsonPropertyName("CrossLinkModule")]
        public CrossLinkModule CrossLinkModule { get; set; }

        [JsonPropertyName("bpLocalReturn15")]
        public BpLocalReturn15 BpLocalReturn15 { get; set; }

        [JsonPropertyName("TitleModule")]
        public TitleModule TitleModule { get; set; }

        [JsonPropertyName("MiddleBannerModule")]
        public MiddleBannerModule MiddleBannerModule { get; set; }

        [JsonPropertyName("CouponModule")]
        public CouponModule CouponModule { get; set; }

        [JsonPropertyName("bpDomesticReturn7")]
        public BpDomesticReturn7 BpDomesticReturn7 { get; set; }
    }
}
