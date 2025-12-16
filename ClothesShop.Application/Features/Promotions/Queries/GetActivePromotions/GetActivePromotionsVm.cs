namespace ClothesShop.Application.Features.Promotions.Queries.GetActivePromotions;

public class GetActivePromotionsVm
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public List<string> ImageIds { get; set; } = new();
}
