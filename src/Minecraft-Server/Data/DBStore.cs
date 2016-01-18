using Minecraft_Server.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Minecraft_Server.Data
{
    public class DBStore<T> where T : IHaveId
    {
        public Dictionary<string, T> cache { get; set; }
        public long id = 0;

        public DBStore()
        {
            cache = new Dictionary<string, T>();
        }

        public void Insert(T obj)
        {
            cache.Add(obj.Id, obj);
        }

        public void Update(T obj)
        {
            cache[obj.Id] = obj;
        }

        public T GetById(string id)
        {
            return cache[id];
        }

        public IEnumerable<T> Select(Func<T, bool> predicate = null)
        {
            if (predicate == null)
            {
                return cache.Values;
            }
            return cache.Values.Where(predicate);
        }

        public T Delete(string id)
        {
            T result;
            if (cache.TryGetValue(id, out result))
            {
                cache.Remove(id);
            }
            return result;
        }
    }

    public class RecipeStore: DBStore<Recipe>
    {
        public RecipeStore()
        {
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:iron_pickaxe",
                Shaped = true,
                Input = new string[,] {
                    { "265:0", "265:0", "265:0"},
                    { null, "280:0", null},
                    { null, "280:0", null}
                },
                Output = "257:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:oak_wood_plank",
                Shaped = false,
                Input = new string[,] {
                    { null, "17:0", null},
                    { null, null, null},
                    { null, null, null}
                },
                Output = "5:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:spruce_wood_plank",
                Shaped = false,
                Input = new string[,] {
                    { null, "17:1", null},
                    { null, null, null},
                    { null, null, null}
                },
                Output = "5:1"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:stick1",
                Shaped = false,
                Input = new string[,] {
                    { null, "5:0", null},
                    { null, "5:0", null},
                    { null, null, null}
                },
                Output = "280:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:stick2",
                Shaped = false,
                Input = new string[,] {
                    { null, "5:1", null},
                    { null, "5:1", null},
                    { null, null, null}
                },
                Output = "280:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:stick3",
                Shaped = false,
                Input = new string[,] {
                    { null, "5:1", null},
                    { null, "5:0", null},
                    { null, null, null}
                },
                Output = "280:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:stick4",
                Shaped = false,
                Input = new string[,] {
                    { null, "5:0", null},
                    { null, "5:1", null},
                    { null, null, null}
                },
                Output = "280:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:wooden_axe",
                Shaped = true,
                Input = new string[,] {
                    { "5:0", "5:0", "5:0"},
                    { null, "280:0", null},
                    { null, "280:0", null}
                },
                Output = "271:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:wooden_axe1",
                Shaped = true,
                Input = new string[,] {
                    { "5:0", "5:1", "5:1"},
                    { null, "280:0", null},
                    { null, "280:0", null}
                },
                Output = "271:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:wooden_axe2",
                Shaped = true,
                Input = new string[,] {
                    { "5:0", "5:1", "5:0"},
                    { null, "280:0", null},
                    { null, "280:0", null}
                },
                Output = "271:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:wooden_axe3",
                Shaped = true,
                Input = new string[,] {
                    { "5:0", "5:0", "5:1"},
                    { null, "280:0", null},
                    { null, "280:0", null}
                },
                Output = "271:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:wooden_axe4",
                Shaped = true,
                Input = new string[,] {
                    { "5:1", "5:0", "5:0"},
                    { null, "280:0", null},
                    { null, "280:0", null}
                },
                Output = "271:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:wooden_axe5",
                Shaped = true,
                Input = new string[,] {
                    { "5:1", "5:1", "5:0"},
                    { null, "280:0", null},
                    { null, "280:0", null}
                },
                Output = "271:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:wooden_axe6",
                Shaped = true,
                Input = new string[,] {
                    { "5:1", "5:1", "5:1"},
                    { null, "280:0", null},
                    { null, "280:0", null}
                },
                Output = "271:0"
            });
            this.Insert(new Recipe
            {
                Id = "minecraft:recipe:wooden_axe7",
                Shaped = true,
                Input = new string[,] {
                    { "5:1", "5:0", "5:1"},
                    { null, "280:0", null},
                    { null, "280:0", null}
                },
                Output = "271:0"
            });
        }
    }

    public class ItemStore: DBStore<Item>
    {
        public ItemStore()
        {
            this.Insert(new Item
            {
                Name = "Oak Wood",
                Id = "17:0",
                CraftingId = "minecraft:wood",
                Description = "Wood, also known as logs, is a naturally occurring block found in trees, primarily used to create wood planks. It comes in six species: oak, birch, spruce, jungle, dark oak, and acacia.",
                Hardness = 2,
                ImageUrl = "http://www.minecraftinfo.com/images/179.png",
                Type = ItemType.SolidBlock,
                WikiUrl = "http://minecraft.gamepedia.com/Wood"
            });
            this.Insert(new Item
            {
                Name = "Spruce Wood",
                Id = "17:1",
                CraftingId = "minecraft:wood",
                Description = "Wood, also known as logs, is a naturally occurring block found in trees, primarily used to create wood planks. It comes in six species: oak, birch, spruce, jungle, dark oak, and acacia.",
                Hardness = 2,
                ImageUrl = "http://www.minecraftinfo.com/images/849.png",
                Type = ItemType.SolidBlock,
                WikiUrl = "http://minecraft.gamepedia.com/Wood"
            });
            this.Insert(new Item
            {
                Name = "Oak Wood Plank",
                Id = "5:0",
                CraftingId = "minecraft:plank",
                Description = "Wood Planks are common blocks used in many crafting recipes. Its texture resembles a network of planks, coming in six different shades obtained from the six different tree varieties.",
                Hardness = 2,
                ImageUrl = "http://www.minecraftinfo.com/images/170.png",
                Type = ItemType.SolidBlock,
                WikiUrl = "http://minecraft.gamepedia.com/Wood_planks"
            });
            this.Insert(new Item
            {
                Name = "Spruce Wood Plank",
                Id = "5:1",
                CraftingId = "minecraft:plank",
                Description = "Wood Planks are common blocks used in many crafting recipes. Its texture resembles a network of planks, coming in six different shades obtained from the six different tree varieties.",
                Hardness = 2,
                ImageUrl = "http://www.minecraftinfo.com/images/1269.png",
                Type = ItemType.SolidBlock,
                WikiUrl = "http://minecraft.gamepedia.com/Wood_planks"
            });
            this.Insert(new Item
            {
                Name = "Iron Ore",
                Id = "15:0",
                CraftingId = "minecraft:iron_ore",
                Description = "Iron ore is a mineral block found underground. It is the most common mineral that can be used to make tools and armor.",
                Hardness = 3,
                ImageUrl = "http://www.minecraftinfo.com/images/209.png",
                Type = ItemType.SolidBlock,
                WikiUrl = "http://minecraft.gamepedia.com/Iron_Ore"
            });
            this.Insert(new Item
            {
                Name = "Stick",
                Id = "280:0",
                CraftingId = "minecraft:stick",
                Description = "A stick is an item used for crafting many tools and items.",
                Hardness = null,
                ImageUrl = "http://www.minecraftinfo.com/images/167.png",
                Type = ItemType.RawMaterial,
                WikiUrl = "http://minecraft.gamepedia.com/Stick"
            });
            this.Insert(new Item
            {
                Name = "Iron Ingot",
                Id = "265:0",
                CraftingId = "minecraft:iron_ingot",
                Description = "Iron ingots are versatile metal crafting ingredients. They are most commonly obtained by smelting iron ore.",
                Hardness = null,
                ImageUrl = "http://www.minecraftinfo.com/images/146.png",
                Type = ItemType.RawMaterial,
                WikiUrl = "http://minecraft.gamepedia.com/Iron_Ingot"
            });
            this.Insert(new Item
            {
                Name = "Wooden Axe",
                Id = "271:0",
                CraftingId = "minecraft:wooden_axe",
                Description = "Axes are tools used to ease the process of collecting wood based items.",
                Hardness = null,
                Stackability = Stackable.NotStackable,
                ImageUrl = "http://www.minecraftinfo.com/images/194.png",
                Type = ItemType.Tool,
                WikiUrl = "http://minecraft.gamepedia.com/Wooden_Axe"
            });
            this.Insert(new Item
            {
                Name = "Iron Pickaxe",
                Id = "257:0",
                CraftingId = "minecraft:iron_pickaxe",
                Description = "Pickaxes are one of the most commonly used tools in the game, being required to mine all ores and many other types of blocks.",
                Hardness = null,
                Stackability = Stackable.NotStackable,
                ImageUrl = "http://www.minecraftinfo.com/images/230.png",
                Type = ItemType.Tool,
                WikiUrl = "http://minecraft.gamepedia.com/Iron_Pickaxe"
            });
        }
    }
}
