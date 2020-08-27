using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ZylonFanExpansion.Items.Pufferfish
{
	[AutoloadEquip(EquipType.Head)]
	public class Pufferfish77Mask : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Spiky");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 22;
			item.value = item.value = Item.sellPrice(0, 7, 77, 77);
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
		}
		public override void ModifyTooltips(List<TooltipLine> list) {
            foreach (TooltipLine tooltipLine in list)
            {
                if (tooltipLine.mod == "Terraria" && tooltipLine.Name == "ItemName")
                {
                    tooltipLine.overrideColor = new Color(116, 179, 237);
                }
            }
        }
	}
}