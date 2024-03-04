using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class StoreFeedbackComponent
    {
        [JsonPropertyName("sellerScore")]
        public int? SellerScore { get; set; }

        [JsonPropertyName("sellerTotalNum")]
        public int? SellerTotalNum { get; set; }

        [JsonPropertyName("sellerLevel")]
        public string SellerLevel { get; set; }

        [JsonPropertyName("sellerPositiveRate")]
        public string SellerPositiveRate { get; set; }

        [JsonPropertyName("sellerPositiveNum")]
        public int? SellerPositiveNum { get; set; }
    }
}
