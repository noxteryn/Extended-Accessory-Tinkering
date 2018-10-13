using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class SniperKit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sniper Briefcase");
			Tooltip.SetDefault("Increases damage by 10% and greatly increases arrow speed 20% chance to not consume arrow\n10% increased ranged damage and critical strike chance\nIncreases view range for guns");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 550000;
			item.rare = 7;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.magicQuiver = true;
			player.rangedDamage += 0.10f;
			player.rangedCrit += 10;
			player.scope = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MagicQuiver);
			recipe.AddIngredient(ItemID.SniperScope);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
