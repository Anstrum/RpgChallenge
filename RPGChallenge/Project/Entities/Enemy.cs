using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGChallenge.Project.Entities
{
    internal class Enemy : Entity
    {
        private Random random = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds * (int)DateTime.Now.TimeOfDay.TotalSeconds);

        public Enemy(string _name) : base(_name) { }


        public override void Defend(DamageType _type, double _amount)
        {
            TakeDamage(_type, _amount);
        }
        public override void MakeChoice()
        {
            int choice = random.Next(1, 100);

            if (choice >= 50)
            {
                if (choice >= 75)
                {
                    nextMove = MoveType.MagicalAttack;
                    return;
                }
                nextMove = MoveType.PhysicalAttack;
                return;
            }
            nextMove = MoveType.Defend;
        }
    }
}
