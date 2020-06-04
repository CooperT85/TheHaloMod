using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;

namespace TheHaloMod.Items
{
    [AutoloadEquip(EquipType.Head)]
    class MjolnirMarkIVHelmet : ModItem
    {
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("MjolnirMarkIVHelmet");
			Tooltip.SetDefault("This is a modded body armor."
				+ "\nImmunity to 'On Fire!'"
				+ "\n+20 max mana and +1 max minions");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 9;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<MjolnirMarkIVChestplate>() && legs.type == ModContent.ItemType<MjolnirMarkIVLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Enables Energy Shields";
			player.statDefense += 5;
			player.AddBuff(mod.BuffType("EnergyShield"), 2, false);
		}
	}
}
