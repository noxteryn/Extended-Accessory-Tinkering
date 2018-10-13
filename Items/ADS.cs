using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class ADS : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Atmospheric Diving Suit");
			Tooltip.SetDefault("Grants the ability to swim and greatly extends underwater breathing\nProvides light under water and extra mobility on ice\nFishing line will never break, decreases chance of bait consumption, increases fishing skill");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 500000;
			item.rare = 5;
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
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ArcticDivingGear);
			recipe.AddIngredient(ItemID.AnglerTackleBag);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
