using MediatR;

namespace ClothesShop.Application.Features.ProductVariants.Queries.GetVariantsForFrontOffice;

public class GetVariantsForFrontOfficeQuery
    : IRequest<List<GetVariantsForFrontOfficeVm>>
{
    public string ProductId { get; set; } = null!;
}
