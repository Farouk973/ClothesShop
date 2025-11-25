//using AutoMapper;
//using ClothesShop.Application.Common.Exceptions;
//using ClothesShop.Application.Persistence;
//using ClothesShop.Domain.Entities;
//using MediatR;


//namespace ClothesShop.Application.Feature.Users.Queries.GetUserById
//{
//    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, GetUserByIdVm>
//    {
//        private readonly IUserRepository _userRepository;
//        private readonly IMapper _mapper;

//        public GetUserByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
//        {
//            _userRepository = userRepository;
//            _mapper = mapper;
//        }

//        public async Task<GetUserByIdVm> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
//        {
//            var user = await _userRepository.GetByIdAsync(request.Id);
//            if (user == null)
//                throw new NotFoundException(nameof(User), request.Id);

//            return _mapper.Map<GetUserByIdVm>(user);
//        }
//    }
//}
