using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class AdditionLayout
    {
        [JsonPropertyName("displayCondition")]
        public string DisplayCondition { get; set; }

        [JsonPropertyName("componentId")]
        public string ComponentId { get; set; }

        [JsonPropertyName("distance")]
        public int? Distance { get; set; }

        [JsonPropertyName("blockType")]
        public string BlockType { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("blockGroup")]
        public string BlockGroup { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("useInDeliveryOptionPanel")]
        public bool? UseInDeliveryOptionPanel { get; set; }

        [JsonPropertyName("useInDetailFirstScreen")]
        public bool? UseInDetailFirstScreen { get; set; }

        [JsonPropertyName("medusaKey")]
        public string MedusaKey { get; set; }

        [JsonPropertyName("useInSkuSwitch")]
        public bool? UseInSkuSwitch { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }
}
