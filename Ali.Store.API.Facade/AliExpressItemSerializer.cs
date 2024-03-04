using GlobalProduct.ProductJSON;
using Ali.Store.API.Models;
using GlobalProduct;

namespace Ali.Store.API.Facade
{
    public class AliExpressItemSerializer
    {
        public Product ToProduct(AliexpressItem g)
        {
            if (g.SkuComponent.ProductSKUPropertyList != null)
            {
                List<string> uniqueIds = g.PriceComponent?.SkuPriceList.Select(fog => fog.SkuPropIds).ToList();
                List<Variant> variants = new List<Variant>();
                List<Option> options = new List<Option>();

                List<Image> images = new();
                foreach (var item in g.ImageComponent.ImagePathList)
                {
                    Image image = new()
                    {
                        Src = item,
                        Name = Util.GetAltImageName(item),
                        VariantIds = new()
                    };
                    images.Add(image);
                }

                if (uniqueIds != null)
                {
                    if (uniqueIds[0].Contains(','))
                    {
                        foreach (var id in uniqueIds)
                        {
                            string[] arr = id.Split(',');
                            string id1 = arr[0];
                            string id2 = arr[1];

                            var sku = g.PriceComponent?.SkuPriceList.FirstOrDefault(f => f.SkuPropIds == id);
                            var pv1 = g.SkuComponent?.ProductSKUPropertyList[0].SkuPropertyValues.FirstOrDefault(x => x.PropertyValueId.ToString() == id1);
                            var pv2 = g.SkuComponent?.ProductSKUPropertyList[1].SkuPropertyValues.FirstOrDefault(x => x.PropertyValueId.ToString() == id2);

                            var variant = new Variant
                            {
                                Price = sku?.SkuVal.SkuAmount.Value.ToString(),
                                Id2 = long.Parse(id),
                                Option1 = pv1?.PropertyValueName,
                                Option2 = pv2?.PropertyValueName
                            };
                            string img = pv1.SkuPropertyImagePath.Replace("_640x640.jpg", "");
                            if (!string.IsNullOrEmpty(img))
                            {
                                bool exists = false;
                                for (int i = 0; i < images.Count; i++)
                                {
                                    if (images[i].Src == img)
                                    {
                                        exists = true;
                                        images[i].Id2 = variant.Id2;
                                        images[i].VariantIds.Add(variant.Id2);
                                        variant.ImageId = variant.Id2;
                                    }
                                }
                                if (!exists)
                                {
                                    Image image = new()
                                    {
                                        Src = img,
                                        Name = Util.GetAltImageName(img),
                                        Id2 = variant.Id2,
                                        VariantIds = new List<long>()
                                        {
                                            variant.Id2
                                        }
                                    };
                                    images.Add(image);
                                }
                            }
                            variants.Add(variant);
                        }

                        foreach (var item in g.SkuComponent.ProductSKUPropertyList)
                        {
                            options.Add(new Option
                            {
                                Id2 = item.SkuPropertyId,
                                Name = item.SkuPropertyName,
                                Values = item.SkuPropertyValues.Select(x => x.PropertyValueName).ToList(),
                                Position = item.Order
                            });
                        }
                    }
                    else
                    {
                        foreach (var id in uniqueIds.Distinct())
                        {
                            var sku = g.PriceComponent?.SkuPriceList.FirstOrDefault(f => f.SkuPropIds == id);
                            //var smog1 = g.SkuComponent?.ProductSKUPropertyList[0].Select(x => x.SkuPropertyValues).FirstOrDefault(s => s.PropertyValueId.ToString() == id);
                            var pv1 = g.SkuComponent?.ProductSKUPropertyList[0].SkuPropertyValues.FirstOrDefault(s => s.PropertyValueId.ToString() == id);
                            
                            var variant = new Variant
                            {
                                Title = pv1?.PropertyValueDisplayName,
                                Option1 = pv1?.PropertyValueName,
                                //ImageId = img.Id2,
                                Price = sku?.SkuVal.SkuAmount.Value.ToString(),
                                CompareAtPrice = sku?.SkuVal.SkuActivityAmount.Value.ToString(),
                                Id2 = long.Parse(id)
                            };
                            string img = pv1.SkuPropertyImagePath.Replace("_640x640.jpg", "");
                            if (!string.IsNullOrEmpty(img))
                            {
                                bool exists = false;
                                for (int i = 0; i < images.Count; i++)
                                {
                                    if (images[i].Src == img)
                                    {
                                        exists = true;
                                        images[i].Id2 = variant.Id2;
                                        images[i].VariantIds.Add(variant.Id2);
                                        variant.ImageId = variant.Id2;
                                    }
                                }
                                if (!exists)
                                {
                                    Image image = new()
                                    {
                                        Src = img,
                                        Name = Util.GetAltImageName(img),
                                        Id2 = variant.Id2,
                                        VariantIds = new List<long>()
                                        {
                                            variant.Id2
                                        }
                                    };
                                    images.Add(image);
                                }
                            }
                            variants.Add(variant);
                        }
                        foreach (var item in g.SkuComponent.ProductSKUPropertyList)
                        {
                            options.Add(new Option
                            {
                                Id2 = item.SkuPropertyId,
                                Name = item.SkuPropertyName,
                                Values = item.SkuPropertyValues.Select(x => x.PropertyValueName).ToList(),
                                Position = item.Order
                            });
                        }
                    }
                }
                Product p = new Product
                {
                    Id2 = g.ProductInfoComponent.Id,
                    Title = g.ProductInfoComponent.Subject,
                    wishListCount = g.WishListComponent.ItemWishedCount,
                    Images = images,
                    Variants = variants,
                    Options = options,
                    Shop = new Shop
                    {
                        Name = g.SellerComponent.StoreName,
                        Url = g.SellerComponent.StoreURL
                    },
                    Channel = new Channel
                    {
                        Name = "AliExpress"
                    }
                };
                return p;
            }
            else
            {
                List<string> uniqueIds = g.PriceComponent?.SkuPriceList.Select(fog => fog.SkuPropIds).ToList();
                List<Variant> variants = new List<Variant>();
                List<Option> options = new List<Option>();

                List<Image> images = new();
                foreach (var item in g.ImageComponent.ImagePathList)
                {
                    Image image = new()
                    {
                        Src = item,
                        Name = Util.GetAltImageName(item),
                    };
                    images.Add(image);
                }

                var variant = new Variant
                {
                    CompareAtPrice = g.PriceComponent.DiscountPrice.MinActivityAmount.Value.ToString(),
                    Price = g.PriceComponent.OrigPrice.MinAmount.Value.ToString(),
                    //Id2 = long.Parse(id)
                };
                variants.Add(variant);
                //foreach (var item in g.SkuComponent.ProductSKUPropertyList)
                //{
                //    options.Add(new Option
                //    {
                //        Id2 = item.SkuPropertyId,
                //        Name = item.SkuPropertyName,
                //        Values = item.SkuPropertyValues.Select(x => x.PropertyValueName).ToList(),
                //        Position = item.Order
                //    });
                //}

                Product p = new()
                {
                    Id2 = g.ProductInfoComponent.Id,
                    //AliExpressId = g.ProductInfoComponent.Id,
                    Title = g.ProductInfoComponent.Subject,
                    wishListCount = g.WishListComponent.ItemWishedCount,
                    Images = images,
                    Variants = variants,
                    Options = options,
                    Shop = new Shop
                    {
                        Name = g.SellerComponent.StoreName,
                        Url = g.SellerComponent.StoreURL
                    },
                    Channel = new Channel
                    {
                        Name = "AliExpress"
                    }
                };
                return p;
            }
        }
    }
}