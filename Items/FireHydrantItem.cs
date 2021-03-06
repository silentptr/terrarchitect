﻿using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class FireHydrantItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Hydrant");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 32;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.FireHydrant>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.RedPaint, 10);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
