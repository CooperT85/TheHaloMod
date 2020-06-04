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
    class CrystalNeedle : ModItem
    {
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("EnergySword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Can track your foes");
		}

		public override void SetDefaults()
		{
			item.ammo = mod.ItemType("Needle");
			item.damage = 5;
			item.shoot = mod.ProjectileType("CrystalNeedleProjectile");
			item.consumable = true;
			item.maxStack = 999;
			item.value = 1000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 10);
			recipe.AddIngredient(mod.ItemType("Needle"), 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
