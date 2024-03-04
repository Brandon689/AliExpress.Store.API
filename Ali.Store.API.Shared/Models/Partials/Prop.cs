using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class Prop
    {
        [JsonPropertyName("attrValue")]
        public string AttrValue { get; set; }

        [JsonPropertyName("attrName")]
        public string AttrName { get; set; }
    }
}
