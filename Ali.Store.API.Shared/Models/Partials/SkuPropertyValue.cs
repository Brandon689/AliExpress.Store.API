using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class SkuPropertyValue
    {
        [JsonPropertyName("skuColorValue")]
        public string SkuColorValue { get; set; }

        [JsonPropertyName("skuPropertyTips")]
        public string SkuPropertyTips { get; set; }

        [JsonPropertyName("propertyValueName")]
        public string PropertyValueName { get; set; }

        [JsonPropertyName("propertyValueId")]
        public int PropertyValueId { get; set; }

        [JsonPropertyName("skuPropertyImagePath")]
        public string SkuPropertyImagePath { get; set; }

        [JsonPropertyName("skuPropertyValueTips")]
        public string SkuPropertyValueTips { get; set; }

        [JsonPropertyName("skuPropertyValueShowOrder")]
        public int? SkuPropertyValueShowOrder { get; set; }

        [JsonPropertyName("propertyValueDefinitionName")]
        public string PropertyValueDefinitionName { get; set; }

        [JsonPropertyName("propertyValueIdLong")]
        public int? PropertyValueIdLong { get; set; }

        [JsonPropertyName("skuPropertyImageSummPath")]
        public string SkuPropertyImageSummPath { get; set; }

        [JsonPropertyName("propertyValueDisplayName")]
        public string PropertyValueDisplayName { get; set; }
    }
}
