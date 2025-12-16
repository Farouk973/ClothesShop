namespace ClothesShop.Domain.Entities
{
    public class Video : BaseEntity
    {
        public string Url { get; set; } = null!;
        public string? Title { get; set; }
        public string? Description { get; set; }

        public string? ProductId { get; set; }
        public string? PromotionId { get; set; }
    }
}
