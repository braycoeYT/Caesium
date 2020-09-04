using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caesium.Projectiles.Granite
{
	public class GraniteBeamswordBeam : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Granite Beamsword Beam");
		}
		public override void SetDefaults() {
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 27;
			projectile.melee = true;
			projectile.penetrate = 1;
			projectile.light = 0.5f;
			projectile.alpha = 255;
			projectile.friendly = true;
		}
		public override void AI() {
			int dustType = DustID.Electric;
			int dustIndex = Dust.NewDust(projectile.position, projectile.width, projectile.height, dustType);
			Dust dust = Main.dust[dustIndex];
			dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
			dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
			dust.scale *= 0.5f + Main.rand.Next(-30, 31) * 0.01f;
		}
	}
}