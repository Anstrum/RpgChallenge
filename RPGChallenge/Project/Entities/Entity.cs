using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGChallenge.Project.Entities
{
    internal abstract class Entity
    {
        public Weapon weapon { get; set; }
        public Stance stance { get; protected set; }
        public MoveType nextMove { get; protected set; }


        public string name { get; private set; }
        public double HP { get; private set; }
        public double MP { get; private set; }
        public double DEF { get; private set; }
        public double RM { get; private set; }
        public double AP { get; private set; }
        public double AD { get; private set; }


        public Entity(string _name)
        {
            name = _name;
            HP = 100;
            HP = 100;
            DEF = 15;
            RM = 15;
            AP = 25;
            AD = 30;
        }

        #region Fight Functions
        public abstract void Defend(DamageType _damageType, double _damageAmount);
        //public abstract void Attack();
        public abstract void MakeChoice();
        public void PlayChoice(Entity _oponent)
        {
            switch(nextMove)
            {
                case MoveType.Defend:
                    return;
                case MoveType.PhysicalAttack:
                    _oponent.Defend(DamageType.Physical, AD);
                    break;
                case MoveType.MagicalAttack:
                    _oponent.Defend(DamageType.Magical, AP);
                    break;
            }
        }
        #endregion

        #region Status Functions
        public bool IsDead() { return HP <= 0; }
#endregion

        #region Core Functions
        protected void TakeDamage(DamageType _type, double _damageAmount)
        {                      
            if (_damageAmount - GetResistance(_type) > 0)
            {
                HP -= _damageAmount - GetResistance(_type);
            }
        }
        protected double GetResistance(DamageType _type)
        {
            switch(_type)
            {
                case DamageType.Physical:
                    if (stance == Stance.Defense)
                    {
                        return DEF * 2;
                    }
                    return DEF;
                case DamageType.Magical:
                    if(stance == Stance.Defense)
                    {
                        return RM * 2;
                    }
                    return DEF;
                case DamageType.True:
                    return 0;
                default:
                    throw new Exception("< DamageType > is not initialized");
            }
        }
        #endregion
    }
}
