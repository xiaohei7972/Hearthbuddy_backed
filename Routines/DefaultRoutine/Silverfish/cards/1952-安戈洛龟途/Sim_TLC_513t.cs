using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄 牧师 费用：5
	//Master Dusk
	//暮影大师
	//[x]<b>Battlecry:</b> Summon two3/3 Ninjas with <b>Stealth</b>.Your Ninjas now shuffle backinto your deck when they die.
	//<b>战吼：</b>召唤两个3/3并具有<b>潜行</b>的忍者。你的忍者会在其死亡时洗回你的牌库。
	class Sim_TLC_513t : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_513t2);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.setNewHeroPower(CardDB.cardIDEnum.TLC_513hp, ownplay);
		}

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, own.own);
			p.callKid(kid, pos, own.own);
        }

	}
}
