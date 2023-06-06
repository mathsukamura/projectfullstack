using backendTODO.Data;
using backendTODO.Models;
using backendTODO.Viewmodels;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backendTODO.Service
{
    public interface ItodoService
    {
        public Task<IList<TodoModel>> GetAsync();

        public Task<TodoModel> PostAsync(TodoViewModel model);

        public Task<TodoModel> PutAsync(TodoViewModel model, int id);

        public Task<bool> DeleteAsync(int id);
    }

    public class TodoService : ItodoService
    {
        private readonly Dbcontext _dbcontext;

        public TodoService(Dbcontext dbcontext) => _dbcontext = dbcontext;

        public async Task<IList<TodoModel>> GetAsync()
        {
            var todo = await _dbcontext.Todos.AsNoTracking().ToListAsync();

            return todo ;
        }

        public async Task<TodoModel> PostAsync(TodoViewModel model)
        {
            var todo = model.CreateTodo();

            await _dbcontext.AddAsync(todo);

            await _dbcontext.SaveChangesAsync();

            return todo ;
        }

        public async Task<TodoModel> PutAsync(TodoViewModel model, int id)
        {
            var todo = await _dbcontext.Todos.FindAsync(id);

            todo.AtualizaTodo(model);

            await _dbcontext.SaveChangesAsync();

            return todo ;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var todo = await _dbcontext.Todos.FindAsync(id);

            if(todo == null)
            {
                 return false;
            }

            _dbcontext.Todos.Remove(todo);

            await _dbcontext.SaveChangesAsync();

            return true;
        }
    }
}
