using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class SkuComponent
    {
        [JsonPropertyName("selectedSkuAttr")]
        public string SelectedSkuAttr { get; set; }

        [JsonPropertyName("hasSkuProperty")]
        public bool? HasSkuProperty { get; set; }

        [JsonPropertyName("productSKUPropertyList")]
        public List<ProductSKUPropertyList> ProductSKUPropertyList { get; set; }

        [JsonPropertyName("skuPropertyJson")]
        public string SkuPropertyJson { get; set; }
    }
}
