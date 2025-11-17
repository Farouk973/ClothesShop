using AutoMapper;
using BaseApp.Application.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Application.Feature.ToDos.Commands.UpdateToDo
{
    public class UpdateTodoCommandHandler : IRequestHandler<UpdateTodoCommand, bool>
    {
        private readonly ITodoRepository _repo;
        private readonly IMapper _mapper;

        public UpdateTodoCommandHandler(ITodoRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateTodoCommand request, CancellationToken cancellationToken)
        {
            var todos = await _repo.GetByUserIdAsync(Guid.Empty); // You may want a `GetByIdAsync`
            var todo = todos.FirstOrDefault(t => t.Id == request.Id);

            if (todo == null)
                return false;

            todo.Title = request.Title;
            todo.IsCompleted = request.IsCompleted;

            return true; // no db persistence needed here since it's in-memory
        }
    }
}
