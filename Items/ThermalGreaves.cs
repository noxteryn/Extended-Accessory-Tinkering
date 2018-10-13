using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class ThermalGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thermal Greaves");
			Tooltip.SetDefault("Allows flight, super fast running, and extra mobility on ice 7% increased movement speed\nProvides 7 seconds of immunity to lava\nGrants immunity to fire blocks");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 32;
			item.height = 28;
			item.value = 650000;
			item.rare = 7;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.accRunSpeed = 6.75f;
 			player.rocketBoots = 1;
 			player.moveSpeed += 0.08f;
			player.iceSkate = true;
			player.lavaMax += 420;
			player.fireWalk = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FrostsparkBoots);
			recipe.AddIngredient(ItemID.LavaCharm);
			recipe.AddIngredient(ItemID.ObsidianSkull);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
