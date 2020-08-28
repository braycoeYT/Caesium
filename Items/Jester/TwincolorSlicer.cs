using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZylonFanExpansion.Items.Jester
{
	public class TwincolorSlicer : ModItem
	{
		public override void SetDefaults() {
			item.damage = 10;
			item.melee = true;
			item.width = 33;
			item.height = 33;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 1;
			item.knockBack = 4.2f;
			item.value = Item.sellPrice(0, 0, 15, 0);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.crit = 16;
		}
		public override void PostUpdate() {
			if (Main.rand.NextBool()) {
				Dust dust = Dust.NewDustDirect(item.position, item.width, item.height, Main.rand.Next(139, 143));
				dust.noGravity = true;
				dust.scale = 1.5f;
			}
		}
	}
}