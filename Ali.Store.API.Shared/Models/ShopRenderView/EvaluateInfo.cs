using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.ShopRenderView
{
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
}
