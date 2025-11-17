using BaseApp.Application.Persistence;
using BaseApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Infrastructure.Persistance
{


    public class TodoRepository : ITodoRepository
    {
        private static readonly List<TodoItem> _todos = new();

        public Task<TodoItem> AddAsync(TodoItem item)
        {
            _todos.Add(item);
            return Task.FromResult(item);
        }

        public Task<IEnumerable<TodoItem>> GetByUserIdAsync(Guid userId)
        {
            var result = _todos.Where(t => t.UserId == userId);
            return Task.FromResult(result);
        }

        public Task CompleteTodoAsync(Guid todoId)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == todoId);
            if (todo != null)
            {
                todo.IsCompleted = true;
            }
            return Task.CompletedTask;
        }
        public Task<bool> DeleteAsync(Guid todoId)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == todoId);
            if (todo == null)
                return Task.FromResult(false);

            _todos.Remove(todo);
            return Task.FromResult(true);
        }
    }
}
    
