namespace ClothesShop.Domain.Entities
{
    public class Product : BaseEntity
    {

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public string Reference { get; set; } = null!; // Admin only
        public decimal CostPrice { get; set; }   // Price shop bought
        public decimal SellingPrice { get; set; } // Price customers pay

        public string CategoryId { get; set; } = null!;

        public bool ComingSoon { get; set; } = false;
        public bool InStock { get; set; } = true;

        public List<string> ImageIds { get; set; } = new(); // Product images

    }
}
