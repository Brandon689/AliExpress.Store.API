using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class ProductSKUPropertyList
    {
        [JsonPropertyName("showTypeColor")]
        public bool? ShowTypeColor { get; set; }

        [JsonPropertyName("sizeProperty")]
        public bool? SizeProperty { get; set; }

        [JsonPropertyName("skuPropertyValues")]
        public List<SkuPropertyValue> SkuPropertyValues { get; set; }

        [JsonPropertyName("showType")]
        public string ShowType { get; set; }

        [JsonPropertyName("skuPropertyName")]
        public string SkuPropertyName { get; set; }

        [JsonPropertyName("skuPropertyId")]
        public int? SkuPropertyId { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }
}
