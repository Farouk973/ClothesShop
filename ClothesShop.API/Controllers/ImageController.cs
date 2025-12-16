using MediatR;
using Microsoft.AspNetCore.Mvc;
using ClothesShop.Application.Features.Images.Commands.CreateImage;
using ClothesShop.Application.Features.Images.Commands.DeleteImage;
using ClothesShop.Application.Features.Images.Queries.GetImagesByOwnerId;
using ClothesShop.Application.Features.Images.Queries.GetImagesByOwner;

namespace ClothesShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ImageController : ControllerBase
{
    private readonly IMediator _mediator;

    public ImageController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // CREATE
    [HttpPost]
    public async Task<IActionResult> Create(CreateImageCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }

    // DELETE
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new DeleteImageCommand { Id = id });
        return NoContent();
    }

    // GET BY OWNER ID
    [HttpGet("owner/{ownerId}")]
    public async Task<IActionResult> GetByOwnerId(string ownerId)
    {
        var result = await _mediator.Send(
            new GetImagesByOwnerQuery { OwnerId = ownerId });

        return Ok(result);
    }
}
