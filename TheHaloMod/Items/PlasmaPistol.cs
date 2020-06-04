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
    class PlasmaPistol : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 10;
            item.magic = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.useTurn = true;
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ItemName", 5);  //in this example you see how to add your custom item to the crafting recipe
            recipe.AddTile(null, "WBName");     //in this example you see how to add your custom craftingbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)//if Right Clicked
            {
                item.damage = 1;
                item.useTime = 60;
                item.useAnimation = 60;
                item.shootSpeed = 10f;
                if (player.statMana >= 50) //if player has 50+ mana
                {
                    player.statMana -= 50; //remove 50 mana
                    item.shoot = mod.ProjectileType("PlasmaPistolBoltOvercharged");
                }
                else
                {
                    return false;                    //this make that when you have 0 mana you cant use the item
                }
                item.autoReuse = false;
            }
            else //if not Right Clicked
            {
                item.damage = 10;
                item.useTime = 20;
                item.useAnimation = 20;
                item.shootSpeed = 20f;
                if (player.statMana >= 3) //if player has 3+ mana
                {
                    player.statMana -= 3; //remove 3 mana
                    item.shoot = mod.ProjectileType("PlasmaPistolBolt");
                }
                else
                {
                    return false;                    //this make that when you have 0 mana you cant use the item
                }
                item.autoReuse = true;
            }
            return base.CanUseItem(player);
        }
    }
}
