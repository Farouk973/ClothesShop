using MediatR;
using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using ClothesShop.Entities;

namespace ClothesShop.Application.Features.Promotions.Commands.CreatePromotion;

public class CreatePromotionCommandHandler
    : IRequestHandler<CreatePromotionCommand, string>
{
    private readonly IRepository<Promotion> _repository;
    private readonly IMapper _mapper;

    public CreatePromotionCommandHandler(
        IRepository<Promotion> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<string> Handle(
        CreatePromotionCommand request,
        CancellationToken cancellationToken)
    {
        var promotion = _mapper.Map<Promotion>(request);
        promotion.Id = Guid.NewGuid().ToString();

        await _repository.AddAsync(promotion);
        return promotion.Id;
    }
}
