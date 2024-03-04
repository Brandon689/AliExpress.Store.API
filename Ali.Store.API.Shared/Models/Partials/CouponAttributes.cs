using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class CouponAttributes
    {
        [JsonPropertyName("couponPackageText")]
        public string CouponPackageText { get; set; }
    }
}
