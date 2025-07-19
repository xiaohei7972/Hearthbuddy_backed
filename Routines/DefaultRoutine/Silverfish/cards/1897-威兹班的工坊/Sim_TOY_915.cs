using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 术士 费用：4 攻击力：4 生命值：3
    //Tabletop Roleplayer
    //桌游角色扮演玩家
    //[x]<b>Miniaturize</b><b>Battlecry:</b> Give a friendlyDemon +2 Attack and<b>Immune</b> this turn.
    //<b>微缩</b><b>战吼：</b>在本回合中，使一个友方恶魔获得+2攻击力和<b>免疫</b>。
    class Sim_TOY_915 : SimTemplate
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 如果目标是友方恶魔
            if (target != null && target.own && (TAG_RACE)target.handcard.card.race == TAG_RACE.DEMON)
            {
                // 增加2点攻击力，并使其在本回合中获得免疫
                p.minionGetTempBuff(target, 2, 0);
                target.immune = true;
            }
        }

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理微缩效果，假设微缩效果是抽一张衍生物卡牌
            p.drawACard(CardDB.cardIDEnum.TOY_915t, ownplay, true); // 替换为实际的衍生物卡牌 ID
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 15), // 目标只能是恶魔
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 无目标时也可以使用
            };
        }

    }
}
