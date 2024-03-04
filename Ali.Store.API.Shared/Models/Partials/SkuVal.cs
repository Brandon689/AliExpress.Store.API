using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class SkuVal
    {
        [JsonPropertyName("optionalWarrantyPrice")]
        public List<object> OptionalWarrantyPrice { get; set; }

        [JsonPropertyName("skuAmount")]
        public SkuAmount SkuAmount { get; set; }

        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        [JsonPropertyName("availQuantity")]
        public int? AvailQuantity { get; set; }

        [JsonPropertyName("inventory")]
        public int? Inventory { get; set; }

        [JsonPropertyName("hideOriPrice")]
        public bool? HideOriPrice { get; set; }

        [JsonPropertyName("skuCalPrice")]
        public string SkuCalPrice { get; set; }

        [JsonPropertyName("skuAmountLocal")]
        public string SkuAmountLocal { get; set; }

        [JsonPropertyName("skuActivityAmountLocal")]
        public string SkuActivityAmountLocal { get; set; }

        [JsonPropertyName("discountTips")]
        public string DiscountTips { get; set; }

        [JsonPropertyName("isActivity")]
        public bool? IsActivity { get; set; }

        [JsonPropertyName("skuActivityAmount")]
        public SkuActivityAmount SkuActivityAmount { get; set; }
    }
}
