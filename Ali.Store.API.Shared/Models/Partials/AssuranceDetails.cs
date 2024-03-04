using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class AssuranceDetails
    {
        [JsonPropertyName("details")]
        public List<Detail> Details { get; set; }

        [JsonPropertyName("actionTarget")]
        public string ActionTarget { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
