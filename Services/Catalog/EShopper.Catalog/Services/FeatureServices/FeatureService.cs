using EShopper.Catalog.Entities;
using EShopper.Catalog.Repositories;
using EShopper.Catalog.Settings;

namespace EShopper.Catalog.Services.FeatureServices
{
    public class FeatureService : Repository<Feature>, IFeatureService
    {
        public FeatureService(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
