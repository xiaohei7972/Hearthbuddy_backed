using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 猎人 费用：1
	//Tracking
	//追踪术
	//<b>Discover</b> a card from your deck.
	//从你的牌库中<b>发现</b>一张牌。
	class Sim_GDB_846hp : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }

	}
}
