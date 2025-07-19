using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：4 攻击力：3 生命值：6
	//Water Elemental
	//水元素
	//<b>Freeze</b> any character damaged by this minion.
	//<b>冻结</b>任何受到本随从伤害的角色。
	class Sim_VAN_CS2_033 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice) 
        {
            if (target != null) p.minionGetFrozen(target); // 冻结目标
        }
		
	}
}
