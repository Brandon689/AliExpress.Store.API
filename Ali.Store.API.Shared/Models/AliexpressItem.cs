using Ali.Store.API.Models.Components;
using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class AliexpressItem
    {
        [JsonPropertyName("tradeComponent")]
        public TradeComponent TradeComponent { get; set; }

        [JsonPropertyName("pageSizeComponent")]
        public PageSizeComponent PageSizeComponent { get; set; }

        [JsonPropertyName("redirectComponent")]
        public RedirectComponent RedirectComponent { get; set; }

        [JsonPropertyName("metaDataComponent")]
        public MetaDataComponent MetaDataComponent { get; set; }

        [JsonPropertyName("sellerComponent")]
        public SellerComponent SellerComponent { get; set; }

        [JsonPropertyName("plazaSellerServiceComponent")]
        public PlazaSellerServiceComponent PlazaSellerServiceComponent { get; set; }

        [JsonPropertyName("productPropComponent")]
        public ProductPropComponent ProductPropComponent { get; set; }

        [JsonPropertyName("skuComponent")]
        public SkuComponent SkuComponent { get; set; }

        [JsonPropertyName("webActionConfComponent")]
        public WebActionConfComponent WebActionConfComponent { get; set; }

        [JsonPropertyName("cartSideBarInfoComponent")]
        public CartSideBarInfoComponent CartSideBarInfoComponent { get; set; }

        [JsonPropertyName("packageComponent")]
        public PackageComponent PackageComponent { get; set; }

        [JsonPropertyName("productTagComponent")]
        public ProductTagComponent ProductTagComponent { get; set; }

        [JsonPropertyName("blacklistComponent")]
        public BlacklistComponent BlacklistComponent { get; set; }

        [JsonPropertyName("priceComponent")]
        public PriceComponent PriceComponent { get; set; }

        [JsonPropertyName("webLongImageComponent")]
        public WebLongImageComponent WebLongImageComponent { get; set; }

        [JsonPropertyName("wishListComponent")]
        public WishListComponent WishListComponent { get; set; }

        [JsonPropertyName("multiLanguageUrlComponent")]
        public MultiLanguageUrlComponent MultiLanguageUrlComponent { get; set; }

        [JsonPropertyName("webCouponInfoComponent")]
        public WebCouponInfoComponent WebCouponInfoComponent { get; set; }

        [JsonPropertyName("i18nComponent")]
        public I18nComponent I18nComponent { get; set; }

        [JsonPropertyName("bannerComponent")]
        public BannerComponent BannerComponent { get; set; }

        [JsonPropertyName("categoryComponent")]
        public CategoryComponent CategoryComponent { get; set; }

        [JsonPropertyName("buriedLogComponent")]
        public BuriedLogComponent BuriedLogComponent { get; set; }

        [JsonPropertyName("productInfoComponent")]
        public ProductInfoComponent ProductInfoComponent { get; set; }

        [JsonPropertyName("sellerGuaranteeComponent")]
        public SellerGuaranteeComponent SellerGuaranteeComponent { get; set; }

        [JsonPropertyName("buyerComponent")]
        public BuyerComponent BuyerComponent { get; set; }

        [JsonPropertyName("storeHeaderComponent")]
        public StoreHeaderComponent StoreHeaderComponent { get; set; }

        [JsonPropertyName("breadcrumbComponent")]
        public BreadcrumbComponent BreadcrumbComponent { get; set; }

        [JsonPropertyName("abTestComponent")]
        public AbTestComponent AbTestComponent { get; set; }

        [JsonPropertyName("gagaComponent")]
        public GagaComponent GagaComponent { get; set; }

        [JsonPropertyName("choiceAtmosphereComponent")]
        public ChoiceAtmosphereComponent ChoiceAtmosphereComponent { get; set; }

        [JsonPropertyName("sellingPointInfoComponent")]
        public SellingPointInfoComponent SellingPointInfoComponent { get; set; }

        [JsonPropertyName("siteInfoComponent")]
        public SiteInfoComponent SiteInfoComponent { get; set; }

        [JsonPropertyName("remindsComponent")]
        public RemindsComponent RemindsComponent { get; set; }

        [JsonPropertyName("shopCategoryComponent")]
        public ShopCategoryComponent ShopCategoryComponent { get; set; }

        [JsonPropertyName("promotionComponent")]
        public PromotionComponent PromotionComponent { get; set; }

        [JsonPropertyName("sellerPromiseComponent")]
        public SellerPromiseComponent SellerPromiseComponent { get; set; }

        [JsonPropertyName("extraComponent")]
        public ExtraComponent ExtraComponent { get; set; }

        [JsonPropertyName("marketingInfo4ChoiceComponent")]
        public MarketingInfo4ChoiceComponent MarketingInfo4ChoiceComponent { get; set; }

        [JsonPropertyName("storeFeedbackComponent")]
        public StoreFeedbackComponent StoreFeedbackComponent { get; set; }

        [JsonPropertyName("assuranceComponent")]
        public AssuranceComponent AssuranceComponent { get; set; }

        [JsonPropertyName("priceRuleComponent")]
        public PriceRuleComponent PriceRuleComponent { get; set; }

        [JsonPropertyName("marketingInfoComponent")]
        public MarketingInfoComponent MarketingInfoComponent { get; set; }

        [JsonPropertyName("webGeneralFreightCalculateComponent")]
        public WebGeneralFreightCalculateComponent WebGeneralFreightCalculateComponent { get; set; }

        [JsonPropertyName("inventoryComponent")]
        public InventoryComponent InventoryComponent { get; set; }

        [JsonPropertyName("webCouponPriceComponent")]
        public WebCouponPriceComponent WebCouponPriceComponent { get; set; }

        [JsonPropertyName("webViewComponent")]
        public WebViewComponent WebViewComponent { get; set; }

        [JsonPropertyName("installmentComponent")]
        public InstallmentComponent InstallmentComponent { get; set; }

        [JsonPropertyName("productDescComponent")]
        public ProductDescComponent ProductDescComponent { get; set; }

        [JsonPropertyName("categoryTagComponent")]
        public CategoryTagComponent CategoryTagComponent { get; set; }

        [JsonPropertyName("supplementInfoLayoutComponent")]
        public SupplementInfoLayoutComponent SupplementInfoLayoutComponent { get; set; }

        [JsonPropertyName("imageComponent")]
        public ImageComponent ImageComponent { get; set; }

        [JsonPropertyName("recommendComponent")]
        public RecommendComponent RecommendComponent { get; set; }

        [JsonPropertyName("userComponent")]
        public UserComponent UserComponent { get; set; }

        [JsonPropertyName("currencyComponent")]
        public CurrencyComponent CurrencyComponent { get; set; }

        [JsonPropertyName("itemStatusComponent")]
        public ItemStatusComponent ItemStatusComponent { get; set; }

        [JsonPropertyName("referComponent")]
        public ReferComponent ReferComponent { get; set; }

        [JsonPropertyName("feedbackComponent")]
        public FeedbackComponent FeedbackComponent { get; set; }

        [JsonPropertyName("vehicleComponent")]
        public VehicleComponent VehicleComponent { get; set; }

        [JsonPropertyName("displayTitleComponent")]
        public DisplayTitleComponent DisplayTitleComponent { get; set; }
    }
}
