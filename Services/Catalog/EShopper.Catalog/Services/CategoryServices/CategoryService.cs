using EShopper.Catalog.Entities;
using EShopper.Catalog.Repositories;
using EShopper.Catalog.Settings;

namespace EShopper.Catalog.Services.CategoryServices
{
    public class CategoryService : Repository<Category>, ICategoryService
    {
        public CategoryService(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
