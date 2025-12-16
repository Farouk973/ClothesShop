using MediatR;
using AutoMapper;
using ClothesShop.Application.Common.Interfaces;
using ClothesShop.Domain.Entities;

namespace ClothesShop.Application.Features.Images.Commands.CreateImage;

public class CreateImageCommandHandler
    : IRequestHandler<CreateImageCommand, string>
{
    private readonly IRepository<Image> _repository;
    private readonly IMapper _mapper;

    public CreateImageCommandHandler(
        IRepository<Image> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<string> Handle(
        CreateImageCommand request,
        CancellationToken cancellationToken)
    {
        var image = _mapper.Map<Image>(request);
        image.Id = Guid.NewGuid().ToString();

        await _repository.AddAsync(image);
        return image.Id;
    }
}
