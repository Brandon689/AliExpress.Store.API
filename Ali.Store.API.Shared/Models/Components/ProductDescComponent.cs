using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class ProductDescComponent
    {
        [JsonPropertyName("descriptionUrl")]
        public string DescriptionUrl { get; set; }
    }
}
