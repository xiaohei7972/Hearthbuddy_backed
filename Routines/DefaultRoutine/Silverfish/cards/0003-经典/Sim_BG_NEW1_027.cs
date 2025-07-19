using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：3
	//Southsea Captain
	//南海船长
	//Your other Pirates have +1/+1.
	//你的其他海盗拥有+1/+1。
	class Sim_BG_NEW1_027 : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion m)
		{
			List<Minion> minions = (m.own) ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in minions)
			{
				if ((TAG_RACE)minion.handcard.card.race == TAG_RACE.NERUBIAN && minion.entitiyID != m.entitiyID) p.minionGetBuffed(minion, 1, 1);
			}
		}

		public override void onAuraEnds(Playfield p, Minion m)
		{
			List<Minion> minions = (m.own) ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in minions)
			{
				if ((TAG_RACE)minion.handcard.card.race == TAG_RACE.NERUBIAN && minion.entitiyID != m.entitiyID) p.minionGetBuffed(minion, -1, -1);
			}
        }
		
	}
}
