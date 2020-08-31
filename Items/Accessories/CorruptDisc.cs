using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cesium.Items.Accessories
{
	public class CorruptDisc : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Increases melee speed by 8%\nIncreases melee critical strike chance by 2%");
		}
		public override void SetDefaults() {
			item.width = 40;
			item.height = 40;
			item.value = item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = ItemRarityID.Blue;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.meleeSpeed += 0.08f;
			player.meleeCrit += 2;
		}
	}
}