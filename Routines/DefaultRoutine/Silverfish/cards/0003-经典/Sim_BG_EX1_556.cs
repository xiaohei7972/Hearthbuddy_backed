using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：2 生命值：3
	//Harvest Golem
	//麦田傀儡
	//<b>Deathrattle:</b> Summon a 2/1 Damaged Golem.
	//<b>亡语：</b>召唤一个2/1的损坏的傀儡。
	class Sim_BG_EX1_556 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.skele21);

		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
		}

	}
}

