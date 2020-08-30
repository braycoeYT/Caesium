using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cesium.Projectiles.Pufferfish
{
	public class PufferfishSpike : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pufferfish Spike");
		}
		public override void SetDefaults() {
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 1;
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.Poisoned, 60 * Main.rand.Next(3, 6), false);
		}
		public override void OnHitPvp(Player target, int damage, bool crit) {
			target.AddBuff(BuffID.Poisoned, 60 * Main.rand.Next(3, 6), false);
		}
	}
}