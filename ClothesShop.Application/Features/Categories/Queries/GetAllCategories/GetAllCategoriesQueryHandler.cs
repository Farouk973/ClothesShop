using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;
using MediatR;

namespace ClothesShop.Application.Features.Categories.Queries.GetAllCategories;

public class GetAllCategoriesQueryHandler
    : IRequestHandler<GetAllCategoriesQuery, List<GetAllCategoriesVm>>
{
    private readonly IRepository<Category> _categoryRepository;
    private readonly IMapper _mapper;

    public GetAllCategoriesQueryHandler(
        IRepository<Category> categoryRepository,
        IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllCategoriesVm>> Handle(
        GetAllCategoriesQuery request,
        CancellationToken cancellationToken)
    {
        var categories = await _categoryRepository.GetAllAsync();

        return _mapper.Map<List<GetAllCategoriesVm>>(categories);
    }
}
