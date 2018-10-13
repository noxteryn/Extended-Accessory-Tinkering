using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class SuperNinja : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ultimate Ninja Gear");
			Tooltip.SetDefault("Allows the ability to climb walls and dash\nGives a chance to dodge attacks\nIncreases jump speed and allows auto-jump\nIncreases fall resistance");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 35;
			item.height = 40;
			item.value = 550000;
			item.rare = 8;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.blackBelt = true;
			player.dash = 1;
			player.spikedBoots = 2;
			player.autoJump = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MasterNinjaGear);
			recipe.AddIngredient(ItemID.FrogLeg);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
