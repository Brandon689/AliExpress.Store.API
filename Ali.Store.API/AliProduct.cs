using System.Text.Json.Serialization;

namespace Ali.Store.API
{
    public class Atmosphere
    {
        [JsonPropertyName("atmosphereDTOList")]
        public List<AtmosphereDTOList> AtmosphereDTOList { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("resourcePositionCode")]
        public string ResourcePositionCode { get; set; }
    }

    public class AtmosphereDTOList
    {
        [JsonPropertyName("isWarmup")]
        public bool? IsWarmup { get; set; }

        [JsonPropertyName("features")]
        public Features Features { get; set; }

        [JsonPropertyName("atmosphereCode")]
        public string AtmosphereCode { get; set; }

        [JsonPropertyName("materials")]
        public List<Material> Materials { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("priority")]
        public int? Priority { get; set; }
    }

    public class Datum
    {
        [JsonPropertyName("atmosphere")]
        public List<Atmosphere> Atmosphere { get; set; }

        [JsonPropertyName("skuImageUrl")]
        public string SkuImageUrl { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("formatedPromotionPiecePriceStr")]
        public string FormatedPromotionPiecePriceStr { get; set; }

        [JsonPropertyName("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonPropertyName("promotionPiecePriceMoney")]
        public PromotionPiecePriceMoney PromotionPiecePriceMoney { get; set; }

        [JsonPropertyName("sales")]
        public string Sales { get; set; }

        [JsonPropertyName("priceLocalConfig")]
        public PriceLocalConfig PriceLocalConfig { get; set; }

        [JsonPropertyName("priceLocalInfo")]
        public PriceLocalInfo PriceLocalInfo { get; set; }

        [JsonPropertyName("lot")]
        public bool? Lot { get; set; }

        [JsonPropertyName("tagResultIds")]
        public List<string> TagResultIds { get; set; }

        [JsonPropertyName("promotionDiscount")]
        public int? PromotionDiscount { get; set; }

        [JsonPropertyName("inPromotion")]
        public bool? InPromotion { get; set; }

        [JsonPropertyName("piecesPerLot")]
        public int? PiecesPerLot { get; set; }

        [JsonPropertyName("pieceUnit")]
        public string PieceUnit { get; set; }

        [JsonPropertyName("evaluateInfo")]
        public EvaluateInfo EvaluateInfo { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("bigSaleProduct")]
        public bool? BigSaleProduct { get; set; }

        [JsonPropertyName("prices")]
        public Prices Prices { get; set; }

        [JsonPropertyName("minPriceUmpSellPoints")]
        public MinPriceUmpSellPoints MinPriceUmpSellPoints { get; set; }

        [JsonPropertyName("image350Url")]
        public string Image350Url { get; set; }

        [JsonPropertyName("formatedPiecePriceStr")]
        public string FormatedPiecePriceStr { get; set; }

        [JsonPropertyName("pcDetailUrl")]
        public string PcDetailUrl { get; set; }

        [JsonPropertyName("averageStarRate")]
        public double? AverageStarRate { get; set; }

        [JsonPropertyName("feedbacks")]
        public int? Feedbacks { get; set; }

        [JsonPropertyName("summImageUrl")]
        public string SummImageUrl { get; set; }

        [JsonPropertyName("image640Url")]
        public string Image640Url { get; set; }

        [JsonPropertyName("scaleImageUrl")]
        public string ScaleImageUrl { get; set; }

        [JsonPropertyName("averageStar")]
        public double? AverageStar { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("piecePriceMoney")]
        public PiecePriceMoney PiecePriceMoney { get; set; }

        [JsonPropertyName("orders")]
        public int? Orders { get; set; }

        [JsonPropertyName("modsStyle")]
        public ModsStyle ModsStyle { get; set; }

        [JsonPropertyName("tagResult")]
        public string TagResult { get; set; }

        [JsonPropertyName("productTags")]
        public List<string> ProductTags { get; set; }
    }

    public class EvaluateInfo
    {
        [JsonPropertyName("starWidth")]
        public int? StarWidth { get; set; }

        [JsonPropertyName("starUrl")]
        public string StarUrl { get; set; }

        [JsonPropertyName("starHeight")]
        public int? StarHeight { get; set; }

        [JsonPropertyName("starRating")]
        public double? StarRating { get; set; }
    }

    public class Features
    {
        [JsonPropertyName("umpPromotionId")]
        public List<object> UmpPromotionId { get; set; }
    }

    public class Fragments
    {
        [JsonPropertyName("0052")]
        public string _0052 { get; set; }

        [JsonPropertyName("0011_amount")]
        public string _0011Amount { get; set; }

        [JsonPropertyName("0011")]
        public string _0011 { get; set; }

        [JsonPropertyName("0011_currency")]
        public string _0011Currency { get; set; }

        [JsonPropertyName("1002")]
        public string _1002 { get; set; }
    }

    public class From
    {
        [JsonPropertyName("thousandsChar")]
        public string ThousandsChar { get; set; }

        [JsonPropertyName("decimalPointChar")]
        public string DecimalPointChar { get; set; }

        [JsonPropertyName("currencySymbolPosition")]
        public string CurrencySymbolPosition { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("showDecimal")]
        public bool? ShowDecimal { get; set; }
    }

    public class Material
    {
        [JsonPropertyName("materialCode")]
        public string MaterialCode { get; set; }

        [JsonPropertyName("fragments")]
        public Fragments Fragments { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }
    }

    public class MinPriceUmpSellPoints
    {
        [JsonPropertyName("atmosphere")]
        public string Atmosphere { get; set; }

        [JsonPropertyName("promotions")]
        public string Promotions { get; set; }

        [JsonPropertyName("skuChannelStock")]
        public string SkuChannelStock { get; set; }

        [JsonPropertyName("atmospherePromotions")]
        public string AtmospherePromotions { get; set; }

        [JsonPropertyName("umpFreightTemplateId")]
        public string UmpFreightTemplateId { get; set; }

        [JsonPropertyName("v")]
        public string V { get; set; }

        [JsonPropertyName("original_price_intention_cent")]
        public string OriginalPriceIntentionCent { get; set; }

        [JsonPropertyName("attributes")]
        public string Attributes { get; set; }

        [JsonPropertyName("channelType")]
        public string ChannelType { get; set; }

        [JsonPropertyName("intentionDiscount")]
        public string IntentionDiscount { get; set; }

        [JsonPropertyName("skuChannelInventoryType")]
        public string SkuChannelInventoryType { get; set; }

        [JsonPropertyName("promotion_id_for_venue")]
        public string PromotionIdForVenue { get; set; }
    }

    public class ModsStyle
    {
        [JsonPropertyName("price")]
        public Price Price { get; set; }
    }

    public class PiecePrice
    {
        [JsonPropertyName("amount")]
        public double? Amount { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }
    }

    public class PiecePriceMoney
    {
        [JsonPropertyName("amount")]
        public double? Amount { get; set; }

        [JsonPropertyName("cent")]
        public int? Cent { get; set; }

        [JsonPropertyName("centFactor")]
        public int? CentFactor { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }
    }

    public class Price
    {
        [JsonPropertyName("decimal_point")]
        public string DecimalPoint { get; set; }

        [JsonPropertyName("comma_style")]
        public string CommaStyle { get; set; }

        [JsonPropertyName("symbol_position")]
        public string SymbolPosition { get; set; }
    }

    public class PriceLocalConfig
    {
        [JsonPropertyName("single")]
        public Single Single { get; set; }

        [JsonPropertyName("separatorStr")]
        public string SeparatorStr { get; set; }

        [JsonPropertyName("from")]
        public From From { get; set; }

        [JsonPropertyName("to")]
        public To To { get; set; }

        [JsonPropertyName("useful")]
        public bool? Useful { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }

    public class PriceLocalInfo
    {
        [JsonPropertyName("promotionPiecePriceStructure")]
        public string PromotionPiecePriceStructure { get; set; }

        [JsonPropertyName("piecePriceStructure")]
        public string PiecePriceStructure { get; set; }

        [JsonPropertyName("promotionPiecePriceFormat")]
        public string PromotionPiecePriceFormat { get; set; }

        [JsonPropertyName("piecePriceFormat")]
        public string PiecePriceFormat { get; set; }
    }

    public class Prices
    {
        [JsonPropertyName("piecePrice")]
        public PiecePrice PiecePrice { get; set; }

        [JsonPropertyName("promotionPiecePrice")]
        public PromotionPiecePrice PromotionPiecePrice { get; set; }

        [JsonPropertyName("currentSymbol")]
        public string CurrentSymbol { get; set; }
    }

    public class Products
    {
        [JsonPropertyName("currentPage")]
        public int? CurrentPage { get; set; }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; set; }

        [JsonPropertyName("offset")]
        public int? Offset { get; set; }

        [JsonPropertyName("pageSize")]
        public int? PageSize { get; set; }

        [JsonPropertyName("totalCount")]
        public int? TotalCount { get; set; }

        [JsonPropertyName("totalPage")]
        public int? TotalPage { get; set; }
    }

    public class PromotionPiecePrice
    {
        [JsonPropertyName("amount")]
        public double? Amount { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }
    }

    public class PromotionPiecePriceMoney
    {
        [JsonPropertyName("amount")]
        public double? Amount { get; set; }

        [JsonPropertyName("cent")]
        public int? Cent { get; set; }

        [JsonPropertyName("centFactor")]
        public int? CentFactor { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("products")]
        public Products Products { get; set; }
    }

    public class AliProduct
    {
        [JsonPropertyName("code")]
        public int? Code { get; set; }

        [JsonPropertyName("result")]
        public Result Result { get; set; }

        [JsonPropertyName("success")]
        public bool? Success { get; set; }
    }

    public class Single
    {
        [JsonPropertyName("thousandsChar")]
        public string ThousandsChar { get; set; }

        [JsonPropertyName("decimalPointChar")]
        public string DecimalPointChar { get; set; }

        [JsonPropertyName("currencySymbolPosition")]
        public string CurrencySymbolPosition { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("showDecimal")]
        public bool? ShowDecimal { get; set; }
    }

    public class To
    {
        [JsonPropertyName("thousandsChar")]
        public string ThousandsChar { get; set; }

        [JsonPropertyName("decimalPointChar")]
        public string DecimalPointChar { get; set; }

        [JsonPropertyName("currencySymbolPosition")]
        public string CurrencySymbolPosition { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("showDecimal")]
        public bool? ShowDecimal { get; set; }
    }
}
