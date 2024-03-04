using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class Prices
    {
        [JsonPropertyName("piecePrice")]
        public PiecePrice PiecePrice { get; set; }

        [JsonPropertyName("promotionPiecePrice")]
        public PromotionPiecePrice PromotionPiecePrice { get; set; }

        [JsonPropertyName("currentSymbol")]
        public string CurrentSymbol { get; set; }
    }
}
