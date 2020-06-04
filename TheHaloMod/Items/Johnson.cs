using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TheHaloMod.Items
{
    [AutoloadHead]
    class Johnson : ModNPC
    {
        public override string Texture
        {
            get
            {
                return "TheHaloMod/Items/Johnson";
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Marine";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 5;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 20;
            npc.lifeMax = 500;
            npc.knockBackResist = 0.6f;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;

            animationType = NPCID.ArmsDealer;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            // Code goes here
            return true;
        }

        public override string TownNPCName()
        {
            return "Johnson";
        }

        public override string GetChat()
        {
            switch(Main.rand.Next(6))
            {
                case 0:
                    return "Oh, I know what the ladies like.";
                case 1:
                    return "OORAH!";
                case 2:
                    return "You told me you were gonna wear something nice!";
                case 3:
                    return "The Corps ain't payin' us by the hour!";
                case 4:
                    return "Folks need heroes , to give 'em hope, so smile would ya, while we still got something to smile about!";
                case 5:
                    return "Please, don't shake the light bulb.";
                default:
                    return "When I joined the Corps, we didnt have any fancy-schmanzy tanks! We had sticks! Two sticks, and a rock for the whole platoon, and we had to share the rock!";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
            button2 = "Coming Soon";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if(firstButton)
            {
                shop = true;
            }
            else
            {
                Main.npcChatText = "WHAT PART OF COMING SOON DO YOU NOT UNDERSTAND, MARINE!";
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(mod.ItemType("CeMagnum"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(mod.ItemType("AssaultRifle"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(mod.ItemType("BattleRifle"));
            nextSlot++;
            
            shop.item[nextSlot].SetDefaults(mod.ItemType("EnergySword"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(mod.ItemType("GravityHammer"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(mod.ItemType("PlasmaRifle"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(mod.ItemType("PlasmaPistol"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(mod.ItemType("Spiker"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(mod.ItemType("Needle"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(mod.ItemType("CrystalNeedle"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(ItemID.ExplodingBullet);
        }

        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), ItemID.ClockworkAssaultRifle);
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 10;
            knockback = 2f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 15;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.Bullet;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 10f;
        }

    }
}
