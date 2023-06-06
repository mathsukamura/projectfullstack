using backendTODO.Service;
using backendTODO.Viewmodels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace backendTODO.Controllers
{
    [ApiController]
    [Route("v1/api")]
    public class TodoController : ControllerBase
    {
        private readonly ItodoService _todoService;

        public TodoController(ItodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("/todos")]
        public async Task<IActionResult> GetAsync()
        {
            var todo= await _todoService.GetAsync();

            return Ok(todo);
        }

        [HttpPost("/todos")]
        public async Task<IActionResult> PostAsync(TodoViewModel model)
        {
            var todo = await _todoService.PostAsync(model);

            return Created($"v1/professor/{todo.Id}", new { todo.Id});
        }

        [HttpPut("/todos/{id}")]
        public async Task<IActionResult> PutAsync(TodoViewModel model, int id)
        {
            var todo = await _todoService.PutAsync(model, id);

            if (todo == null)
            {
                return NotFound();
            }

            return Ok(todo);
        }

        [HttpDelete("/todos/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var todo = await _todoService.DeleteAsync(id);

            if (!todo)
            {
                return BadRequest("ocorreu erro inesperado");
            }

            return Ok(todo);
        }
    }
}
