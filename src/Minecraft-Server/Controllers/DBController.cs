using Microsoft.AspNet.Mvc;
using Minecraft_Server.Data;
using System.Collections.Generic;

namespace Minecraft_Server.Controllers
{
    public class DBController<T> : Controller where T : IHaveId
    {
        public DBStore<T> Store { get; protected set; }

        public DBController(DBStore<T> store)
        {
            Store = store;
        }

        [HttpGet]
        public IEnumerable<T> Get()
        {
            return Store.Select();
        }

        [HttpGet("{id}")]
        public T Get(string id)
        {
            return Store.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]T value)
        {
            Store.Update(value);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Store.Delete(id);
        }
    }
}
