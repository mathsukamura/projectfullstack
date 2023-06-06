using backendTODO.Viewmodels;
using System;

namespace backendTODO.Models
{
    public class TodoModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime created_at { get; set; } =DateTime.Now;

        public void AtualizaTodo(TodoViewModel viewModel)
        {
            if(viewModel == null)
            {
                return;
            }
            
            Title= viewModel.Title;
            Status= viewModel.Status;
        }
    }
}
