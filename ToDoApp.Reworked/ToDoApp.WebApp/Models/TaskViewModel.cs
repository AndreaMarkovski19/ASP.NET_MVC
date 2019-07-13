using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain.Enums;
using ToDoApp.Domain.Models;
using Type = ToDoApp.Domain.Enums.Type;

namespace ToDoApp.WebApp.Models
{
    public class TaskViewModel
    {
        public int Id { get; set; }        
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public Type Type { get; set; }
        public List<SubTaskViewModel> SubTasks { get; set; } = new List<SubTaskViewModel>();
    }
}
