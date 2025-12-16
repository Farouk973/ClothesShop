using MediatR;
using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Entities;

namespace ClothesShop.Application.Features.Promotions.Queries.GetPromotionById;

public class GetPromotionByIdQueryHandler
    : IRequestHandler<GetPromotionByIdQuery, GetPromotionByIdVm>
{
    private readonly IRepository<Promotion> _repository;
    private readonly IMapper _mapper;

    public GetPromotionByIdQueryHandler(
        IRepository<Promotion> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetPromotionByIdVm> Handle(
        GetPromotionByIdQuery request,
        CancellationToken cancellationToken)
    {
        var promotion = await _repository.GetByIdAsync(request.Id);
        if (promotion == null)
            throw new KeyNotFoundException("Promotion not found");

        return _mapper.Map<GetPromotionByIdVm>(promotion);
    }
}
