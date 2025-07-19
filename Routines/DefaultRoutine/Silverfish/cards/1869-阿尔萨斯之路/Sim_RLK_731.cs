using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：3 攻击力：2 生命值：5
	//Darkfallen Neophyte
	//黑暗堕落者新兵
	//[x]<b>Battlecry:</b> Spend 2 <b>Corpses</b>to give all minions in yourhand +2 Attack.
	//<b>战吼：</b>消耗2份<b>残骸</b>，使你手牌中的所有随从牌获得+2攻击力。
	class Sim_RLK_731 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own && p.getCorpseCount() >= 2)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB)
					{
						hc.addattack += 3;
					}
				}
			}
		}
		
	}
}
