using Ali.Store.API.Models;
using Ali.Store.API.Shared;

namespace Ali.Store.API
{
    public class Scrape
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<AliexpressItem> GetPage(long aliexpressProductId)
        {
            string content = await _httpClient.GetStringAsync($"https://www.aliexpress.com/item/{aliexpressProductId}.html");
            //File.WriteAllText("../../v.html", content);
            return Share.ParseHtml(content);
        }
    }
}
