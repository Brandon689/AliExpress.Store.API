using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class BuyerComponent
    {
        [JsonPropertyName("adultCertificationStatus")]
        public int? AdultCertificationStatus { get; set; }
    }
}
