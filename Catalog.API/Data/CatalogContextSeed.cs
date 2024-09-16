using Catalog.API.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (existProduct)
            {
                productCollection.InsertMany(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>
          {
            new Product()
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Name = "IPhone X",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent volutpat, risus a condimentum suscipit, sapien nisi faucibus justo, a congue justo lectus eget orci. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Cras eget ante sed leo placerat vehicula. Vivamus euismod, mauris vitae dictum placerat, risus odio efficitur risus, vel dapibus est nulla a odio. Nulla facilisi. Curabitur in viverra magna, et tristique nunc. Integer sit amet nunc velit. Integer euismod feugiat gravida. Duis eget neque sed lectus sodales viverra sit amet sed velit.\r\n",
                Image = "product-1.png",
                Price = 950.00M,
                Category = "Smart Phone"
            },
            new Product()
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Name = "Samsung Galaxy S21",
                Description = "Suspendisse potenti. Cras sit amet facilisis turpis. Vivamus ultricies lacus ac turpis consequat, id gravida ex fermentum. Donec placerat velit vel ipsum hendrerit, at suscipit erat pretium. Nam vitae velit ut libero tempus fermentum id ac lectus. Integer malesuada, lorem at fermentum dictum, nunc metus laoreet lectus, vel pulvinar est lacus in erat. Aliquam nec ultricies nisl.",
                Image = "product-2.png",
                Price = 899.99M,
                Category = "Smart Phone"
            }
          };
        }
    }
}
