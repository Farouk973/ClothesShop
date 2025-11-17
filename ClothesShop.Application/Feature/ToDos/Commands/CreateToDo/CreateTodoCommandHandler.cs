using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseApp.Application.Persistence;
using BaseApp.Domain.Entities;
using MediatR;
namespace BaseApp.Application.Feature.ToDos.Commands.CreateToDo
{
    public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand, Guid>
    {
        private readonly ITodoRepository _todoRepository;

        public CreateTodoCommandHandler(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<Guid> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = new TodoItem
            {
                Title = request.Title,
                UserId = request.UserId
            };

            var created = await _todoRepository.AddAsync(todo);
            return created.Id;
        }
    }
}
