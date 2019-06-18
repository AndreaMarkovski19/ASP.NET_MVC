using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models.DomainModels.Enums;
using Type = ToDoApp.Models.DomainModels.Enums.Type;

namespace ToDoApp.Models.DomainModels
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public Type Type { get; set; }
        public List<SubTasks> SubTasks { get; set; } = new List<SubTasks>();
    }
}
