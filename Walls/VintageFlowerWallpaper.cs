using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace terrarchitect.Walls
{
	public class VintageFlowerWallpaper : ModWall
	{
		public override void SetDefaults() {
			Main.wallHouse[Type] = true;
			drop = ModContent.ItemType<Items.VintageFlowerWallpaperItem>();
			AddMapEntry(new Color(223, 154, 155));
		}
	}
}
