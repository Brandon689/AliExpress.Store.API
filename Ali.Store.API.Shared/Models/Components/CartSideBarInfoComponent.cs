using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Components
{
    public class CartSideBarInfoComponent
    {
        [JsonPropertyName("hideCartSideBar")]
        public bool? HideCartSideBar { get; set; }

        [JsonPropertyName("siteType")]
        public string SiteType { get; set; }
    }
}
