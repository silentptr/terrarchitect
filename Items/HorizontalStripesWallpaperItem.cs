﻿using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class HorizontalStripesWallpaperItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Horizontal Stripes Wallpaper");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 999;
            item.value = 50;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 7;

            item.useStyle = 1;
            item.consumable = true;
            item.createWall = WallType<Walls.HorizontalStripesWallpaper>();
        }
    }
}
