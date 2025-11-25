//using ClothesShop.Application.Common.Exceptions;
//using ClothesShop.Application.Persistence;
//using ClothesShop.Domain.Entities;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClothesShop.Application.Feature.Users.Commands.DeleteUser
//{
//    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
//    {
//        private readonly IUserRepository _userRepository;

//        public DeleteUserCommandHandler(IUserRepository userRepository)
//        {
//            _userRepository = userRepository;
//        }

//        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
//        {
//            var user = await _userRepository.GetByIdAsync(request.Id);
//            if (user == null)
//                throw new NotFoundException(nameof(User), request.Id);

//            await _userRepository.DeleteAsync(user.Id);

//            return Unit.Value;
//        }

       
//    }
//}
