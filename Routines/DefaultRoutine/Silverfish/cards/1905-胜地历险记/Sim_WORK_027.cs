using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 中立 费用：3 攻击力：3 生命值：2
    //Dreamplanner Zephrys
    //梦想策划师杰弗里斯
    //[x]<b>Battlecry:</b> Choose aTravel Tour to get twopotentially perfectcards from it.
    //<b>战吼：</b>选择一条旅行路线，从中获取两张可能会表现完美的卡牌。
    class Sim_WORK_027 : SimTemplate
    {

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 根据玩家选择的选项（choice）来决定添加哪张卡牌
            // CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

            if (choice == 1)
            {
                p.drawACard(CardDB.cardIDEnum.CORE_CS1_112, own.own, true);
                p.drawACard(CardDB.cardIDEnum.EX1_407, own.own, true);
                // selectedCardID = CardDB.cardIDEnum.WORK_027t1; // 简便之行
            }
            else if (choice == 2)
            {
                p.drawACard(CardDB.cardIDEnum.CORE_EX1_383, own.own, true);
                p.drawACard(CardDB.cardIDEnum.EX1_295, own.own, true);
                // selectedCardID = CardDB.cardIDEnum.WORK_027t2; // 奢华之行
            }
            else if (choice == 3)
            {
                p.drawACard(CardDB.cardIDEnum.CORE_CS2_029, own.own, true);
                p.drawACard(CardDB.cardIDEnum.CORE_EX1_238, own.own, true);
                // selectedCardID = CardDB.cardIDEnum.WORK_027t3; // 紧凑之行
            }


        }
    }
}




