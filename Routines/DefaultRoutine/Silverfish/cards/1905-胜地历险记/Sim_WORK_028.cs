using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：4
	//Eternal Layover
	//无限滞留
	//[x]Give ALL minions <b>Reborn</b>,then destroy all minions.
	//使所有随从获得<b>复生</b>，然后消灭所有随从。
	class Sim_WORK_028 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.ownMinions.Count > 0)
			{
				p.ownMinions.ForEach((m) => m.reborn = true);
				foreach (Minion m in p.ownMinions)
				{
					m.reborn = true;
				}
			}

			if (p.enemyMinions.Count > 0)
			{
				foreach (Minion m in p.enemyMinions)
				{
					m.reborn = true;
				}
			}

			p.allMinionsGetDestroyed();
		}

	}
}
