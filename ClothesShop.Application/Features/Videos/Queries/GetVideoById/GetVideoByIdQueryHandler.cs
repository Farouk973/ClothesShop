using MediatR;
using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Videos.Queries.GetVideoById;

public class GetVideoByIdQueryHandler
    : IRequestHandler<GetVideoByIdQuery, GetVideoByIdVm>
{
    private readonly IRepository<Video> _repository;
    private readonly IMapper _mapper;

    public GetVideoByIdQueryHandler(
        IRepository<Video> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetVideoByIdVm> Handle(
        GetVideoByIdQuery request,
        CancellationToken cancellationToken)
    {
        var video = await _repository.GetByIdAsync(request.Id);
        if (video == null)
            throw new KeyNotFoundException("Video not found");

        return _mapper.Map<GetVideoByIdVm>(video);
    }
}
