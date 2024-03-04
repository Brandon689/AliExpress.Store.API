using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class ProductPropComponent
    {
        [JsonPropertyName("showPropGroups")]
        public bool? ShowPropGroups { get; set; }

        [JsonPropertyName("propGroups")]
        public List<object> PropGroups { get; set; }

        [JsonPropertyName("props")]
        public List<Prop> Props { get; set; }
    }
}
