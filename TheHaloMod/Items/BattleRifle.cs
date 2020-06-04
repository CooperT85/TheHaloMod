using Microsoft.Xna.Framework;
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
    class BattleRifle : ModItem
    {
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("EnergySword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("More range = more kills");
		}

		public override void SetDefaults()
		{
			item.damage = 35;
			item.ranged = true;
			item.scale = 1;
			item.width = 40;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 15;
			item.reuseDelay = 16;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.holdStyle = 0;
			item.useAmmo = AmmoID.Bullet;
			item.shoot = AmmoID.Bullet;
			item.shootSpeed = 20f;
		}

		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-6, 0);
		}
	}
}
