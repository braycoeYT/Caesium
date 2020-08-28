using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZylonFanExpansion.Items.Pufferfish
{
	public class PufferfishSpike : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Can poison enemies");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 40;
			item.value = item.value = Item.sellPrice(0, 0, 0, 75);
			item.rare = ItemRarityID.Green;
			item.damage = 12;
			item.knockBack = 3.7f;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 16;
			item.useTime = 16;
			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.ranged = true;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("PufferfishSpike");
			item.shootSpeed = 12f;
			item.maxStack = 999;
		}
	}
}