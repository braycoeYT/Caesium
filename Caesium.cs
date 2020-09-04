using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caesium
{
	public class Caesium : Mod 
	{
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.Daybloom);
			recipe.AddIngredient(null, "ZincOre");
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.IronskinPotion);
			recipe.AddRecipe();
		}
		public override void AddRecipeGroups() {
			if (RecipeGroup.recipeGroupIDs.ContainsKey("IronBar")) {
				int index = RecipeGroup.recipeGroupIDs["IronBar"];
				RecipeGroup group = RecipeGroup.recipeGroups[index];
				group.ValidItems.Add(ItemType("ZincBar"));
			}
		}
	}
}