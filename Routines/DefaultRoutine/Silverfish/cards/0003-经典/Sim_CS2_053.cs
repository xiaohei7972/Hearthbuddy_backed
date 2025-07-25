using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_053 : SimTemplate //* 视界术 Far Sight
	{
        //Draw a card. That card costs (3) less.
        //抽一张牌，该牌的法力值消耗减少（3）点。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            CardDB.Card card = p.owncards[(p.owncards.Count -1)].card;
            card.cost = Math.Max(0, card.cost - 3);
        }

    }
}
