using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZylonFanExpansion.Projectiles.Pufferfish
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
	}
}