using EShopper.Catalog.Entities;
using EShopper.Catalog.Repositories;
using EShopper.Catalog.Settings;

namespace EShopper.Catalog.Services.ProductServices
{
    public class ProductService : Repository<Product>, IProductService
    {
        public ProductService(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
