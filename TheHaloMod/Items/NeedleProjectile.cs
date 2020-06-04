using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheHaloMod.Items
{
    class NeedleProjectile : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("NeedleProjectile");
		}

		public override void SetDefaults()
		{
			projectile.width = 8;
			projectile.height = 3;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			aiType = ProjectileID.Bullet;
		}
	}
}
