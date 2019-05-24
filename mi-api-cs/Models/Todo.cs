using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiApiCS.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        public Todo(int id, string title, string description, int userId)
        {
            Id = id;
            Title = title;
            Description = description;
            UserId = userId;
        }
    }
}
