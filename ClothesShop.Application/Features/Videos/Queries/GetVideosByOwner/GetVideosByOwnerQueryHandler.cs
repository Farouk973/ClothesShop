using MediatR;
using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Videos.Queries.GetVideosByOwner;

public class GetVideosByOwnerQueryHandler
    : IRequestHandler<GetVideosByOwnerQuery, List<GetVideosByOwnerVm>>
{
    private readonly IRepository<Video> _repository;
    private readonly IMapper _mapper;

    public GetVideosByOwnerQueryHandler(
        IRepository<Video> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetVideosByOwnerVm>> Handle(
        GetVideosByOwnerQuery request,
        CancellationToken cancellationToken)
    {
        var videos = await _repository.FindAsync(x =>
            x.ProductId == request.OwnerId ||
            x.PromotionId == request.OwnerId);

        return _mapper.Map<List<GetVideosByOwnerVm>>(videos);
    }
}
