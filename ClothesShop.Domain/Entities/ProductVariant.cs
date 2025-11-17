using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Domain.Entities
{
    public class ProductVariant : BaseEntity
    {
        public string Size { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int AvailableStock { get; set; }

        public List<Image> Images { get; set; } = new List<Image>();
    }
}
