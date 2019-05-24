using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiApiCS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiApiCS.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/Users
        [HttpGet]
        public IEnumerable<object> Get()
        {
            return UserContext.Instance.Select();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            return UserContext.Instance.Select(id);
        }

        // POST: api/Users
        [HttpPost]
        public object Post([FromBody] User value)
        {
            return UserContext.Instance.Create(value);
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public object Put(int id, [FromBody] string value)
        {
            return UserContext.Instance.Update(value, id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public object Delete(int id)
        {
            return UserContext.Instance.Delete(id);
        }
    }
}
