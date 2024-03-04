using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class PlazaSellerServiceComponent
    {
        [JsonPropertyName("warranty")]
        public Warranty Warranty { get; set; }

        [JsonPropertyName("hasWarrantyInfo")]
        public bool? HasWarrantyInfo { get; set; }
    }
}
