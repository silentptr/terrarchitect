﻿using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class WagonWheelsItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wagon Wheels");
        }

        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 30;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.WagonWheels>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 6);
            recipe.anyWood = true;
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.anyIronBar = true;
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
