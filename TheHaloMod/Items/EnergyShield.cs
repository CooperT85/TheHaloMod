using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;

namespace TheHaloMod.Items
{
    class EnergyShield : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("EnergyShields");
            Description.SetDefault("Boosted defense and regeneration");
            Main.buffNoTimeDisplay[Type] = true;
            Main.debuff[Type] = false; //Nurse can't remove it
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 5;
            player.lifeRegen += 5;
        }
    }
}
