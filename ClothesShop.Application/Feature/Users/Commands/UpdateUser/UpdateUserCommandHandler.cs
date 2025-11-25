//using ClothesShop.Application.Common.Exceptions;
//using ClothesShop.Application.Persistence;
//using ClothesShop.Domain.Entities;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClothesShop.Application.Feature.Users.Commands.UpdateUser
//{
//    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
//    {
//        private readonly IUserRepository _userRepository;

//        public UpdateUserCommandHandler(IUserRepository userRepository)
//        {
//            _userRepository = userRepository;
//        }

//        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
//        {
//            var user = await _userRepository.GetByIdAsync(request.Id);
//            if (user == null)
//                throw new NotFoundException(nameof(User), request.Id);

//            if (!string.IsNullOrEmpty(request.Username))
//                user.Username = request.Username;

//            if (!string.IsNullOrEmpty(request.Password))
//                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

//            await _userRepository.UpdateAsync(user);

//            return Unit.Value;
//        }

       
//    }
//}
