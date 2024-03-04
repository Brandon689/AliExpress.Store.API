using GlobalProduct;
using GlobalProduct.ProductJSON;
using System.Text;
using System.Text.Json;

namespace Ali.Store.API
{
    public class AliAPI
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string callback = "jsonp_1707798573906_94477";
        public AliAPI()
        {

        }
        // rmove product and return original aliexpress model
        public async ValueTask<List<Product>> GetProductPage(string sellerId, int pg, int perPage)
        {
            List<Product> pp = new List<Product>();
            var xo = await _httpClient.GetStringAsync(BuildURI(pg, perPage, sellerId));
            xo = MakeValidJSON(xo, callback);
            var g = JsonSerializer.Deserialize<AliProduct>(xo);
            File.WriteAllText("../p.json", JsonSerializer.Serialize(g));
            try
            {
                for (int j = 0; j < g.Result.Products.Data.Count; j++)
                {
                    var x = g.Result.Products.Data[j];
                    Product p = new()
                    {
                        Title = x.Subject,
                        Images = new(),
                        Variants = new(),
                        Currency = x.PromotionPiecePriceMoney.Currency,
                        Url = "https:" + x.PcDetailUrl,
                        sales = x.Sales,
                        averageStar = x.AverageStar,
                        averageStarRate = x.AverageStarRate,
                        feedbacks = x.Feedbacks,
                        Id2 = x.Id
                    };
                    p.Images.Add(
                        new Image()
                        {
                            Src = x.Image640Url.Replace("_640x640.png", "").Replace("_640x640.jpg", "")
                        }
                        );
                    p.Variants.Add(new Variant()
                    {
                        CompareAtPrice = x.Prices.PromotionPiecePrice.Amount.ToString(),
                        Price = x.Prices.PiecePrice.Amount.ToString()
                    });
                    pp.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return pp;
        }

        public async ValueTask<List<Product>> GetProductList(string sellerId, bool abort = false)
        {
            List<Product> pp = new List<Product>();
            int max = 2;
            if (abort) max = 1;
            for (int i = 1; i <= max; i++)
            {
                var xo = await _httpClient.GetStringAsync(BuildURI(i, 30, sellerId));
                xo = MakeValidJSON(xo, callback);
                //File.WriteAllText("../../h.json", xo);
                var g = JsonSerializer.Deserialize<AliProduct>(xo);
                if (i == 1 && abort == false)
                    max = (int)g.Result.Products.TotalPage;
                try
                {
                    for (int j = 0; j < g.Result.Products.Data.Count; j++)
                    {
                        var x = g.Result.Products.Data[j];
                        Product p = new()
                        {
                            Title = x.Subject,
                            Images = new(),
                            Variants = new(),
                            Currency = x.PromotionPiecePriceMoney.Currency,
                            Url = "https:" + x.PcDetailUrl,
                            sales = x.Sales,
                            averageStar = x.AverageStar,
                            averageStarRate = x.AverageStarRate,
                            feedbacks = x.Feedbacks,
                            Id2 = x.Id
                        };
                        p.Images.Add(
                            new Image()
                            {
                                Src = x.Image640Url.Replace("_640x640.png", "").Replace("_640x640.jpg", "")
                            }
                            );

                        p.Variants.Add(new Variant()
                        {
                            Price = x.PromotionPiecePriceMoney.Amount.ToString()
                        });
                        //if (j == 0)
                        //    Console.WriteLine("title: " + p.Title);
                        pp.Add(p);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return pp;
        }

        string MakeValidJSON(string k, string callback)
        {
            k = k.Replace(callback + "(", "");
            return k.Substring(0, k.Length - 1);
        }

        string BuildURI(int page, int pageSize, string sellerId)
        {
            string baseUrl = "https://shoprenderview.aliexpress.com";
            string deviceId = "/lb7HRK2vyQCATptkLHZwpLi";
            string sortType = "bestmatch_sort";
            string componentKey = "allitems_choice";
            string country = "AU";
            string site = "glo";
            string groupId = "-1";
            string currency = "AUD";
            string locale = "en_US";
            string buyerId = "1906445420";
            string callback = "jsonp_1707798573906_94477";

            StringBuilder uriBuilder = new StringBuilder($"{baseUrl}/async/execute");
            uriBuilder.Append($"?componentKey={componentKey}&deviceId={deviceId}&SortType={sortType}");
            uriBuilder.Append($"&page={page}&pageSize={pageSize}");
            uriBuilder.Append($"&country={country}&site={site}&sellerId={sellerId}");
            uriBuilder.Append($"&groupId={groupId}&currency={currency}&locale={locale}&buyerId={buyerId}");
            uriBuilder.Append($"&callback={callback}");

            string worm2 = uriBuilder.ToString();

            return worm2;
        }
    }
}
