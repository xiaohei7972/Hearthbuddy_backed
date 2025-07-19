using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：0
	//Twin Slice
	//双刃斩击
	//Give your hero +1 Attack this turn. Add 'Second Slice' to your hand.
	//在本回合中，使你的英雄获得+1攻击力。将“二次斩击”置入你的手牌。
	class Sim_TOY_400t3 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetTempBuff(ownplay ? p.ownHero : p.enemyHero, 1, 0);
			p.drawACard(CardDB.cardIDEnum.TOY_400t3t, ownplay, true);
        }
		
	}
}
