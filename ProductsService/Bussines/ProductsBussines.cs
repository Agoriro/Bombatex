using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifySharp;
using System.Configuration;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using ShopifySharp.Utilities;

namespace ProductsService.Bussines
{
    public class ProductsBussines
    {
        string shopifyUrl = string.Empty;
        string apiKey = string.Empty;
        public ProductsBussines()
        {
            this.shopifyUrl = ConfigurationManager.AppSettings["ShopifyUrl"];
            this.apiKey = ConfigurationManager.AppSettings["ApiKey"];
        }

        public async Task<string> getArticleListAsync()
        {
            var service = new BlogService(shopifyUrl, apiKey);
            var blogs = await service.ListAsync();

            var serviceProduct = new ProductService(shopifyUrl, apiKey);
            int productCount = await serviceProduct.CountAsync();


            var serviceList = new ProductService(shopifyUrl, apiKey);
            var products = await serviceList.ListAsync();

            //Optionally filter the results
            //var filter = new ProductFilterOptions()
            //{
            //    Ids = new[]
            //    {
            //        productId1,
            //        productId2,
            //        productId3
            //    }
            //};
            //products = await serviceList.ListAsync(filter);

            return string.Empty;
        }

    }
}
