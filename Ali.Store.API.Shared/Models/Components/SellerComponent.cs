using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class SellerComponent
    {
        [JsonPropertyName("boutiqueSeller")]
        public bool? BoutiqueSeller { get; set; }

        [JsonPropertyName("topRatedSeller")]
        public bool? TopRatedSeller { get; set; }

        [JsonPropertyName("formatOpenTime")]
        public string FormatOpenTime { get; set; }

        [JsonPropertyName("spanishPlaza")]
        public bool? SpanishPlaza { get; set; }

        [JsonPropertyName("ruConsignmentAndMarketPlace")]
        public bool? RuConsignmentAndMarketPlace { get; set; }

        [JsonPropertyName("esRetailOrConsignment")]
        public bool? EsRetailOrConsignment { get; set; }

        [JsonPropertyName("openedYear")]
        public int? OpenedYear { get; set; }

        [JsonPropertyName("plazaElectronicSeller")]
        public bool? PlazaElectronicSeller { get; set; }

        [JsonPropertyName("ruSelfOperation")]
        public bool? RuSelfOperation { get; set; }

        [JsonPropertyName("storeURL")]
        public string StoreURL { get; set; }

        [JsonPropertyName("storeFeedbackURL")]
        public string StoreFeedbackURL { get; set; }

        [JsonPropertyName("storeName")]
        public string StoreName { get; set; }

        [JsonPropertyName("hasStore")]
        public bool? HasStore { get; set; }

        [JsonPropertyName("openTime")]
        public long? OpenTime { get; set; }

        [JsonPropertyName("localSellerTag")]
        public string LocalSellerTag { get; set; }

        [JsonPropertyName("aeRuSelfOperation")]
        public bool? AeRuSelfOperation { get; set; }

        [JsonPropertyName("showPlazaHeader")]
        public bool? ShowPlazaHeader { get; set; }

        [JsonPropertyName("localSeller")]
        public bool? LocalSeller { get; set; }

        [JsonPropertyName("adminSeq")]
        public long? AdminSeq { get; set; }

        [JsonPropertyName("encryptOwnerMemberId")]
        public string EncryptOwnerMemberId { get; set; }

        [JsonPropertyName("countryCompleteName")]
        public string CountryCompleteName { get; set; }

        [JsonPropertyName("companyId")]
        public long? CompanyId { get; set; }

        [JsonPropertyName("storeLogo")]
        public string StoreLogo { get; set; }

        [JsonPropertyName("storeNum")]
        public int? StoreNum { get; set; }

        [JsonPropertyName("payPalAccount")]
        public bool? PayPalAccount { get; set; }
    }
}
