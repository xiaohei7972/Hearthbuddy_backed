using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：3
	//Awoken Darkness
	//觉醒的黑暗
	//Deal $2 damage to all minions.
	//对所有随从造成$2点伤害。
	class Sim_EDR_820b : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int damage = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
			p.allMinionsGetDamage(damage);
			
		}

	}
}
