using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public class Player : Charater
    {
        public Race CharacterRace { get; set; }
        public Weapons EquippedWeapon { get; set; }

        public Player(string name, Race characterRace, string description, Weapons equippedWeapon, int maxLife, int life, int hitChance) 
        {
            Name = name;
            CharacterRace = characterRace;
            Description = description;
            EquippedWeapon = equippedWeapon;
            MaxLife = maxLife;
            Life = life;
            HitChance = hitChance;

        }//end ctor

        public override string ToString()
        {
            return string.Format("-= {0} =-\n" +
                "Character Race: {1}\n" +
                "Description: {2}\n" +
                "Current Weapon: {3}\n" +
                "Hit Chance: {4}\n" +
                "Max Health: {5}\n" +
                "Current Health: {6}", Name, CharacterRace, Description, EquippedWeapon, HitChance, MaxLife, Life);
        }//end tostring

       
    }//end class
}//end namespace
