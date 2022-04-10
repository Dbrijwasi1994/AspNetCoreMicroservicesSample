using Catalog.Service.Entities;
using MongoDB.Driver;

namespace Catalog.Service.Data
{
	public interface ICatalogContext
	{
		IMongoCollection<Product> Products { get; }	
	}
}
