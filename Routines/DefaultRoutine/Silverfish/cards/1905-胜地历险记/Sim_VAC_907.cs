using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //法术 德鲁伊 费用：7
    //Sleep Under the Stars
    //星夜露宿
    //[x]<b>Choose Thrice - </b>Draw 2cards; Gain 5 Armor;Refresh 3 Mana Crystals.
    //<b>选择三次：</b>抽两张牌；获得5点护甲值；或者复原三个法力水晶。
    class Sim_VAC_907 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            for (int i = 0; i < 3; i++)
            {
                if (choice == 1)
                {
                    p.drawACard(CardDB.cardNameEN.unknown, ownplay);
                    p.drawACard(CardDB.cardNameEN.unknown, ownplay);
                }
                if (choice == 2)
                {
                    if (ownplay)
                    {
                        p.minionGetArmor(p.ownHero, 5);
                    }
                    else
                    {
                        p.minionGetArmor(p.enemyHero, 5);
                    }
                }

                if (choice == 3)
                {
                    p.mana = Math.Max(p.ownMaxMana, p.mana + 3);
                }


                // 根据玩家选择的选项（choice）来决定添加哪张卡牌
                // CardDB.Card selectedCard = CardDB.Card.unknownCard;
                // CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

                // for (int i = 0; i < 3; i++)
                // {
                //     if (choice == 1)
                //     {
                //         selectedCardID = CardDB.cardIDEnum.VAC_907t1;  // 猎豹星座
                //     }
                //     else if (choice == 2)
                //     {
                //         selectedCardID = CardDB.cardIDEnum.VAC_907t2; // 巨熊星座
                //     }
                //     else if (choice == 3)
                //     {
                //         selectedCardID = CardDB.cardIDEnum.VAC_907t3; // 枭兽星座
                //     }

                //     selectedCard = CardDB.Instance.getCardDataFromID(selectedCardID);
                //     PenalityManager.Instance.getChooseCard(selectedCard, choice).sim_card.onCardPlay(p, ownplay, target, choice);
            }
        }


    }
}
