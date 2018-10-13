using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class ScarabNecklace : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scarab Necklace");
			Tooltip.SetDefault("Increases your max number of minions\nIncreases the damage and knockback of your minions");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 33;
			item.height = 40;
			item.value = 450000;
			item.rare = 8;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.maxMinions += 2;
			player.minionDamage += 0.25f;
			player.minionKB += 0.15f;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PygmyNecklace);
			recipe.AddIngredient(ItemID.PapyrusScarab);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
