using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class EPDS : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enhanced Personal Defense System");
			Tooltip.SetDefault("Grants the ability to swim and greatly extends underwater breathing\nProvides light under water and extra mobility on ice\nFishing line will never break, decreases chance of bait consumption, increases fishing skill\nIncreases armor penetration by 5\nIncreases melee knockback and inflicts fire damage on attack\n10% increased melee damage and speed\nAllows flight, super fast running, and extra mobility on ice 7% increased movement speed\nProvides 7 seconds of immunity to lava\nGrants immunity to fire blocks");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 1600000;
			item.rare = 7;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.arcticDivingGear = true;
			player.accFlipper = true;
			if (player.wet == true)
			{
				Lighting.AddLight(player.position, 1.0f, 1.0f, 1.0f);
			}
			player.accFishingLine = true;
 			player.accTackleBox = true;
			player.fishingSkill += 10;
			player.armorPenetration += 5;
			player.kbGlove = true;
 			player.meleeSpeed += 0.10f;
 			player.meleeDamage += 0.10f;
			player.magmaStone = true;
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
			recipe.AddIngredient(mod.ItemType<ADS>());
			recipe.AddIngredient(mod.ItemType<SpikedFlamingGauntlet>());
			recipe.AddIngredient(mod.ItemType<ThermalGreaves>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
