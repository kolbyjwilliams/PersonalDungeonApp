using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapons
    {
        //Damage
        //Range
        //Critical Hit Chance
        //attack speed

        //fields
        private int _minDamage;

        //properties
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int AttackSpeed { get; set; }
        public double CriticalHitChance { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }//end if
                else
                {
                    _minDamage = 1;
                }//end else
            }//end set
        }//end min int
        //constructors
        public Weapons(int minDamage, int maxDamage, string name, int attackSpeed, double criticalHitChance)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
            AttackSpeed = attackSpeed;
            CriticalHitChance = criticalHitChance;
        }

        public Weapons() { }

        //Methods
        public override string ToString()
        {
            return string.Format("Name: {0}\n" +
                "Max. Damage: {1} Hit Points\n" +
                "Min. Damage: {2} Hit Points\n" +
                "Attack Speed: {3}%\n" +
                "Crit Chance: {4}%", Name, MaxDamage, MinDamage, AttackSpeed, CriticalHitChance);
        }

    }//end class
}//end namespace
