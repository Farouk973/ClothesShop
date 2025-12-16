using MediatR;
using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Entities;

namespace ClothesShop.Application.Features.Promotions.Queries.GetActivePromotions;

public class GetActivePromotionsQueryHandler
    : IRequestHandler<GetActivePromotionsQuery, List<GetActivePromotionsVm>>
{
    private readonly IRepository<Promotion> _repository;
    private readonly IMapper _mapper;

    public GetActivePromotionsQueryHandler(
        IRepository<Promotion> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetActivePromotionsVm>> Handle(
        GetActivePromotionsQuery request,
        CancellationToken cancellationToken)
    {
        var now = DateTime.UtcNow;

        var promotions = await _repository.FindAsync(x =>
            x.StartDate <= now && x.EndDate >= now);

        return _mapper.Map<List<GetActivePromotionsVm>>(promotions);
    }
}
