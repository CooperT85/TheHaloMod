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
    class Emp : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Emp");
            Description.SetDefault("Slowness and less defense");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true; //Nurse can remove it
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.statDefense >= 4)
            {
                player.statDefense -= 4;
            }
            else
            {
                player.statDefense = 0;
            }
            if (player.moveSpeed >= 8)
            {
                player.moveSpeed -= 4;
            }
            else
            {
                player.moveSpeed /= 2;
            }
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.stepSpeed /= 2;
            if(npc.defense >= 10)
            {
                npc.defense -= 10;
            }
            else
            {
                npc.defense = 0;
            }
        }
    }
}
