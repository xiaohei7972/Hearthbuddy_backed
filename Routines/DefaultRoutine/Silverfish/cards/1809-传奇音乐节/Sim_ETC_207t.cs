using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Barrel of Monkeys
	//一桶欢猢
	//Summon a 1/4 Monkey with <b>Taunt</b>.<i>(2 Monkeys left!)</i>
	//召唤一只1/4并具有<b>嘲讽</b>的猴子。<i>（还剩2只猴子！）</i>
	class Sim_ETC_207t : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_127);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.drawACard(CardDB.cardIDEnum.ETC_207t2, ownplay, true);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), // 需要一个空位
			};
		}

	}
}
