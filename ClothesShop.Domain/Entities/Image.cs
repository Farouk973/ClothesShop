namespace ClothesShop.Domain.Entities
{
    public class Image : BaseEntity
    {
        public string Url { get; set; } = null!;
        public string? AltText { get; set; }

        public string? ProductId { get; set; }
        public string? ProductVariantId { get; set; }
        public string? CategoryId { get; set; }
        public string? PromotionId { get; set; }
    }
}
