namespace ClothesShop.Application.Features.Videos.Queries.GetVideoById;

public class GetVideoByIdVm
{
    public string Id { get; set; } = null!;
    public string Url { get; set; } = null!;
    public string? Title { get; set; }
    public string? Description { get; set; }
}
