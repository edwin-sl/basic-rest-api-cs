using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiApiCS.Models
{
    public class TodoContext : Resource
    {
        private static readonly TodoContext instance = new TodoContext();

        private TodoContext()
        {
            Data.AddRange(new List<Todo>() {
                new Todo(1, "lunch", "go for lunch", 1)
            });
        }
        public static TodoContext Instance => instance;
    }
}
