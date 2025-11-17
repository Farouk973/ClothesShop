using AutoMapper;
using BaseApp.Application.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Application.Feature.Users.Queries.GetUserList
{
    public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, List<GetUserListVm>>
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;

        public GetUserListQueryHandler(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<GetUserListVm>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var users = await _repo.GetAllAsync();
            return _mapper.Map<List<GetUserListVm>>(users);
        }
    }
}
