using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class QueenBeeCharm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Charm of the Queen Bee");
			Tooltip.SetDefault("Increases the strength of friendly bees\nReleases bees, causes stars to fall, and increases movement speed when injured\nIncreases jump height");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 404000;
			item.rare = -12;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.strongBees = true;
			player.bee = true;
			player.starCloak = true;
			player.jumpBoost = true;
			player.panic = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3333); // Hive Pack
			recipe.AddIngredient(mod.ItemType<HoneycombSac>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
