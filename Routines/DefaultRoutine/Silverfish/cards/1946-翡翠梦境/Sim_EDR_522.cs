using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：1
	//Mimicry
	//拟态
	//Your opponentdraws 2 cards. You get copies of them.
	//你的对手抽两张牌，你获取其复制。
	class Sim_EDR_522 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.unknown, !ownplay, false);
			p.drawACard(CardDB.cardNameEN.unknown, !ownplay, false);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
			p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
		}

	}
}
