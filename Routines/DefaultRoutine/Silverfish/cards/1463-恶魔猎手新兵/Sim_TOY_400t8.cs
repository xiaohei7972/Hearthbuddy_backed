using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：3
	//Eye Beam
	//眼棱
	//<b>Lifesteal</b>. Deal $3 damage to a minion.<b>Outcast:</b> This costs (0).
	//<b>吸血</b>。对一个随从造成$3点伤害。<b>流放：</b>法力值消耗为（0）点。
	class Sim_TOY_400t8 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);

				// 对一个随从造成3点伤害并触发吸血效果
				p.minionGetDamageOrHeal(target, damage);
				p.applySpellLifesteal(damage, ownplay);
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
			};
		}


	}
}
