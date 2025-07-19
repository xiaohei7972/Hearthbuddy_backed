using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄 德鲁伊 费用：5
	//Wildheart Guff
	//野性之心古夫
	//[x]<b>Battlecry:</b> Set yourmaximum Mana to 20.Gain an empty ManaCrystal. Draw a card.
	//<b>战吼：</b>将你的法力值上限变为20。获得一个空的法力水晶。抽一张牌。
	class Sim_AV_205 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.ownMaxMana++;
			p.drawACard(CardDB.cardNameEN.unknown, own.own);

		}

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.setNewHeroPower(CardDB.cardIDEnum.AV_205p, ownplay);
        }

	}
}
