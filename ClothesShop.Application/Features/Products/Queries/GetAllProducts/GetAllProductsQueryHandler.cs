using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using MediatR;

namespace ClothesShop.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductsQueryHandler
    : IRequestHandler<GetAllProductsQuery, List<GetAllProductsVm>>
{
    private readonly IRepository<Product> _repository;
    private readonly IMapper _mapper;

    public GetAllProductsQueryHandler(
        IRepository<Product> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetAllProductsVm>> Handle(
        GetAllProductsQuery request,
        CancellationToken cancellationToken)
    {
        var products = await _repository.GetAllAsync();
        return _mapper.Map<List<GetAllProductsVm>>(products);
    }
}
