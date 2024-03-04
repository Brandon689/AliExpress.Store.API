using GlobalProduct.ProductJSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Store.API.Facade
{
    public class Facade
    {
        AliExpressItemSerializer AliExpressItemSerializer = new();
        Scrape scrape = new();
        public async ValueTask<Product> A(long id)
        {
            var g = await scrape.GetPage(id);
            return AliExpressItemSerializer.ToProduct(g);
        }
    }
}
