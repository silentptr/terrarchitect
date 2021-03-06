﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Tiles
{
    public class Parasol : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.Width = 1;
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 18 };
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 62, 62, ItemType<Items.ParasolItem>());
        }

        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Vector2 zero = Main.drawToScreen ? Vector2.Zero : new Vector2(Main.offScreenRange, Main.offScreenRange);
            Tile tile = Main.tile[i, j];

            if (tile.frameY == 0)
            {
                spriteBatch.Draw(mod.GetTexture("Tiles/ParasolTop"), new Vector2((i * 16) - (int)Main.screenPosition.X - 22, (j * 16) - (int)Main.screenPosition.Y - 24) + zero, new Rectangle(0, 0, 62, 24), Color.White);
            }
            
            return true;
        }
    }
}
