using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class BpLocalDomesticReturn
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }
}
