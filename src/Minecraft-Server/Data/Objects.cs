using Minecraft_Server.Data;

namespace Minecraft_Server.Controllers
{
    public class Recipe : IHaveId
    {
        public string Id { get; set; }
        public string[,] Input { get; set; }
        public string Output { get; set; }
        public bool Shaped { get; set; }
    }

    public class Item : IHaveId
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string WikiUrl { get; set; }
        public int? Hardness { get; set; }
        public int? Durability { get; set; }
        public Stackable Stackability { get; set; }
        public string CraftingId { get; internal set; }

        public Item()
        {
            Stackability = Stackable.Standard;
        }
    }

    public enum ItemType
    {
        SolidBlock,
        RawMaterial,
        Tool
    }

    public struct Stackable
    {
        public static readonly Stackable Standard = new Stackable
        {
            CanStack = true,
            Size = 64
        };

        public static readonly Stackable NotStackable = new Stackable
        {
            CanStack = false,
            Size = 0
        };

        public bool CanStack { get; set; }
        public int Size { get; set; }
    }
}