using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class WebLongImageComponent
    {
        [JsonPropertyName("showLongImage")]
        public bool? ShowLongImage { get; set; }
    }
}
