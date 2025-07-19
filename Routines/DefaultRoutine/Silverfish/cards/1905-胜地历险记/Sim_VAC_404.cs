using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //法术 潜行者 费用：1
    //Nightshade Tea
    //夜影花茶
    //Deal $2 damageto a minion. Deal $2 damage to your hero.<i>(3 Drinks left!)</i>
    //对一个随从造成$2点伤害。对你的英雄造成$2点伤害。<i>（还剩3杯！）</i>
    class Sim_VAC_404 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int damage = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

                // 对一个随从造成2点伤害
                p.minionGetDamageOrHeal(target, damage);

                // 对你的英雄造成2点伤害
                p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, damage);

                // 抽一张 "VAC_404t1" 卡牌，表示“还剩2杯”
                p.drawACard(CardDB.cardIDEnum.VAC_404t1, ownplay, true);
            }

        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要有目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
            };
        }
    }
}
