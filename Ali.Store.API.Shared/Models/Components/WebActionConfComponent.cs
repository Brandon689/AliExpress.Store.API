using Ali.Store.API.Models.Partials;
using System.Text.Json.Serialization;

namespace Ali.Store.API.Models
{
    public class WebActionConfComponent
    {
        [JsonPropertyName("actionConfs")]
        public ActionConfs ActionConfs { get; set; }

        [JsonPropertyName("orderUrl")]
        public string OrderUrl { get; set; }

        [JsonPropertyName("shoppingCartUrl")]
        public string ShoppingCartUrl { get; set; }
    }
}
