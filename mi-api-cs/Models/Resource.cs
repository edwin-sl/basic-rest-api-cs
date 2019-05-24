using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiApiCS.Models
{
    public class Resource
    {
        private List<dynamic> data = new List<object>();
        public List<object> Data { get => data; }

        public List<object> Select()
        {
            return data;
        }

        public object Select(int id)
        {
            return data.Find(e => e.Id == id);
        }

        public object Create(dynamic element)
        {
            var lastElement = data.Last();
            int id = lastElement == null ? 1 : lastElement.Id + 1;
            element.Id = id;
            data.Add(element);

            return element;
        }

        public object Update(dynamic element, int id)
        {
            var index = data.FindIndex(e => e.Id == id);
            element.Id = id;
            data[index] = element;

            return element;
        }

        public object Delete(int id)
        {
            var index = data.FindIndex(e => e.Id == id);
            var element = data[index];
            data.RemoveAt(index);

            return element;
        }
    }
}
