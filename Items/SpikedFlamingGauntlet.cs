using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class SpikedFlamingGauntlet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spiked Flaming Gauntlet");
			Tooltip.SetDefault("Increases armor penetration by 5\nIncreases melee knockback and inflicts fire damage on attack\n10% increased melee damage and speed");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 26;
			item.height = 30;
			item.value = 450000;
			item.rare = 7;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.armorPenetration += 5;
			player.kbGlove = true;
 			player.meleeSpeed += 0.10f;
 			player.meleeDamage += 0.10f;
			player.magmaStone = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SharkToothNecklace);
			recipe.AddIngredient(ItemID.FireGauntlet);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
