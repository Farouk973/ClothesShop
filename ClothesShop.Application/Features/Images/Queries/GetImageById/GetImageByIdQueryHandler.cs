using MediatR;
using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Images.Queries.GetImageById;

public class GetImageByIdQueryHandler
    : IRequestHandler<GetImageByIdQuery, GetImageByIdVm>
{
    private readonly IRepository<Image> _repository;
    private readonly IMapper _mapper;

    public GetImageByIdQueryHandler(
        IRepository<Image> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetImageByIdVm> Handle(
        GetImageByIdQuery request,
        CancellationToken cancellationToken)
    {
        var image = await _repository.GetByIdAsync(request.Id);
        if (image == null)
            throw new KeyNotFoundException("Image not found");

        return _mapper.Map<GetImageByIdVm>(image);
    }
}
