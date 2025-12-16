using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using MediatR;

namespace ClothesShop.Application.Features.Products.Queries.GetProductsByCategory;

public class GetProductsByCategoryQueryHandler
    : IRequestHandler<GetProductsByCategoryQuery, List<GetProductsByCategoryVm>>
{
    private readonly IRepository<Product> _repository;
    private readonly IMapper _mapper;

    public GetProductsByCategoryQueryHandler(
        IRepository<Product> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetProductsByCategoryVm>> Handle(
        GetProductsByCategoryQuery request,
        CancellationToken cancellationToken)
    {
        var products = await _repository.FindAsync(
            x => x.CategoryId == request.CategoryId && x.InStock);

        return _mapper.Map<List<GetProductsByCategoryVm>>(products);
    }
}
