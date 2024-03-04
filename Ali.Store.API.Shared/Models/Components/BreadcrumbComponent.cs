using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class BreadcrumbComponent
    {
        [JsonPropertyName("categoryUrl")]
        public string CategoryUrl { get; set; }

        [JsonPropertyName("pathList")]
        public List<PathList> PathList { get; set; }

        [JsonPropertyName("categoryName")]
        public string CategoryName { get; set; }
    }
}
