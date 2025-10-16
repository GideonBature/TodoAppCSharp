using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Domain.Abstractions;

namespace TodoApp.Domain.Entities
{
    public class Todo : BaseEntity
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public bool IsCompleted { get; set; } = false;
        public DateTime DueDate { get; set; } = DateTime.UtcNow.AddDays(7);
        public string UserId { get; set; } = "";

        // Navigation property for the related User
        public User? User { get; set; }

    }
}
