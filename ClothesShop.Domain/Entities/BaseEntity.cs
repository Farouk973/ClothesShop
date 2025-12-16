using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ClothesShop.Domain.Entities
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public List<string> Tags { get; set; } = new(); // For filtering/searching
    }
}
