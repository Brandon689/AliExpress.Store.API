using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
    public class MinPriceUmpSellPoints
    {
        [JsonPropertyName("atmosphere")]
        public string Atmosphere { get; set; }

        [JsonPropertyName("promotions")]
        public string Promotions { get; set; }

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

        [JsonPropertyName("promotion_id_for_venue")]
        public string PromotionIdForVenue { get; set; }
    }
}
