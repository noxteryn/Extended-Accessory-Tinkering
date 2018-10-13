using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class BlingKit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bling Chest");
			Tooltip.SetDefault("Provides life regeneration and reduces the cooldown of healing potions\nCauses stars to fall and increases length of invincibility after taking damage\nIncreases coin pickup range and shops have lower prices\nHitting enemies will sometimes drop extra coins");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 32;
			item.value = 1150000;
			item.rare = 6;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.lifeRegen =+ 1;
			player.pStone = true;
			player.longInvince = true;
			player.starCloak = true;
			player.goldRing = true;
			player.coins = true;
			player.discount = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CharmofMyths);
			recipe.AddIngredient(ItemID.StarVeil);
			recipe.AddIngredient(ItemID.GreedyRing);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
