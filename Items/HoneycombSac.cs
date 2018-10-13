using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class HoneycombSac : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honeycomb Sac");
			Tooltip.SetDefault("Releases bees, causes stars to fall, and increases movement speed when injured\nIncreases jump height");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 304000;
			item.rare = 4;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.bee = true;
			player.starCloak = true;
			player.jumpBoost = true;
			player.panic = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeCloak);
			recipe.AddIngredient(ItemID.HoneyBalloon);
			recipe.AddIngredient(ItemID.SweetheartNecklace);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
