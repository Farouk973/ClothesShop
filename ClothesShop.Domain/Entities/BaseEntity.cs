using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Domain.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        // Optional tags for search/filtering
        public List<string> Tags { get; set; } = new();
    }
}
