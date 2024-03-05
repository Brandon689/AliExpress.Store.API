using GlobalProduct.ProductJSON;

namespace Ali.Store.API.Facade
{
    public class Facade
    {
        AliExpressItemSerializer AliExpressItemSerializer = new();
        Scrape scrape = new();

        public async ValueTask<Product> GetProduct(long id)
        {
            var g = await scrape.GetPage(id);
            return AliExpressItemSerializer.ToProduct(g);
        }
    }
}
