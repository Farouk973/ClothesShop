using MediatR;
using Microsoft.AspNetCore.Mvc;
using ClothesShop.Application.Features.ProductVariants.Commands.CreateProductVariant;
using ClothesShop.Application.Features.ProductVariants.Commands.UpdateProductVariant;
using ClothesShop.Application.Features.ProductVariants.Commands.DeleteProductVariant;
using ClothesShop.Application.Features.ProductVariants.Queries.GetVariantsByProduct;

namespace ClothesShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductVariantController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductVariantController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("product/{productId}")]
    public async Task<IActionResult> GetByProduct(string productId)
        => Ok(await _mediator.Send(new GetVariantsByProductQuery { ProductId = productId }));

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductVariantCommand command)
        => Ok(await _mediator.Send(command));

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, UpdateProductVariantCommand command)
    {
        command.Id = id;
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new DeleteProductVariantCommand { Id = id });
        return NoContent();
    }
}
