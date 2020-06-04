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
    class PlasmaRifle : ModItem
    {
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("EnergySword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Pew Pew Pew");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.magic = true;
			item.scale = 2;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.holdStyle = 0;
			item.mana = 5;
			item.shoot = mod.ProjectileType("PlasmaBolt");
			item.shootSpeed = 30f;
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
