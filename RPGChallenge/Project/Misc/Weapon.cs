using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGChallenge.Project
{
    internal abstract class Weapon
    {
        public ID id { get; private set; }
        public string name { get; protected set; }


        public double AD { get; protected set; }
        public double AP { get; protected set; }
        public double DEF { get; protected set; }
        public double RM { get; protected set; }


        public Weapon(string _name)
        {
            id = new ID();
            name = _name;
        }
    }
}
