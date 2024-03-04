using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class WebGeneralFreightCalculateComponent
    {
        [JsonPropertyName("hideShipFrom")]
        public bool? HideShipFrom { get; set; }

        [JsonPropertyName("allowArouseLayer")]
        public bool? AllowArouseLayer { get; set; }

        [JsonPropertyName("shippingFeeText")]
        public string ShippingFeeText { get; set; }

        [JsonPropertyName("originalLayoutResultList")]
        public List<OriginalLayoutResultList> OriginalLayoutResultList { get; set; }

        [JsonPropertyName("deliveryExtraInfoMap")]
        public DeliveryExtraInfoMap DeliveryExtraInfoMap { get; set; }

        [JsonPropertyName("freightExt")]
        public string FreightExt { get; set; }

        [JsonPropertyName("styleCode")]
        public string StyleCode { get; set; }

        [JsonPropertyName("promotionId")]
        public string PromotionId { get; set; }

        [JsonPropertyName("usingNewFreight")]
        public bool? UsingNewFreight { get; set; }
    }
}
