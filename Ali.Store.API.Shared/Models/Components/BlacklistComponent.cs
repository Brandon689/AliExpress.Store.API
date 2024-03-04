using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class BlacklistComponent
    {
        [JsonPropertyName("inBlackList")]
        public bool? InBlackList { get; set; }
    }
}
