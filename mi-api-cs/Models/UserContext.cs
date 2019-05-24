using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiApiCS.Models
{
    public class UserContext : Resource
    {
        private static readonly UserContext instance = new UserContext();

        private UserContext()
        {
            Data.AddRange(new List<User>() {
                new User(1, "Edwin", "Salinas")
            });
        }
        public static UserContext Instance => instance;
    }
}
