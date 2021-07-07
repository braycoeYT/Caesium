using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cesium.Items.Marble
{
	public class MarbleGreatsword : ModItem
	{
		public override void SetDefaults() {
			item.damage = 26;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 41;
			item.useAnimation = 41;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5.6f;
			item.value = Item.sellPrice(0, 0, 35, 0);
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Marble, 22);
			recipe.AddIngredient(ItemID.GoldBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}