using backendTODO.Models;
using System;

namespace backendTODO.Viewmodels
{
    public class TodoViewModel
    {
        public string Title { get; set; }
        public string Status { get; set; }

        public TodoModel CreateTodo()
        {
            return new TodoModel
            {
                Title = Title,
                Status = "",
            };
        }
    }
}
