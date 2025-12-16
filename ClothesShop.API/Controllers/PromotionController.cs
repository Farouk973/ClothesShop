using MediatR;
using Microsoft.AspNetCore.Mvc;
using ClothesShop.Application.Features.Promotions.Commands.CreatePromotion;
using ClothesShop.Application.Features.Promotions.Commands.UpdatePromotion;
using ClothesShop.Application.Features.Promotions.Commands.DeletePromotion;
using ClothesShop.Application.Features.Promotions.Queries.GetActivePromotions;
using ClothesShop.Application.Features.Promotions.Queries.GetPromotionById;

namespace ClothesShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PromotionController : ControllerBase
{
    private readonly IMediator _mediator;

    public PromotionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // FRONT OFFICE
    [HttpGet("active")]
    public async Task<IActionResult> GetActive()
        => Ok(await _mediator.Send(new GetActivePromotionsQuery()));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
        => Ok(await _mediator.Send(new GetPromotionByIdQuery { Id = id }));

    // ADMIN
    [HttpPost]
    public async Task<IActionResult> Create(CreatePromotionCommand command)
        => Ok(await _mediator.Send(command));

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, UpdatePromotionCommand command)
    {
        command.Id = id;
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new DeletePromotionCommand { Id = id });
        return NoContent();
    }
}
