using BaseApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Application.Persistence
{
    public interface ITodoRepository
    {
        Task<TodoItem> AddAsync(TodoItem todoItem);
        Task<IEnumerable<TodoItem>> GetByUserIdAsync(Guid userId); 
        Task CompleteTodoAsync(Guid todoId);
        Task<bool> DeleteAsync(Guid todoId);
    }
}
