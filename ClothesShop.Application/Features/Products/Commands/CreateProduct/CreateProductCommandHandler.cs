using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using MediatR;

namespace ClothesShop.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommandHandler
    : IRequestHandler<CreateProductCommand, string>
{
    private readonly IRepository<Product> _repository;
    private readonly IMapper _mapper;

    public CreateProductCommandHandler(
        IRepository<Product> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<string> Handle(
        CreateProductCommand request,
        CancellationToken cancellationToken)
    {
        var product = _mapper.Map<Product>(request);
        product.Id = Guid.NewGuid().ToString();

        await _repository.AddAsync(product);
        return product.Id;
    }
}
