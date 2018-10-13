using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class ImmortalShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hylian Shield");
			Tooltip.SetDefault("Grants immunity to knockback and fire blocks\nGrants immunity to most debuffs\nReduces damage taken by 50%");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 775000;
			item.rare = 8;
			item.defense = 10;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
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
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AnkhShield);
			recipe.AddIngredient(ItemID.PaladinsShield);
			recipe.AddIngredient(ItemID.FrozenTurtleShell);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
