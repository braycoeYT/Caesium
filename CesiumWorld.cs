using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;

namespace Cesium
{
	public class CesiumWorld : ModWorld
	{
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1)
			{
		    tasks.Insert(ShiniesIndex + 1, new PassLegacy("Cesium Ores", CesiumOres));
			}
		}
		private void CesiumOres(GenerationProgress progress) {
			progress.Message = "Zinc Ore";
			for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++) {
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); 
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("ZincOre"));
			}
		}
	}
}