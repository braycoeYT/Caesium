using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cesium.Items.Accessories
{
	public class BloodyDisc : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Gives the player weak lifesteal.");
		}
		public override void SetDefaults() {
			item.width = 40;
			item.height = 40;
			item.value = item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = ItemRarityID.Blue;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual) {
			CesiumPlayer p = player.GetModPlayer<CesiumPlayer>();
			p.bloodyDisc = true;
		}
	}
}