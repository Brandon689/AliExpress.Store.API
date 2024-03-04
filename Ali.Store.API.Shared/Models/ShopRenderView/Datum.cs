using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class Datum
    {
        [JsonPropertyName("atmosphere")]
        public List<Atmosphere> Atmosphere { get; set; }

        [JsonPropertyName("averageStar")]
        public double? AverageStar { get; set; }

        [JsonPropertyName("averageStarRate")]
        public double? AverageStarRate { get; set; }

        [JsonPropertyName("bigSaleProduct")]
        public bool? BigSaleProduct { get; set; }

        [JsonPropertyName("evaluateInfo")]
        public EvaluateInfo EvaluateInfo { get; set; }

        [JsonPropertyName("feedbacks")]
        public int? Feedbacks { get; set; }

        [JsonPropertyName("formatedPiecePriceStr")]
        public string FormatedPiecePriceStr { get; set; }

        [JsonPropertyName("formatedPromotionPiecePriceStr")]
        public string FormatedPromotionPiecePriceStr { get; set; }

        [JsonPropertyName("id")]
        public object Id { get; set; }

        [JsonPropertyName("image350Url")]
        public string Image350Url { get; set; }

        [JsonPropertyName("inPromotion")]
        public bool? InPromotion { get; set; }

        [JsonPropertyName("lot")]
        public bool? Lot { get; set; }

        [JsonPropertyName("minPriceUmpSellPoints")]
        public MinPriceUmpSellPoints MinPriceUmpSellPoints { get; set; }

        [JsonPropertyName("modsStyle")]
        public ModsStyle ModsStyle { get; set; }

        [JsonPropertyName("orders")]
        public int? Orders { get; set; }

        [JsonPropertyName("pcDetailUrl")]
        public string PcDetailUrl { get; set; }

        [JsonPropertyName("piecePriceMoney")]
        public PiecePriceMoney PiecePriceMoney { get; set; }

        [JsonPropertyName("pieceUnit")]
        public string PieceUnit { get; set; }

        [JsonPropertyName("piecesPerLot")]
        public int? PiecesPerLot { get; set; }

        [JsonPropertyName("priceLocalConfig")]
        public PriceLocalConfig PriceLocalConfig { get; set; }

        [JsonPropertyName("priceLocalInfo")]
        public PriceLocalInfo PriceLocalInfo { get; set; }

        [JsonPropertyName("prices")]
        public Prices Prices { get; set; }

        [JsonPropertyName("promotionDiscount")]
        public int? PromotionDiscount { get; set; }

        [JsonPropertyName("promotionPiecePriceMoney")]
        public PromotionPiecePriceMoney PromotionPiecePriceMoney { get; set; }

        [JsonPropertyName("sales")]
        public string Sales { get; set; }

        [JsonPropertyName("scaleImageUrl")]
        public string ScaleImageUrl { get; set; }

        [JsonPropertyName("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("summImageUrl")]
        public string SummImageUrl { get; set; }

        [JsonPropertyName("tagResultIds")]
        public List<object> TagResultIds { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("skuImageUrl")]
        public string SkuImageUrl { get; set; }

        [JsonPropertyName("mediaId")]
        public string MediaId { get; set; }
    }
}
