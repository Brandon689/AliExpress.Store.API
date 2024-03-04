using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class WishListComponent
    {
        [JsonPropertyName("storeWishedCount")]
        public int? StoreWishedCount { get; set; }

        [JsonPropertyName("itemWishedCount")]
        public int? ItemWishedCount { get; set; }

        [JsonPropertyName("storeWished")]
        public bool? StoreWished { get; set; }

        [JsonPropertyName("itemWished")]
        public bool? ItemWished { get; set; }
    }
}
