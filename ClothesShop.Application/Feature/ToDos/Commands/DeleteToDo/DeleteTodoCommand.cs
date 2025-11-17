using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Application.Feature.ToDos.Commands.DeleteToDo
{
    public class DeleteTodoCommand : IRequest<bool>
    {
        public Guid Id { get; set; }

        public DeleteTodoCommand(Guid id)
        {
            Id = id;
        }
    }
}
