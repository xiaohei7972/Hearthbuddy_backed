using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：3 攻击力：2 耐久度：0
	//Aldrachi Warblades
	//奥达奇战刃
	//<b>Lifesteal</b>
	//<b>吸血</b>
	class Sim_TOY_913t1 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_913t1);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}
		
	}
}
