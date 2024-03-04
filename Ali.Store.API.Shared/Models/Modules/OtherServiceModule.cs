using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class OtherServiceModule
    {
        [JsonPropertyName("TAB_SPECS")]
        public string TABSPECS { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_SUBTITLE_PC")]
        public string PLAZASERVICESUBTITLEPC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_EMAIL")]
        public string PLAZASERVICEWARRANTYEMAIL { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_PHONE")]
        public string PLAZASERVICEWARRANTYPHONE { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_HOURS")]
        public string PLAZASERVICEWARRANTYHOURS { get; set; }

        [JsonPropertyName("TAB_CUSTOMER_REVIEWS")]
        public string TABCUSTOMERREVIEWS { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_WEBSITE")]
        public string PLAZASERVICEWARRANTYWEBSITE { get; set; }

        [JsonPropertyName("TAB_OVERVIEW")]
        public string TABOVERVIEW { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_BRAND")]
        public string PLAZASERVICEWARRANTYBRAND { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_CATEGORY")]
        public string PLAZASERVICEWARRANTYCATEGORY { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_TITLE_PC")]
        public string PLAZASERVICETITLEPC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_CONTENT3_3_PC")]
        public string PLAZASERVICECONTENT33PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_TITLE")]
        public string PLAZASERVICEWARRANTYTITLE { get; set; }

        [JsonPropertyName("TAB_REPORT_ITEM")]
        public string TABREPORTITEM { get; set; }

        [JsonPropertyName("TAB_SERVICE")]
        public string TABSERVICE { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_CONTENT3_1_PC")]
        public string PLAZASERVICECONTENT31PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_CONTENT3_2_PC")]
        public string PLAZASERVICECONTENT32PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_CONTENT1_PC")]
        public string PLAZASERVICECONTENT1PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_SUBTITLE2_PC")]
        public string PLAZASERVICESUBTITLE2PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_CONTENT2_PC")]
        public string PLAZASERVICECONTENT2PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_SUBTITLE3_PC")]
        public string PLAZASERVICESUBTITLE3PC { get; set; }
    }
}
