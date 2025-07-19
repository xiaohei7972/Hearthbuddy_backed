using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：2
	//Twilight Influence
	//暮光侵扰
	//<b>Choose One -</b> Destroy a minion with 3 or less Attack; or Summon a random 2-Cost minion.
	//<b>抉择：</b>消灭一个攻击力小于或等于3的随从；或者随机召唤一个法力值消耗为（2）的随从。
	class Sim_EDR_463 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				if (target != null)
				{
					p.minionGetDestroyed(target);
				}
			}
			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				CardDB.Card kid = p.getRandomCardForManaMinion(2);
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_MAX_ATTACK, 3), // 目标攻击力小于3
			};
		}
		
	}
}
