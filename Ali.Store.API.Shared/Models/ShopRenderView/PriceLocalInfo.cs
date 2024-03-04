using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
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
}
