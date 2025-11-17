using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Application.Feature.Users.Queries.GetUserById
{
    public class GetUserByIdVm
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
    }
}
