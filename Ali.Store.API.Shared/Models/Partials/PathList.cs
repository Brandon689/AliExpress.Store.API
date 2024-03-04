using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class PathList
    {
        [JsonPropertyName("cateId")]
        public int? CateId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
