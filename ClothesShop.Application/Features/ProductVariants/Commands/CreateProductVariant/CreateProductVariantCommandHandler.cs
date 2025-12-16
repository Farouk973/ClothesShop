using MediatR;
using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.ProductVariants.Commands.CreateProductVariant;

public class CreateProductVariantCommandHandler
    : IRequestHandler<CreateProductVariantCommand, string>
{
    private readonly IRepository<ProductVariant> _repository;
    private readonly IMapper _mapper;

    public CreateProductVariantCommandHandler(
        IRepository<ProductVariant> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<string> Handle(
        CreateProductVariantCommand request,
        CancellationToken cancellationToken)
    {
        var variant = _mapper.Map<ProductVariant>(request);
        variant.Id = Guid.NewGuid().ToString();

        await _repository.AddAsync(variant);
        return variant.Id;
    }
}
