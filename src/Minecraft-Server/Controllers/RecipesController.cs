using Microsoft.AspNet.Mvc;
using Minecraft_Server.Data;

namespace Minecraft_Server.Controllers
{
    [Route("api/[controller]")]
    public class RecipesController : DBController<Recipe>
    {
        public RecipesController(RecipeStore store) : base(store)
        {
        }
    }
}
