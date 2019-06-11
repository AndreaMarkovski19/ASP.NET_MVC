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
        public string Title { get; set; } // task title
        public string Description { get; set; } // explaining the task
        public Priority Priority { get; set; } // the task importance
        public Status Status { get; set; } // if the task is done, not done or in progress
        public Type Type { get; set; } // what type of task it is
        public List<SubTasks> SubTasks { get; set; }        
    }
}
