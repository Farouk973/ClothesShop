using ClothesShop.Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClothesShop.API.Controllers;

[ApiController]
[Route("api/system")]
public class SystemController : ControllerBase
{
    private readonly IDatabaseSeeder _seeder;

    public SystemController(IDatabaseSeeder seeder)
    {
        _seeder = seeder;
    }

    [HttpPost("seed")]
    public async Task<IActionResult> SeedDatabase()
    {
        await _seeder.SeedAsync();
        return Ok("Database seeded successfully.");
    }
}
