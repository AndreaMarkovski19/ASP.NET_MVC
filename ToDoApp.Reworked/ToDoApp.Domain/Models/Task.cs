using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ToDoApp.Domain.Enums;
using Type = ToDoApp.Domain.Enums.Type;

namespace ToDoApp.Domain.Models
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }        
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public Type Type { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public List<SubTask> SubTasks { get; set; } = new List<SubTask>();
    }
}
