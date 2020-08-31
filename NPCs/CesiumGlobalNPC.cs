using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Cesium.NPCs
{
	public class ZylonGlobalNPC : GlobalNPC
	{
		public override bool InstancePerEntity => true;
		public override void NPCLoot(NPC npc) {
			if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCorrupt && Main.rand.NextFloat() < .01f) {
				Item.NewItem(npc.getRect(), mod.ItemType("CorruptDisc"));
			}
			if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCrimson && Main.rand.NextFloat() < .01f) {
				Item.NewItem(npc.getRect(), mod.ItemType("BloodyDisc"));
			}
		}
	}
}