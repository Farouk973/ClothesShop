using AutoMapper;
using MediatR;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Images.Queries.GetImagesByOwnerId;

public class GetImagesByOwnerIdQueryHandler
    : IRequestHandler<GetImagesByOwnerIdQuery, List<GetImagesByOwnerIdVm>>
{
    private readonly IRepository<Image> _repository;
    private readonly IMapper _mapper;

    public GetImagesByOwnerIdQueryHandler(
        IRepository<Image> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetImagesByOwnerIdVm>> Handle(
        GetImagesByOwnerIdQuery request,
        CancellationToken cancellationToken)
    {
        var images = await _repository.FindAsync(i => i.Id == request.OwnerId);
        return _mapper.Map<List<GetImagesByOwnerIdVm>>(images);
    }
}
