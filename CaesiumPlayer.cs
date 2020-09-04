using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace Caesium
{
	public class CaesiumPlayer : ModPlayer
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
		public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath) {
			if (player.name == "Pufferfish" || player.name == "Pufferfish77") {
				Item item = new Item();
				item.SetDefaults(mod.ItemType("Pufferfish77Mask"));
				items.Add(item);
				item = new Item();
				item.SetDefaults(mod.ItemType("PufferfishSpike"));
				item.stack = 500;
				items.Add(item);
			}
		}
	}
}