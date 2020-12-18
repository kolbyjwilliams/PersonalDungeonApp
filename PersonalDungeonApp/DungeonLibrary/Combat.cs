using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DungeonLibrary
{
   public class Combat 
    {
        public static void DoAttack(Charater attacker, Charater defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            Thread.Sleep(100);
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                int damageDelt = attacker.CalcDamage();
                defender.Life -= damageDelt;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!\n", attacker.Name, defender.Name, damageDelt);
                Console.ResetColor();
            }

        }


    }
}
