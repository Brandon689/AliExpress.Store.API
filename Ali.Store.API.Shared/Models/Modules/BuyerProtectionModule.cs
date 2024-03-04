using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Modules
{
    public class BuyerProtectionModule
    {
        [JsonPropertyName("PLAZA_BUYER_PROTECTION_TIP")]
        public string PLAZABUYERPROTECTIONTIP { get; set; }

        [JsonPropertyName("PLAZA_BUYER_PROTECTION_TITLE")]
        public string PLAZABUYERPROTECTIONTITLE { get; set; }

        [JsonPropertyName("PLAZA_BUYER_PROTECTION_CONTENT")]
        public string PLAZABUYERPROTECTIONCONTENT { get; set; }
    }
}
