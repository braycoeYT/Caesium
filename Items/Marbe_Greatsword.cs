
using ZylonFanExpansion.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ZylonFanExpansion.Items
{
	public class Marble_Greatsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Marble Greatsword");
			Tooltip.SetDefault("woah this is big");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			//item.shoot = mod.ProjectileType("Star");
			//item.shootSpeed = 9f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Marble, 20);
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}