using MongoDB.Bson.Serialization.Attributes;

namespace EShopper.Catalog.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
    }
}
