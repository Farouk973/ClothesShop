using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using MediatR;

namespace ClothesShop.Application.Features.Products.Queries.GetProductById;

public class GetProductByIdQueryHandler
    : IRequestHandler<GetProductByIdQuery, GetProductByIdVm>
{
    private readonly IRepository<Product> _repository;
    private readonly IMapper _mapper;

    public GetProductByIdQueryHandler(
        IRepository<Product> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetProductByIdVm> Handle(
        GetProductByIdQuery request,
        CancellationToken cancellationToken)
    {
        var product = await _repository.GetByIdAsync(request.Id);
        return _mapper.Map<GetProductByIdVm>(product);
    }
}
