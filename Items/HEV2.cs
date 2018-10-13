using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class HEV2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("HEV Suit (Mk V)");
			Tooltip.SetDefault("'For use in hazardous environment conditions'");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 2500000;
			item.rare = 9;
			item.defense = 100;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.arcticDivingGear = true;
			player.accFlipper = true;
			Lighting.AddLight(player.position, 1.0f, 1.0f, 1.0f);
			player.accFishingLine = true;
 			player.accTackleBox = true;
			player.fishingSkill += 10;
			player.armorPenetration += 10;
			player.kbGlove = true;
 			player.meleeSpeed += 0.10f;
 			player.meleeDamage += 0.20f;
			player.rangedDamage += 0.10f;
			player.magicDamage += 0.10f;
			player.minionDamage += 0.10f;
			player.magmaStone = true;
			player.accRunSpeed = 6.80f;
 			player.rocketBoots = 1;
 			player.moveSpeed += 0.09f;
			player.iceSkate = true;
			player.lavaMax += 420;
			player.fireWalk = true;
			player.noKnockback = true;
			player.endurance += 0.50f;
			player.buffImmune[BuffID.Bleeding] = true;
			player.buffImmune[BuffID.BrokenArmor] = true;
			player.buffImmune[BuffID.Burning] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.buffImmune[BuffID.Confused] = true;
			player.buffImmune[BuffID.Cursed] = true;
			player.buffImmune[BuffID.Darkness] = true;
			player.buffImmune[164] = true; // Distorted
			player.buffImmune[BuffID.Electrified] = true;
			player.buffImmune[148] = true; // Feral Bite
			player.buffImmune[145] = true; // Moon Bite
			player.buffImmune[BuffID.Obstructed] = true;
			player.buffImmune[BuffID.Poisoned] = true;
			player.buffImmune[BuffID.Silenced] = true;
			player.buffImmune[BuffID.Slow] = true;
			player.buffImmune[BuffID.Stoned] = true;
			player.buffImmune[BuffID.Weak] = true;
			player.noFallDmg = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType<HEV>());
			recipe.AddIngredient(ItemID.FragmentSolar, 50);
			recipe.AddIngredient(ItemID.FragmentVortex, 50);
			recipe.AddIngredient(ItemID.FragmentNebula, 50);
			recipe.AddIngredient(ItemID.FragmentStardust, 50);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
