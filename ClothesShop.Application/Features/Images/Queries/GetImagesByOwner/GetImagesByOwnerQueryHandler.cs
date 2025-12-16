using MediatR;
using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Images.Queries.GetImagesByOwner;

public class GetImagesByOwnerQueryHandler
    : IRequestHandler<GetImagesByOwnerQuery, List<GetImagesByOwnerVm>>
{
    private readonly IRepository<Image> _repository;
    private readonly IMapper _mapper;

    public GetImagesByOwnerQueryHandler(
        IRepository<Image> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetImagesByOwnerVm>> Handle(
        GetImagesByOwnerQuery request,
        CancellationToken cancellationToken)
    {
        var images = await _repository.FindAsync(x =>
            x.ProductId == request.OwnerId ||
            x.ProductVariantId == request.OwnerId ||
            x.CategoryId == request.OwnerId ||
            x.PromotionId == request.OwnerId);

        return _mapper.Map<List<GetImagesByOwnerVm>>(images);
    }
}
