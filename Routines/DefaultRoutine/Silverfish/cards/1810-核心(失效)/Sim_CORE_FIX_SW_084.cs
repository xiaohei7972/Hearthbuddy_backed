using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：2 攻击力：2 生命值：5
	//Bloodbound Imp
	//血缚小鬼
	//Whenever this attacks, deal 2 damage to your_hero.
	//每当本随从攻击时，对你的英雄造成2点伤害。
	class Sim_CORE_FIX_SW_084 : SimTemplate
	{
		public override void onMinionAttack(Playfield p, Minion attacker, Minion target)
		{
			p.minionGetDamageOrHeal(attacker.own ? p.ownHero : p.enemyHero, 2);
		}

	}
}
