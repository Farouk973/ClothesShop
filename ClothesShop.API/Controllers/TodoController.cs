
using BaseApp.Application.Feature.ToDos.Commands.CreateToDo;
using BaseApp.Application.Feature.ToDos.Commands.DeleteToDo;
using BaseApp.Application.Feature.ToDos.Commands.UpdateToDo;
using BaseApp.Application.Feature.ToDos.Queries.GetByUserId;
using Microsoft.AspNetCore.Mvc;

namespace BaseApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
// [Authorize] // Uncomment this only after JWT Auth is configured
public class TodoController : ApiControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateTodoCommand command)
    {
        var result = await Mediator.Send(command);
        return Ok(result);
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetByUserId(Guid userId)
    {
        var query = new GetByUserIdQuery(userId);
        var result = await Mediator.Send(query);
        return Ok(result);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, UpdateTodoCommand command)
    {
        if (id != command.Id)
            return BadRequest("Mismatched ID");

        var result = await Mediator.Send(command);
        if (!result)
            return NotFound();

        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await Mediator.Send(new DeleteTodoCommand(id));
        if (!result)
            return NotFound();

        return NoContent();
    }
}
