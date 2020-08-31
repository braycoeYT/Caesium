using Terraria;
using Terraria.ModLoader;

namespace Cesium
{
	public class CesiumPlayer : ModPlayer
	{
		public bool bloodyDisc;
		public override void ResetEffects() {
			bloodyDisc = false;
		}
		public override void OnHitAnything(float x, float y, Entity victim) {
			if (bloodyDisc) {
				if (Main.rand.Next(3) == 0) {
					player.statLife += 1;
					player.HealEffect(1, true);
				}
			}
		}
	}
}