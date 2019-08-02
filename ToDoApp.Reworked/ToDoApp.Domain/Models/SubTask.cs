using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ToDoApp.Domain.Enums;

namespace ToDoApp.Domain.Models
{
    public class SubTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }         
        public string Title { get; set; }
        public string Description { get; set; }
        public Task Task { get; set; }
        public int TaskId { get; set; }
        public SubStatus SubStatus { get; set; }
    }
}
