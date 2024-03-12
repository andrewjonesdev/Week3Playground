using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Playground
{
    public static class PirateExtensions
    {
        public static void FightPirate(this Pirate yourself, Pirate enemyPirate)
        {
            if (yourself.Bounty > enemyPirate.Bounty) 
            { 
                Console.WriteLine($"{yourself.Name} Defeated {enemyPirate.Name} !"); 
            } 
            else 
            { 
                Console.WriteLine($"{enemyPirate.Name} Defeated {yourself.Name} !"); 
            }

        }
        public static void SayHi(this Pirate yourself)
        {
            Console.WriteLine($"{yourself.Name} said Hi!");

        }
    }
}