using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class MetaDataComponent
    {
        [JsonPropertyName("keywords")]
        public string Keywords { get; set; }

        [JsonPropertyName("canonicalTag")]
        public string CanonicalTag { get; set; }

        [JsonPropertyName("hreflangTag")]
        public string HreflangTag { get; set; }

        [JsonPropertyName("ogTitle")]
        public string OgTitle { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("mediaTag")]
        public string MediaTag { get; set; }

        [JsonPropertyName("ogurl")]
        public string Ogurl { get; set; }

        [JsonPropertyName("amphtmlTag")]
        public string AmphtmlTag { get; set; }

        [JsonPropertyName("ogDescription")]
        public string OgDescription { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
