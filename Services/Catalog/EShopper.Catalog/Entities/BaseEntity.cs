using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EShopper.Catalog.Entities
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
