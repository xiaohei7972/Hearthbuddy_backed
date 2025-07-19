using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //英雄 巫妖王 费用：6
    //The Headless Horseman
    //无头骑士
    //[x]<b>Battlecry:</b> Destroy the enemyminion with the most <i>Attack!</i>Shuffle my Head into yourdeck, you must get it <i>back!</i>
    //<b>战吼：</b>消灭攻击力最高的敌方<i>随从</i>！将我的头洗入牌库，你必须找到它的<i>行踪</i>！
    class Sim_TOY_829 : SimTemplate
    {
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_829t);
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 查找攻击力最高的敌方随从
            Minion highestAttackMinion = null;
            int maxAttack = 0;

            foreach (Minion minion in p.enemyMinions)
            {
                if (minion.Angr > maxAttack)
                {
                    maxAttack = minion.Angr;
                    highestAttackMinion = minion;
                }
            }

            if (highestAttackMinion != null)
            {
                // 消灭攻击力最高的敌方随从
                p.minionGetDestroyed(highestAttackMinion);
            }
            
            p.AddToDeck(card);

        }

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.TOY_829hp3, ownplay);
        }

    }
}
