using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partial
{
    public class ActionModule
    {
        [JsonPropertyName("VIEW_DETAIL")]
        public string VIEWDETAIL { get; set; }

        [JsonPropertyName("WISH_MAX_NOTICE")]
        public string WISHMAXNOTICE { get; set; }

        [JsonPropertyName("BUYER_ABLE")]
        public string BUYERABLE { get; set; }

        [JsonPropertyName("WISHLIST_SAVE_BUTTON")]
        public string WISHLISTSAVEBUTTON { get; set; }

        [JsonPropertyName("WISH_MOVE_TO_ANOTHER_LIST_TIPS")]
        public string WISHMOVETOANOTHERLISTTIPS { get; set; }

        [JsonPropertyName("ADD_X_MORE")]
        public string ADDXMORE { get; set; }

        [JsonPropertyName("COMING_SOON")]
        public string COMINGSOON { get; set; }

        [JsonPropertyName("SC_ADD_SUCC")]
        public string SCADDSUCC { get; set; }

        [JsonPropertyName("WISHLIST_PUBLIC_NOTICE")]
        public string WISHLISTPUBLICNOTICE { get; set; }

        [JsonPropertyName("WISH_DETAULT_LIST")]
        public string WISHDETAULTLIST { get; set; }

        [JsonPropertyName("WISH_CREATE_LIST")]
        public string WISHCREATELIST { get; set; }

        [JsonPropertyName("WL_ERROR")]
        public string WLERROR { get; set; }

        [JsonPropertyName("WISH_NAME_ALREADY_USE")]
        public string WISHNAMEALREADYUSE { get; set; }

        [JsonPropertyName("WISH_REVISELIST")]
        public string WISHREVISELIST { get; set; }

        [JsonPropertyName("ADD_TO_MY_PICKS")]
        public string ADDTOMYPICKS { get; set; }

        [JsonPropertyName("SC_ADD_FAILED")]
        public string SCADDFAILED { get; set; }

        [JsonPropertyName("SC_HAVE")]
        public string SCHAVE { get; set; }

        [JsonPropertyName("ADD_TO_CART")]
        public string ADDTOCART { get; set; }

        [JsonPropertyName("WISH_CANCEL_WISHLIST")]
        public string WISHCANCELWISHLIST { get; set; }

        [JsonPropertyName("BUY_NOW")]
        public string BUYNOW { get; set; }

        [JsonPropertyName("WISH_SYSTEM_ERROR")]
        public string WISHSYSTEMERROR { get; set; }

        [JsonPropertyName("SC_ADD_MAX")]
        public string SCADDMAX { get; set; }

        [JsonPropertyName("SC_VIEW")]
        public string SCVIEW { get; set; }

        [JsonPropertyName("WISH_YOUMAYLIKE")]
        public string WISHYOUMAYLIKE { get; set; }

        [JsonPropertyName("WISH_VIEW_WISH_LIST")]
        public string WISHVIEWWISHLIST { get; set; }

        [JsonPropertyName("SC_RECOMMEND")]
        public string SCRECOMMEND { get; set; }

        [JsonPropertyName("CONTINUE")]
        public string CONTINUE { get; set; }

        [JsonPropertyName("ADDED_TO")]
        public string ADDEDTO { get; set; }

        [JsonPropertyName("ORDER_NOW")]
        public string ORDERNOW { get; set; }

        [JsonPropertyName("SELECT_TIP")]
        public string SELECTTIP { get; set; }

        [JsonPropertyName("NO_LONGER_AVAILABLE")]
        public string NOLONGERAVAILABLE { get; set; }

        [JsonPropertyName("PREVIEW_PERIOD")]
        public string PREVIEWPERIOD { get; set; }

        [JsonPropertyName("WISH_MAX_GROUP")]
        public string WISHMAXGROUP { get; set; }

        [JsonPropertyName("FIND_SIMILAR")]
        public string FINDSIMILAR { get; set; }

        [JsonPropertyName("WISHLIST_PUBLIC_TIP")]
        public string WISHLISTPUBLICTIP { get; set; }
    }
}
