﻿using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class BigWagonItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Big Wagon");
        }

        public override void SetDefaults()
        {
            item.width = 90;
            item.height = 46;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.BigWagon>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 12);
            recipe.anyWood = true;
            recipe.AddIngredient(ItemID.IronBar, 2);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemType<WagonWheelsItem>(), 2);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
