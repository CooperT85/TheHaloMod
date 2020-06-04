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
    class PlasmaPistolBoltOvercharged : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("OverchargedPlasmaPistolBolt");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.magic = true;
			aiType = ProjectileID.Bullet;
			projectile.scale = 2;
			projectile.light = 1f;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(mod.BuffType("Emp"),150);
			projectile.Kill();
		}

		public override void Kill(int timeLeft)
		{
			Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
		}
	}
}
