using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class CelestialAmulet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestial Amulet");
			Tooltip.SetDefault("Turns the holder into a werewolf at night and a merfolk when entering water\nMinor increases to all stats\nIncreases pickup range for stars\nRestores mana when damaged");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 34;
			item.value = 1020000;
			item.rare = 8;
			item.defense = 4;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wolfAcc = true;
			player.accMerman = true;
			player.lifeRegen += 2;
			player.manaRegen += 1;
			player.meleeSpeed += 0.10f;
			player.meleeDamage += 0.10f;
			player.rangedDamage += 0.10f;
			player.magicDamage += 0.25f;
			player.minionDamage += 0.10f;
			player.meleeCrit += 2;
			player.rangedCrit += 2;
			player.magicCrit += 2;
			player.pickSpeed -= 0.15f;
			player.minionKB += 0.50f;
			player.manaMagnet = true;
			player.magicCuffs = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CelestialShell);
			recipe.AddIngredient(ItemID.CelestialEmblem);
			recipe.AddIngredient(ItemID.CelestialCuffs);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
