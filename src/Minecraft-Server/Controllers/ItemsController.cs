using Microsoft.AspNet.Mvc;
using Minecraft_Server.Data;

namespace Minecraft_Server.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : DBController<Item>
    {
        public ItemsController(ItemStore store) : base(store)
        {

        }
    }
}
