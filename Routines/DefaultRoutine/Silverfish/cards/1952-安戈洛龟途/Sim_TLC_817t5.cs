using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：5 攻击力：8 生命值：8
	//Sol'etos, Cycle's Rebirth
	//索利托斯，循环新生
	//[x]<b>Taunt</b>, <b>Reborn</b>. <b>Battlecry:</b>Summon a copy of this.<b>Deathrattle:</b> Deal 5 damageto a random enemy.
	//<b>嘲讽</b>。<b>复生</b>。<b>战吼：</b>召唤一个本随从的复制。<b>亡语：</b>随机对一个敌人造成5点伤害
	class Sim_TLC_817t5 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			List<Minion> minions = own.own ? p.ownMinions : p.enemyMinions;
			int minionsCount = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
			if (minionsCount < 7)
			{
				p.callKid(own.handcard.card, own.zonepos, own.own);
				minions[own.zonepos].setMinionToMinion(own);
			}
			else
			{
				p.callKid(own.handcard.card, own.zonepos, own.own);
			}
		}
		
		public override void onDeathrattle(Playfield p, Minion m)
		{
			Minion target = null;

			if (m.own)
			{
				target = p.getEnemyCharTargetForRandomSingleDamage(5);
			}
			else
			{
				target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack);
				if (target == null) target = p.ownHero;
			}
			
			p.minionGetDamageOrHeal(target, 5);
		}
		
	}
}
