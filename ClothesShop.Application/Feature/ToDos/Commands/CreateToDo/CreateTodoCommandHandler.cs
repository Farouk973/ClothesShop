//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ClothesShop.Application.Persistence;
//using ClothesShop.Domain.Entities;
//using MediatR;
//namespace ClothesShop.Application.Feature.ToDos.Commands.CreateToDo
//{
//    public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand, Guid>
//    {
//        private readonly ITodoRepository _todoRepository;

//        public CreateTodoCommandHandler(ITodoRepository todoRepository)
//        {
//            _todoRepository = todoRepository;
//        }

//        public async Task<Guid> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
//        {
//            var todo = new TodoItem
//            {
//                Title = request.Title,
//                UserId = request.UserId
//            };

//            var created = await _todoRepository.AddAsync(todo);
//            return created.Id;
//        }
//    }
//}
