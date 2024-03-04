using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class ActionConfs
    {
        [JsonPropertyName("buyNowBtn")]
        public BuyNowBtn BuyNowBtn { get; set; }

        [JsonPropertyName("message")]
        public Message Message { get; set; }
    }
}
