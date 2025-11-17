using AutoMapper;
using BaseApp.Application.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Application.Feature.ToDos.Queries.GetByUserId
{
    public class GetByUserIdQueryHandler : IRequestHandler<GetByUserIdQuery, List<GetByUserIdVm>>
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;

        public GetByUserIdQueryHandler(ITodoRepository todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        public async Task<List<GetByUserIdVm>> Handle(GetByUserIdQuery request, CancellationToken cancellationToken)
        {
            var todos = await _todoRepository.GetByUserIdAsync(request.UserId);
            return _mapper.Map<List<GetByUserIdVm>>(todos);
        }
    }
}
