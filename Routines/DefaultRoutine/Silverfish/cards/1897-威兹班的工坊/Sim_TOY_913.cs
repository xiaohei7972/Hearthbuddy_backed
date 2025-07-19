using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：4 攻击力：4 生命值：4
	//Ci'Cigi
	//希希集
	//[x]<b>Battlecry, Outcast, andDeathrattle:</b> Get a random__first-edition Demon Hunter__card <i>(in mint condition)</i>.
	//<b>战吼，流放，亡语：</b>随机获取一张初版恶魔猎手卡牌<i>（品相完美）</i>。
	class Sim_TOY_913 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.TOY_400t8, own.own, true);
		}

		public override void onCardPlay(Playfield p, Minion own, bool ownplay, Minion target, int choice, bool outcast)
		{
			p.drawACard(CardDB.cardIDEnum.TOY_400t8, own.own, true);
		}

        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.drawACard(CardDB.cardIDEnum.TOY_400t8, m.own, true);
        }
		
	}
}
