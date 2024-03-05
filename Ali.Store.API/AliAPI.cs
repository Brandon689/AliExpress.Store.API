using GlobalProduct.ProductJSON;
using System.Text;
using System.Text.Json;

namespace Ali.Store.API
{
    public class AliAPI
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public AliAPI()
        {

        }

        public async ValueTask<List<Product>> GetProductPage(string sellerId, int pg, int perPage)
        {
            List<Product> pp = new List<Product>();
            var endpoint = BuildURI(pg, perPage, sellerId);
            var xo = await _httpClient.GetStringAsync(endpoint.Item2);
            xo = MakeValidJSON(xo, "jsonp_" + endpoint.Item1);
            var g = JsonSerializer.Deserialize<AliProduct>(xo);
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

        //public async ValueTask<List<Product>> GetProductList(string sellerId, bool abort = false)
        //{
        //    List<Product> pp = new List<Product>();
        //    int max = 2;
        //    if (abort) max = 1;
        //    for (int i = 1; i <= max; i++)
        //    {
        //        var xo = await _httpClient.GetStringAsync(BuildURI(i, 30, sellerId));
        //        xo = MakeValidJSON(xo, callback);
        //        //File.WriteAllText("../../h.json", xo);
        //        var g = JsonSerializer.Deserialize<AliProduct>(xo);
        //        if (i == 1 && abort == false)
        //            max = (int)g.Result.Products.TotalPage;
        //        try
        //        {
        //            for (int j = 0; j < g.Result.Products.Data.Count; j++)
        //            {
        //                var x = g.Result.Products.Data[j];
        //                Product p = new()
        //                {
        //                    Title = x.Subject,
        //                    Images = new(),
        //                    Variants = new(),
        //                    Currency = x.PromotionPiecePriceMoney.Currency,
        //                    Url = "https:" + x.PcDetailUrl,
        //                    sales = x.Sales,
        //                    averageStar = x.AverageStar,
        //                    averageStarRate = x.AverageStarRate,
        //                    feedbacks = x.Feedbacks,
        //                    Id2 = x.Id
        //                };
        //                p.Images.Add(
        //                    new Image()
        //                    {
        //                        Src = x.Image640Url.Replace("_640x640.png", "").Replace("_640x640.jpg", "")
        //                    }
        //                    );

        //                p.Variants.Add(new Variant()
        //                {
        //                    Price = x.PromotionPiecePriceMoney.Amount.ToString()
        //                });
        //                //if (j == 0)
        //                //    Console.WriteLine("title: " + p.Title);
        //                pp.Add(p);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex);
        //        }
        //    }
        //    return pp;
        //}

        string MakeValidJSON(string k, string callback)
        {
            k = k.Replace(callback + "(", "");
            return k.Substring(0, k.Length - 1);
        }

        (string, string) BuildURI(int page, int pageSize, string sellerId)
        {
            string baseUrl = "https://shoprenderview.aliexpress.com";
            string sortType = "bestmatch_sort";
            string componentKey = "allitems_choice";
            string country = "AU";
            string site = "glo";
            string groupId = "-1";
            string currency = "AUD";
            string locale = "en_US";

            DateTimeOffset now = DateTimeOffset.UtcNow;

            string timestamp = ConvertToUnixTimestampMilliseconds(now).ToString();
            string callback = $"jsonp_{timestamp}";

            StringBuilder uriBuilder = new StringBuilder($"{baseUrl}/async/execute");
            uriBuilder.Append($"?componentKey={componentKey}&SortType={sortType}");
            uriBuilder.Append($"&page={page}&pageSize={pageSize}");
            uriBuilder.Append($"&country={country}&site={site}&sellerId={sellerId}");
            uriBuilder.Append($"&groupId={groupId}&currency={currency}&locale={locale}");
            uriBuilder.Append($"&callback={callback}");

            string worm2 = uriBuilder.ToString();

            return (timestamp, worm2);
        }

        static long ConvertToUnixTimestampMilliseconds(DateTimeOffset dateTime)
        {
            DateTimeOffset unixEpoch = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
            TimeSpan timeDifference = dateTime - unixEpoch;
            return (long)timeDifference.TotalMilliseconds;
        }
    }
}
