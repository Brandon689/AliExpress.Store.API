using Ali.Store.API.Models;
using Ali.Store.API.Shared;
using System.Text.Json;

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
