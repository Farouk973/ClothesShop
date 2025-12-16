namespace ClothesShop.Application.Features.Images.Queries.GetImageById;

public class GetImageByIdVm
{
    public string Id { get; set; } = null!;
    public string Url { get; set; } = null!;
    public string? AltText { get; set; }
}
