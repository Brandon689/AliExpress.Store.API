using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class ChoiceMindList
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class DeliveryExtraInfoMap
    {
        [JsonPropertyName("CAINIAO_FULFILLMENT_STD")]
        public CAINIAOFULFILLMENTSTD CAINIAOFULFILLMENTSTD { get; set; }
    }

    public class Description
    {
        [JsonPropertyName("spreadStatus")]
        public string SpreadStatus { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }

    public class DxTemplateInfo
    {
    }

    public class GagaComponent
    {
        [JsonPropertyName("gagaDataSite")]
        public string GagaDataSite { get; set; }
    }

    public class Group
    {
        [JsonPropertyName("isExpand")]
        public string IsExpand { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class I18nComponent
    {
        [JsonPropertyName("i18nMap")]
        public I18nMap I18nMap { get; set; }
    }

    public class InstallmentComponent
    {
    }

    public class InventoryComponent
    {
        [JsonPropertyName("totalQuantity")]
        public int? TotalQuantity { get; set; }

        [JsonPropertyName("totalAvailQuantity")]
        public int? TotalAvailQuantity { get; set; }
    }

    public class ItemStatusComponent
    {
        [JsonPropertyName("status")]
        public int? Status { get; set; }
    }

    public class LogisticsBlockIcon
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class MarketingInfoComponent
    {
    }

    public class OtherPCTagMap
    {
    }

    public class PageSizeComponent
    {
        [JsonPropertyName("hasNewSizeInfo")]
        public bool? HasNewSizeInfo { get; set; }

        [JsonPropertyName("hasSizeInfo")]
        public bool? HasSizeInfo { get; set; }
    }

    public class PriceRuleComponent
    {
    }

    public class ProductGroupsResult
    {
        [JsonPropertyName("groups")]
        public List<Group> Groups { get; set; }
    }

    public class PromotionEnhanceInfoBanner
    {
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }
    }

    public class PromotionPanelDTO
    {
    }

    public class QuestionAndAnswer
    {
        [JsonPropertyName("spreadStatus")]
        public string SpreadStatus { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }

    public class RedirectComponent
    {
    }

    public class ReferComponent
    {
    }

    public class RemindsComponent
    {
        [JsonPropertyName("reminds")]
        public List<object> Reminds { get; set; }
    }

    public class Review
    {
        [JsonPropertyName("spreadStatus")]
        public string SpreadStatus { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }

    public class SellerGuaranteeComponent
    {
        [JsonPropertyName("hasOverseaWarehouse")]
        public bool? HasOverseaWarehouse { get; set; }

        [JsonPropertyName("warranyDetailJson")]
        public string WarranyDetailJson { get; set; }

        [JsonPropertyName("forcePromiseWarrantyJson")]
        public string ForcePromiseWarrantyJson { get; set; }
    }

    public class Separator
    {
        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class ServiceBlockIcon
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class ServiceDetails
    {
        [JsonPropertyName("more")]
        public bool? More { get; set; }

        [JsonPropertyName("details")]
        public List<Detail> Details { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    public class ShopCategoryComponent
    {
        [JsonPropertyName("productGroupsResult")]
        public ProductGroupsResult ProductGroupsResult { get; set; }
    }

    public class SiteInfoComponent
    {
        [JsonPropertyName("wholesaleSubServer")]
        public string WholesaleSubServer { get; set; }

        [JsonPropertyName("crawler")]
        public bool? Crawler { get; set; }

        [JsonPropertyName("siteType")]
        public string SiteType { get; set; }
    }

    public class SkuActivityAmount
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("formatedAmount")]
        public string FormatedAmount { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class SkuAmount
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("formatedAmount")]
        public string FormatedAmount { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class Slogan
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class Specification
    {
        [JsonPropertyName("spreadStatus")]
        public string SpreadStatus { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }

    public class StoreHeaderComponent
    {
        [JsonPropertyName("storeHeaderResult")]
        public StoreHeaderResult StoreHeaderResult { get; set; }
    }

    public class StoreHeaderResult
    {
        [JsonPropertyName("shopTagUrl")]
        public string ShopTagUrl { get; set; }
    }

    public class StoreMultilanguageUrlList
    {
        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("languageUrl")]
        public string LanguageUrl { get; set; }
    }

    public class SupplementaryList
    {
        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class SupplementInfoLayoutComponent
    {
        [JsonPropertyName("moduleLayoutInfo")]
        public ModuleLayoutInfo ModuleLayoutInfo { get; set; }
    }

    public class TradeComponent
    {
        [JsonPropertyName("formatTradeCount")]
        public string FormatTradeCount { get; set; }

        [JsonPropertyName("tradeCountUnit")]
        public string TradeCountUnit { get; set; }
    }

    public class UiTestInfo
    {
    }

    public class UserComponent
    {
        [JsonPropertyName("currentTime")]
        public long? CurrentTime { get; set; }

        [JsonPropertyName("regionCountryName")]
        public string RegionCountryName { get; set; }

        [JsonPropertyName("userCountryName")]
        public string UserCountryName { get; set; }

        [JsonPropertyName("userCountryCode")]
        public string UserCountryCode { get; set; }
    }

    public class VehicleComponent
    {
    }

    public class Warranty
    {
    }

    public class WarranyDetailMap
    {
    }

    public class WebCouponPriceComponent
    {
    }
}
