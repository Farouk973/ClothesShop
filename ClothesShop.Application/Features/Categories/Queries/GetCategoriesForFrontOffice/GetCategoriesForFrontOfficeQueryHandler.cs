using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using MediatR;

namespace ClothesShop.Application.Features.Categories.Queries.GetCategoriesForFrontOffice;

public class GetCategoriesForFrontOfficeQueryHandler
    : IRequestHandler<GetCategoriesForFrontOfficeQuery, List<GetCategoriesForFrontOfficeVm>>
{
    private readonly IRepository<Category> _repository;
    private readonly IMapper _mapper;

    public GetCategoriesForFrontOfficeQueryHandler(
        IRepository<Category> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetCategoriesForFrontOfficeVm>> Handle(
        GetCategoriesForFrontOfficeQuery request,
        CancellationToken cancellationToken)
    {
        var categories = await _repository.GetAllAsync();

        return _mapper.Map<List<GetCategoriesForFrontOfficeVm>>(categories);
    }
}
