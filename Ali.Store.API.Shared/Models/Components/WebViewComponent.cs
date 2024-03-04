using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class WebViewComponent
    {
        [JsonPropertyName("viewName")]
        public string ViewName { get; set; }
    }
}
