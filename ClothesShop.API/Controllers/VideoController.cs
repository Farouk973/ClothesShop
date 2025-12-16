using MediatR;
using Microsoft.AspNetCore.Mvc;
using ClothesShop.Application.Features.Videos.Commands.CreateVideo;
using ClothesShop.Application.Features.Videos.Commands.DeleteVideo;
using ClothesShop.Application.Features.Videos.Queries.GetVideosByOwner;
using ClothesShop.Application.Features.Videos.Queries.GetVideoById;

namespace ClothesShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VideoController : ControllerBase
{
    private readonly IMediator _mediator;

    public VideoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // CREATE
    [HttpPost]
    public async Task<IActionResult> Create(CreateVideoCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }

    // DELETE
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new DeleteVideoCommand { Id = id });
        return NoContent();
    }

    // GET BY OWNER ID (Product or Promotion)
    [HttpGet("owner/{ownerId}")]
    public async Task<IActionResult> GetByOwnerId(string ownerId)
    {
        var result = await _mediator.Send(
            new GetVideosByOwnerQuery { OwnerId = ownerId });

        return Ok(result);
    }
    // GET BY ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var result = await _mediator.Send(new GetVideoByIdQuery { Id = id });
        return Ok(result);
    }
}
