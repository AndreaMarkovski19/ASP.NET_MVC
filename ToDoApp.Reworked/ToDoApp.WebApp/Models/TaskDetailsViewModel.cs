using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain.Enums;
using Type = ToDoApp.Domain.Enums.Type;

namespace ToDoApp.WebApp.Models
{
    public class TaskDetailsViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [Display(Name = "Title of the Task")]
        public string Title { get; set; }
        [Display(Name = "Description of the Task")]
        public string Description { get; set; }
        [Display(Name = "Priority of the Task")]
        public Priority Priority { get; set; }
        [Display(Name = "Status of the Task")]
        public Status Status { get; set; }
        [Display(Name = "Type of the Task")]
        public Type Type { get; set; }
    }
}
