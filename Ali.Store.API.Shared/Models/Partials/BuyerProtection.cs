using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class BuyerProtection
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }
}
