namespace ClothesShop.Domain.Entities
{
    public class ProductVariant : BaseEntity
    {
        public string ProductId { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Size { get; set; } = null!;
        public int Stock { get; set; }

        public List<string> ImageIds { get; set; } = new(); // Images per variant/color
    }
}
