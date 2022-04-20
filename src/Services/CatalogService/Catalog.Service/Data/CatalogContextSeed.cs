using Catalog.Service.Entities;
using MongoDB.Driver;

namespace Catalog.Service.Data
{
	public class CatalogContextSeed
	{
		public static void SeedData(IMongoCollection<Product> productCollection)
		{
			bool isCollectionExists = productCollection.Find(x => true).Any();
			if(!isCollectionExists)
			{
				productCollection.InsertManyAsync(GetPreConfiguredProducts());
			}
        }

		private static IEnumerable<Product> GetPreConfiguredProducts()
		{
            return new List<Product>()
            {
                new Product()
                {
                    Id = "625efde0fc13ae41b000003a",
                    Name = "Electrician",
                    Category = "Home Repairs",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 225.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003b",
                    Name = "Carpenter",
                    Category = "Home Repairs",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 275.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003c",
                    Name = "Plumber",
                    Category = "Home Repairs",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 235.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003d",
                    Name = "Painter",
                    Category = "Home Utility",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 325.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003e",
                    Name = "Cleaner",
                    Category = "Home Utility",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 205.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003f",
                    Name = "Pest Control",
                    Category = "Home Utility",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 125.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003g",
                    Name = "Spa",
                    Category = "Personal Care",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 525.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003h",
                    Name = "Salon",
                    Category = "Personal Care",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 95.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003i",
                    Name = "Therapist",
                    Category = "Personal Care",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 425.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003j",
                    Name = "Yoga Trainer",
                    Category = "Health",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 185.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003k",
                    Name = "Doctor",
                    Category = "Health",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 125.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003l",
                    Name = "AC Servicing",
                    Category = "Appliance Repair",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 345.50M
                },
                new Product()
                {
                    Id = "625efde0fc13ae41b000003m",
                    Name = "TV/Refrigerator Servicing",
                    Category = "Appliance Repair",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eget lectus non justo mattis accumsan in sed magna.",
                    Description = "Sed deserunt esse qui consequatur consequatur sed sint saepe aut quam dolores qui aliquam omnis et aliquid vero eos esse cumque? Qui quis magni 33 ipsa amet non dignissimos fugiat 33 saepe possimus et animi voluptas eos debitis magnam est dolorem vero. Hic iure neque non voluptatem alias et nihil optio ut perspiciatis natus et nemo minus qui quod doloribus.",
                    ImageFile = "product-1.png",
                    Price = 265.50M
                }
            };
        }
	}
}
