using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class StoreModule
    {
        [JsonPropertyName("COUSTOMER_SERVICE")]
        public string COUSTOMERSERVICE { get; set; }

        [JsonPropertyName("VISIT_STORE")]
        public string VISITSTORE { get; set; }

        [JsonPropertyName("CONTACT_SELLER")]
        public string CONTACTSELLER { get; set; }

        [JsonPropertyName("FOLLOWING_STATE")]
        public string FOLLOWINGSTATE { get; set; }

        [JsonPropertyName("UNFOLLOWING_STATE")]
        public string UNFOLLOWINGSTATE { get; set; }

        [JsonPropertyName("POSITIVE_FEEDBACK")]
        public string POSITIVEFEEDBACK { get; set; }

        [JsonPropertyName("FOLLOWERS")]
        public string FOLLOWERS { get; set; }

        [JsonPropertyName("FOLLOWER")]
        public string FOLLOWER { get; set; }

        [JsonPropertyName("TOP_SELLER")]
        public string TOPSELLER { get; set; }

        [JsonPropertyName("STORE_CATEGORIES")]
        public string STORECATEGORIES { get; set; }
    }
}
