using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Domain.Abstractions;

namespace TodoApp.Domain.Entities
{
    public class User: BaseEntity
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhotoUrl { get; set; } = "";

        // Navigation property for related Todo items
        public ICollection<Todo> Todos { get; set; } = [];
    }
}
