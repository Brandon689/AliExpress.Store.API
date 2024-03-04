using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class ItemDetailResp
    {
        [JsonPropertyName("ASK_BUYERS")]
        public string ASKBUYERS { get; set; }

        [JsonPropertyName("VIEW_5_MORE_ANSWERS")]
        public string VIEW5MOREANSWERS { get; set; }

        [JsonPropertyName("PAGE_NOT_FOUND_RCMD_TITLE")]
        public string PAGENOTFOUNDRCMDTITLE { get; set; }

        [JsonPropertyName("VIEW_MORE")]
        public string VIEWMORE { get; set; }

        [JsonPropertyName("PAGE_NOT_FOUND_NOTICE")]
        public string PAGENOTFOUNDNOTICE { get; set; }
    }
}
