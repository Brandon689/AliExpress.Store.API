using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class SwitchInfo
    {
        [JsonPropertyName("showPropOuter")]
        public bool? ShowPropOuter { get; set; }

        [JsonPropertyName("deliveryMigrate")]
        public bool? DeliveryMigrate { get; set; }

        [JsonPropertyName("skuUnavailableRevision")]
        public bool? SkuUnavailableRevision { get; set; }

        [JsonPropertyName("allowUSVisitorCart")]
        public bool? AllowUSVisitorCart { get; set; }

        [JsonPropertyName("showPropGroups")]
        public bool? ShowPropGroups { get; set; }
    }
}
