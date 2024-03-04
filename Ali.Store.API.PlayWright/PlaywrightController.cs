using Ali.Store.API.Models;
using Ali.Store.API.Shared;
using Microsoft.Playwright;
using System.Net;

namespace Ali.Store.API.PlayWright
{
    public class PlaywrightController
    {
        //private readonly HttpClient _httpClient;
        private IPlaywright playwright;
        private IBrowser browser;
        private IPage page;
        private string baseUrl;
        private string baseName;

        //private ParallelDownloader download = new();
        string xeni;
        bool first = false;
        public PlaywrightController()
        {
            //_httpClient = new HttpClient();
        }

        public string GetBaseName()
        {
            return baseName;
        }
        //int piko = 0;

        public async Task<AliexpressItem> GetPageJSON(long aliexpressProductId)
        {
            await page.GotoAsync($"https://www.aliexpress.com/item/{aliexpressProductId}.html");
            string content = await page.ContentAsync();
            return Share.ParseHtml(content);
        }

        public async Task Init(string _baseUrl)
        {
            baseUrl = _baseUrl;
            baseName = deriveName();
            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new() { Headless = true });
            page = await browser.NewPageAsync();
            //await page.RouteAsync("**/*.js", route => route.AbortAsync());
            await page.RouteAsync("**/*", (route) =>
            {
                if (route.Request.ResourceType == "image"
                || route.Request.ResourceType == "media"
                || route.Request.ResourceType == "xhr"
                || route.Request.ResourceType == "font")
                {
                    route.AbortAsync();
                }
                else
                {
                    route.ContinueAsync();
                }
            });

            //string trim(string mtop)
            //{
            //    string x = mtop.Substring(12);
            //    if (x[0] == '(')
            //        x = x.Substring(1);
            //    return x.Substring(0, x.Length - 1);
            //}

            //await page.RouteAsync("**/*", async (route) =>
            //{
            //    bool found = false;
            //    var request = route.Request;

            //    if (request.ResourceType == "image"
            //        || request.ResourceType == "font")
            //        route.AbortAsync();
            //    // Check if the resource type is XHR and the 'Content-Type' header is present and indicates JSON
            //    if (request.ResourceType == "script"
            //        //&& request.Headers.ContainsKey("Content-Type") &&
            //        //request.Headers["Content-Type"].Contains("application/json")
            //        )
            //    {
            //        //Console.WriteLine($"Intercepted JSON request: {request.Url}");
            //        // You can add your logic to handle the intercepted JSON request here
            //        if (request.Url.Contains("mtop.ae.shop.search.product.group"))
            //        {
            //            xeni = request.Url;
            //            Console.WriteLine(xeni);

            //            route.ContinueAsync();

            //            // Waiting for and getting the response
            //            var response = await request.ResponseAsync();
            //            var t = await response.TextAsync();
            //            t = trim(t);
            //            //await Console.Out.WriteLineAsync(t);
            //            try
            //            {
            //                var c = JsonSerializer.Deserialize<Root>(t);
            //                ;
            //                //File.WriteAllText($"../../{piko++}.json", t);
            //                File.WriteAllText($"../../mitai/{c.Baka.Data[0].Id}-{c.Baka.CurrentPage}.json", JsonSerializer.Serialize(c, new JsonSerializerOptions() { WriteIndented = true }));
            //                if (first)
            //                {
            //                    found = true;
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.Out.WriteLine(ex);
            //            }
            //        }
            //    }
            //    if (found)
            //    {
            //        await route.AbortAsync();
            //    }
            //    // Continue with the request in all cases
            //    route.ContinueAsync();
            //});
        }

        public async Task Dispose()
        {
            await browser.CloseAsync();
            playwright.Dispose();
            await browser.DisposeAsync();
        }
        
        int bogo = 0;

        public async Task Goo()
        {
            var xx = "https://yufanmodel.aliexpress.com/store/4682001/pages/all-items.html";
            //xx = "https://www.aliexpress.com/store/1102658246/pages/all-items.html";
            page.SetDefaultTimeout(13000);
            try
            {
                await page.GotoAsync(xx);
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Page loading timed out. Stopping loading.");
            }
            await Task.Delay(2000);
            if (!first)
            {
                string pageCountSelector = "#right > div:nth-child(1) > div:nth-child(4) > div:nth-child(2) > div:nth-child(2) > span:nth-child(3)";

                var v = await page.QuerySelectorAsync(pageCountSelector);
                var k = await v.InnerTextAsync();
                bogo = int.Parse(k);
            }
            first = true;

            string divSelector = "#right > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(3)";

            // Click the div element
            await page.ClickAsync(divSelector);


            await Task.Delay(2000);
            for (int i = 0; i < bogo; i++)
            {
                await page.ClickAsync(divSelector);
                await Task.Delay(2000);
            }
        }
        
        //string y(string uri, int i)
        //{
        //    string decodedUrl = WebUtility.UrlDecode(uri);
        //    decodedUrl = decodedUrl.Replace($"\"currentPage\":{i}", $"\"currentPage\":{i + 1}");
        //    string encodedUrl = Uri.EscapeUriString(decodedUrl);
        //    return encodedUrl;
        //}

        public async Task GetHrefs()
        {
            await page.GotoAsync("https://yufanmodel.aliexpress.com/store/4682001/pages/all-items.html?spm=a2g0o.detail.1000061.2.f17cDS29DS29OJ&shop_sortType=bestmatch_sort");
            await Task.Delay(4000);
            //var m = await page.QuerySelectorAllAsync("sitemapindex sitemap");
            var links = await page.QuerySelectorAllAsync("a");

            var hrefTasks = links.Select(link => link.GetAttributeAsync("href"));
            var hrefs = await Task.WhenAll(hrefTasks);
            var aaa = hrefs.Where(x => x != null && x.Contains("aliexpress.com/item/"));
            foreach (var href in hrefs)
            {
                // Console.WriteLine(href);
            }

            Console.WriteLine(aaa != null);
            foreach (var href in aaa)
            {
                Console.WriteLine(href);
            }
        }

        private string deriveName()
        {
            return baseUrl
                .Replace("https://", "")
                .Replace("www.", "")
                .Replace(".com", "");
        }
    }
}