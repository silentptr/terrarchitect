﻿using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class SmallGardenToolRackItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Garden Tool Rack");
        }

        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 32;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.SmallGardenToolRack>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 4);
            recipe.anyWood = true;
            recipe.AddIngredient(ItemID.IronBar);
            recipe.anyIronBar = true;
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
