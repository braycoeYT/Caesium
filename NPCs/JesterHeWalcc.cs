using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caesium.NPCs
{
	public class JesterHeWalcc : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Jester");
			Main.npcFrameCount[npc.type] = 9;
		}
		public override void SetDefaults() {
			npc.width = 47;
			npc.height = 65;
			npc.damage = 19;
			npc.defense = 9;
			npc.lifeMax = 61;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			//aiType = NPCID.Zombie;
		}
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {
			npc.lifeMax = 121;
			npc.damage = 39;
		}
		int Timer;
		int animationTimer;
		public override void AI() {
			Timer++;
			if (Timer % 3 == 0) {
				animationTimer++;
			}
			if (animationTimer > 8)
			animationTimer = 0;
			npc.frame.Y = animationTimer * 65;
			npc.spriteDirection = npc.direction;
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldNightMonster.Chance * 0.12f;
		}
		public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X += Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y += Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 2f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		public override void NPCLoot() {
			Item.NewItem(npc.getRect(), ItemID.Confetti, Main.rand.Next(5, 11));
			if (Main.rand.NextFloat() < .09f)
			Item.NewItem(npc.getRect(), mod.ItemType("TwincolorSlicer"));
		}
	}
}