using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ClothesShop.Application.Feature.ToDos.Commands.CreateToDo
{
    public class CreateTodoCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string Title { get; set; } = string.Empty;
    }
}
