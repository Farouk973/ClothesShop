using MediatR;
using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Videos.Commands.CreateVideo;

public class CreateVideoCommandHandler
    : IRequestHandler<CreateVideoCommand, string>
{
    private readonly IRepository<Video> _repository;
    private readonly IMapper _mapper;

    public CreateVideoCommandHandler(
        IRepository<Video> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<string> Handle(
        CreateVideoCommand request,
        CancellationToken cancellationToken)
    {
        var video = _mapper.Map<Video>(request);
        video.Id = Guid.NewGuid().ToString();

        await _repository.AddAsync(video);
        return video.Id;
    }
}
