using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BaseApp.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public Category Category { get; set; } = null!;
        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
        public List<Image> Images { get; set; } = new List<Image>();
        public List<Promotion> Promotions { get; set; } = new List<Promotion>();
    }
}
