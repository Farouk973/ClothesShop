using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Application.Feature.ToDos.Queries.GetByUserId
{
    public class GetByUserIdQuery : IRequest<List<GetByUserIdVm>>
    {
        public GetByUserIdQuery(Guid userId)
        {
            UserId = userId;
        }

        public Guid UserId { get; set; }
    }
}
