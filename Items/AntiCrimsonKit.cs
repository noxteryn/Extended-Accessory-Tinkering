using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAT.Items
{
	public class AntiCrimsonKit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Anti-Crimson Kit");
			Tooltip.SetDefault("Slimes become friendly\nMay confuse nearby enemies after being struck\nSummons spores over time that will damage enemies\nGreatly increases life regen when not moving");
		}
		
		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 600000;
			item.rare = -12;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
		//	player.npcTypeNoAggro[NPCID.BigSlimedZombie] = true;
		//	player.npcTypeNoAggro[NPCID.SmallSlimedZombie] = true;
		//	player.npcTypeNoAggro[NPCID.BigCrimslime] = true;
		//	player.npcTypeNoAggro[NPCID.LittleCrimslime] = true;
		//	player.npcTypeNoAggro[NPCID.JungleSlime] = true;
		//	player.npcTypeNoAggro[NPCID.YellowSlime] = true;
		//	player.npcTypeNoAggro[NPCID.RedSlime] = true;
		//	player.npcTypeNoAggro[NPCID.PurpleSlime] = true;
		//	player.npcTypeNoAggro[NPCID.BlackSlime] = true;
		//	player.npcTypeNoAggro[NPCID.BabySlime] = true;
		//	player.npcTypeNoAggro[NPCID.Pinky] = true;
		//	player.npcTypeNoAggro[NPCID.GreenSlime] = true;
		//	player.npcTypeNoAggro[NPCID.Slimer2] = true;
		//	player.npcTypeNoAggro[NPCID.Slimeling] = true;
			player.npcTypeNoAggro[NPCID.BlueSlime] = true;
			player.npcTypeNoAggro[NPCID.MotherSlime] = true;
			player.npcTypeNoAggro[NPCID.KingSlime] = true;
			player.npcTypeNoAggro[NPCID.LavaSlime] = true;
			player.npcTypeNoAggro[NPCID.DungeonSlime] = true;
			player.npcTypeNoAggro[NPCID.CorruptSlime] = true;
			player.npcTypeNoAggro[NPCID.Slimer] = true;
			player.npcTypeNoAggro[NPCID.Gastropod] = true;
			player.npcTypeNoAggro[NPCID.IlluminantSlime] = true;
			player.npcTypeNoAggro[NPCID.IceSlime] = true;
			player.npcTypeNoAggro[NPCID.Crimslime] = true;
			player.npcTypeNoAggro[NPCID.SpikedIceSlime] = true;
			player.npcTypeNoAggro[NPCID.SlimedZombie] = true;
			player.npcTypeNoAggro[NPCID.SpikedJungleSlime] = true;
			player.npcTypeNoAggro[NPCID.UmbrellaSlime] = true;
			player.npcTypeNoAggro[NPCID.RainbowSlime] = true;
			player.npcTypeNoAggro[NPCID.SlimeMasked] = true;
			player.npcTypeNoAggro[NPCID.BunnySlimed] = true;
			player.npcTypeNoAggro[NPCID.SlimeRibbonWhite] = true;
			player.npcTypeNoAggro[NPCID.SlimeRibbonYellow] = true;
			player.npcTypeNoAggro[NPCID.SlimeRibbonGreen] = true;
			player.npcTypeNoAggro[NPCID.SlimeRibbonRed] = true;
			player.npcTypeNoAggro[NPCID.ArmedZombieSlimed] = true;
			player.npcTypeNoAggro[NPCID.SlimeSpiked] = true;
			player.npcTypeNoAggro[NPCID.SandSlime] = true;
			player.npcTypeNoAggro[NPCID.HoppinJack] = true;
			player.brainOfConfusion = true;
			player.SporeSac();
			player.sporeSac = true;
			player.shinyStone = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RoyalGel);
			recipe.AddIngredient(ItemID.BrainOfConfusion);
			recipe.AddIngredient(ItemID.SporeSac);
			recipe.AddIngredient(ItemID.ShinyStone);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
