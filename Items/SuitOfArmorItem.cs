﻿using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class SuitOfArmorItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Suit of Armor");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 58;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.SuitOfArmor>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronHelmet);
            recipe.AddIngredient(ItemID.IronChainmail);
            recipe.AddIngredient(ItemID.IronGreaves);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.LeadHelmet);
            recipe2.AddIngredient(ItemID.LeadChainmail);
            recipe2.AddIngredient(ItemID.LeadGreaves);
            recipe2.SetResult(this, 1);
            recipe2.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe2.AddRecipe();
        }
    }
}
