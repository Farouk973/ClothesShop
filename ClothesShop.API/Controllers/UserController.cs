using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using BaseApp.Application.Feature.Users.Commands.CreateUser;
using BaseApp.Application.Feature.Users.Queries.GetUserById;
using BaseApp.Application.Feature.Users.Queries.GetUserList;
using BaseApp.Application.Feature.Users.Commands.DeleteUser;
using BaseApp.Application.Feature.Users.Commands.UpdateUser;

namespace BaseApp.API.Controllers
{
    public class UserController : ApiControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register(CreateUserCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await Mediator.Send(new GetUserByIdQuery(id));
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await Mediator.Send(new GetUserListQuery());
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateUserCommand command)
        {
            if (id != command.Id) return BadRequest("Id mismatch");

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await Mediator.Send(new DeleteUserCommand { Id = id });
            return NoContent();
        }
    }
}
