using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Flee : FightChoice
    {
        public override string ToString()
        {
            return "Flee the fight";
        }

        public override void Choice(Player player, Ennemy mob, Room inRoom)
        {
            int random = RandomGenerators.Instance.RandomNumber(0, 2); //return a number between 0 and 1

            if (random == 0)
            {
                Console.WriteLine(player.Name + " flee the fight !");
                Console.ReadKey();
                player.InFight = false;
            }
            else
            {
                Console.WriteLine("You're attempt to flee has failed !");
                Console.ReadKey();
                mob.Attack(player);
            }            
        }
    }
}
