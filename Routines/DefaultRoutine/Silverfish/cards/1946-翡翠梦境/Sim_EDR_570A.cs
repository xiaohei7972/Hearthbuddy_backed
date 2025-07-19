using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：1
	//Nightmarish Burst
	//噩梦爆发
	//Deal $1 damage toall minions.
	//对所有随从造成$1点伤害。
	class Sim_EDR_570A : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			int damage = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
			p.allMinionsGetDamage(damage);
        }
		
		
	}
}
