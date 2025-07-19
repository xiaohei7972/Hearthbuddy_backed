using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：5
	//Metamorphosis
	//恶魔变形
	//Swap your Hero Power to "Deal 5 damage." After 2 uses, swap it back.
	//将你的英雄技能替换为“造成5点伤害。”使用两次后，换回原技能。
	class Sim_TOY_400t6 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.setNewHeroPower(CardDB.cardIDEnum.BT_429p, ownplay);
        }
		
	}
}
