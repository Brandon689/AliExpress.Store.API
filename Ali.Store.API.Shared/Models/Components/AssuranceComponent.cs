using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class AssuranceComponent
    {
        [JsonPropertyName("assuranceDetails")]
        public AssuranceDetails AssuranceDetails { get; set; }
    }
}
