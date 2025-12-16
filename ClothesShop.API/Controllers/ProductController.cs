using MediatR;
using Microsoft.AspNetCore.Mvc;
using ClothesShop.Application.Features.Products.Commands.CreateProduct;
using ClothesShop.Application.Features.Products.Commands.UpdateProduct;
using ClothesShop.Application.Features.Products.Commands.DeleteProduct;
using ClothesShop.Application.Features.Products.Queries.GetProductById;
using ClothesShop.Application.Features.Products.Queries.GetProductsByCategory;
using ClothesShop.Application.Features.Products.Queries.GetProductsForFrontOffice;

namespace ClothesShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // FRONT OFFICE – product cards
    [HttpGet("front")]
    public async Task<IActionResult> GetForFrontOffice()
        => Ok(await _mediator.Send(new GetProductsForFrontOfficeQuery()));

    // FRONT OFFICE – products by category
    [HttpGet("category/{categoryId}")]
    public async Task<IActionResult> GetByCategory(string categoryId)
        => Ok(await _mediator.Send(new GetProductsByCategoryQuery { CategoryId = categoryId }));

    // FULL DETAILS (admin + product page)
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
        => Ok(await _mediator.Send(new GetProductByIdQuery { Id = id }));

    // ADMIN
    [HttpPost]
    public async Task<IActionResult> Create(CreateProductCommand command)
        => Ok(await _mediator.Send(command));

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, UpdateProductCommand command)
    {
        command.Id = id;
        return Ok(await _mediator.Send(command));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _mediator.Send(new DeleteProductCommand { Id = id });
        return NoContent();
    }
}
