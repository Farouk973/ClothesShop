using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Domain.Entities
{
    public class Promotion : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal DiscountAmount { get; set; } // could be percentage or fixed amount
        public bool IsPercentage { get; set; } = true;
        public bool IsActive { get; set; } = true;
    }
}

