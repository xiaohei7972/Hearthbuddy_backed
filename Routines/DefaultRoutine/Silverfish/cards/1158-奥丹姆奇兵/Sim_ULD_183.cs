using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：9 攻击力：9 生命值：6
	//Anubisath Warbringer
	//阿努比萨斯战争使者
	//<b>Deathrattle:</b> Give all minions in your hand +3/+3.
	//<b>亡语：</b>使你手牌中的所有随从牌获得+3/+3。
	class Sim_ULD_183 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{
			if (m.own)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB)
					{
						hc.addattack += 3;
						hc.addHp += 3;
						p.anzOwnExtraAngrHp += 6;
					}
				}
			}
			
        }
		
	}
}
