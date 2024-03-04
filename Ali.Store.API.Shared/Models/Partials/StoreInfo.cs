using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class StoreInfo
    {
        [JsonPropertyName("shippingSpeed")]
        public string ShippingSpeed { get; set; }

        [JsonPropertyName("below_average")]
        public string BelowAverage { get; set; }

        [JsonPropertyName("higher_seller")]
        public string HigherSeller { get; set; }

        [JsonPropertyName("storeId")]
        public string StoreId { get; set; }

        [JsonPropertyName("openSince")]
        public string OpenSince { get; set; }

        [JsonPropertyName("above_average")]
        public string AboveAverage { get; set; }

        [JsonPropertyName("itemAsDescribed")]
        public string ItemAsDescribed { get; set; }

        [JsonPropertyName("lower_seller")]
        public string LowerSeller { get; set; }

        [JsonPropertyName("businessInfo")]
        public string BusinessInfo { get; set; }

        [JsonPropertyName("equal")]
        public string Equal { get; set; }

        [JsonPropertyName("storeName")]
        public string StoreName { get; set; }

        //[JsonPropertyName("storeInfo")]
        //public string StoreInfo { get; set; }

        [JsonPropertyName("storeRating")]
        public string StoreRating { get; set; }

        [JsonPropertyName("businessAddress")]
        public string BusinessAddress { get; set; }

        [JsonPropertyName("communication")]
        public string Communication { get; set; }

        [JsonPropertyName("equal_seller")]
        public string EqualSeller { get; set; }
    }
}
