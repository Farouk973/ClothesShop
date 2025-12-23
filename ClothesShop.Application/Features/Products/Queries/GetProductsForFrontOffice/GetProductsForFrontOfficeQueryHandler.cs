using AutoMapper;
using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Application.Common.Models;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Products.Queries.GetProductsForFrontOffice;

public class GetProductsForFrontOfficeQueryHandler
    : IRequestHandler<GetProductsForFrontOfficeQuery, PaginatedResult<GetProductsForFrontOfficeVm>>
{
    private readonly IRepository<Product> _repository;
    private readonly IMapper _mapper;

    public GetProductsForFrontOfficeQueryHandler(
        IRepository<Product> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedResult<GetProductsForFrontOfficeVm>> Handle(
        GetProductsForFrontOfficeQuery request,
        CancellationToken cancellationToken)
    {
        var (items, totalCount) = await _repository.GetPagedAsync(
            _ => true,
            request.Pagination.Skip,
            request.Pagination.PageSize);

        return new PaginatedResult<GetProductsForFrontOfficeVm>
        {
            Items = _mapper.Map<List<GetProductsForFrontOfficeVm>>(items),
            PageNumber = request.Pagination.PageNumber,
            PageSize = request.Pagination.PageSize,
            TotalCount = totalCount
        };
    }
}
