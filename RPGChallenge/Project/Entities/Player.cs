using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGChallenge.Project.Entities
{
    internal class Player : Entity
    {
        public Player(string _name) : base(_name) { }


        public override void Defend(DamageType _type, double _amount)
        {
            TakeDamage(_type, _amount);
        }
        public override void MakeChoice()
        {
            List<string> choices = new List<string>() { "Physical Attack", "Magical Attack", "Defend" };

            int answer = ChoiceManager.AskChoice(choices, "Choose an Action:");

            switch(answer)
            {
                case 0:
                    nextMove = MoveType.PhysicalAttack;
                    stance = Stance.Attack;
                    break;
                case 1:
                    nextMove = MoveType.MagicalAttack;
                    stance = Stance.Attack;
                    break;
                case 2: default:                
                    nextMove = MoveType.Defend;
                    stance = Stance.Defense;
                    break;
            }
        }
    }
}
