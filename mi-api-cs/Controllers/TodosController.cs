using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiApiCS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiApiCS.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        // GET: api/Todos
        [HttpGet]
        public IEnumerable<object> Get()
        {
            return TodoContext.Instance.Select();
        }

        // GET: api/Todos/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            return TodoContext.Instance.Select(id);
        }

        // POST: api/Todos
        [HttpPost]
        public object Post([FromBody] Todo value)
        {
            return TodoContext.Instance.Create(value);
        }

        // PUT: api/Todos/5
        [HttpPut("{id}")]
        public object Put(int id, [FromBody] Todo value)
        {
            return TodoContext.Instance.Update(value, id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public object Delete(int id)
        {
            return TodoContext.Instance.Delete(id);
        }
    }
}
