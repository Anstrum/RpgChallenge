using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGChallenge.Project
{
    internal static class WeaponList
    {
        private static List<string> weaponList = new List<string>() { ""};
        public static List<string> Get()
        {
            return weaponList;
        }


        public struct Weapon
        {
            string name;
        }

        public static Weapon GetWeapon(string _weaponName)
        {
            switch(_weaponName)
            {
                case "sword":
                    return new DoubleSword();
                case "sword and shield":
                    return new SwordAndShield();
            }
        }
    }


    internal class DoubleSword : Weapon
    {
        public DoubleSword() : base("double sword")
        {
            AD = 25;
            AP = 0;
            DEF = 0;
            RM = 0;
        }
    }
    internal class SwordAndShield : Weapon
    {
        public SwordAndShield() : base("sword and shield")
        {
            AD = 15;
            AP = 0;
            DEF = 10;
            RM = 0;
        }
    }
    internal class Staff : Weapon
    {
        public Staff() : base("staff")
        {
            AD = 10;
            AP = 15;
            DEF = 0;
            RM = 0;
        }
    }
    internal class MagicGloves : Weapon
    {
        public MagicGloves() : base("magic gloves")
        {
            AD = 0;
            AP = 15;
            DEF = 0;
            RM = 10;
        }
    }
    internal class SilverShield : Weapon
    {
        public SilverShield() : base("silver shield")
        {
            AD = 0;
            AP = 0;
            DEF = 15;
            RM = 10;
        }
    }
    internal class Spear : Weapon
    {
        public Spear() : base("spear")
        {
            AD = 20;
            AP = 0;
            DEF = 5;
            RM = 0;
        }
    }
    internal class Wand : Weapon
    {
        public Wand() : base("wand")
        {
            AD = 0;
            AP = 25;
            DEF = 0;
            RM = 0;
        }
    }
    /*
    internal class SampleWeapon : Weapon
    {
        public SampleWeapon() : base("sample_name")
        {
            AD = 0;
            AP = 0;
            DEF = 0;
            RM = 0;
        }
    }
    */
}