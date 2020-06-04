using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheHaloMod.Items
{
    class Needle : ModItem
    {
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("EnergySword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Use a lot to make an effect");
		}

		public override void SetDefaults()
		{
			item.ammo = item.type;
			item.damage = 2;
			item.shoot = mod.ProjectileType("NeedleProjectile");
			item.consumable = true;
			item.maxStack = 999;
			item.value = 100;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
