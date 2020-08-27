using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZylonFanExpansion.Items.Accessories
{
	public class CorruptDisc : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Increases melee speed by 4%\nIncreases melee critical strike chance by 7%");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.value = item.value = Item.sellPrice(0, 0, 3, 0);
			item.rare = ItemRarityID.Blue;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeSpeed += 0.04f;
			player.meleeCrit += 7;
		}
		public override void AddRecipes() 
		{
			Mod zylon = ModLoader.GetMod("Zylon");
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(zylon.ItemType("BrokenDiscus"), 7);
			recipe.AddIngredient(ItemID.RottenChunk, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}