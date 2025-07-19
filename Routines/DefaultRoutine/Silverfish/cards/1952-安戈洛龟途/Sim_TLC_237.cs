using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：3 攻击力：0 生命值：2
	//Skyscreamer Eggs
	//啸天龙蛋
	//<b>Deathrattle:</b> Summon four 2/1 Hatchlings.
	//<b>亡语：</b>召唤四只2/1的啸天龙宝宝。
	class Sim_TLC_237 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_237t);
		public override void onDeathrattle(Playfield p, Minion m)
		{
			for (int i = 0; i < 4; i++)
			{
				p.callKid(kid, m.zonepos - 1, m.own);
			}
		}

	}
}
