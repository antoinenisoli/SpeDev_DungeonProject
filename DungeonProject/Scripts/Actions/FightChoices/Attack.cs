using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Attack : FightChoice
    {
        public override string ToString()
        {
            return "Attack the opponent with a simple blow";
        }

        public override void Choice(Player player, Ennemy mob, Room inRoom)
        {
            Console.Clear();
            player.Attack(mob);

            if (mob.CurrentHealth > 0)
            {
                Console.WriteLine("\n" + mob.Name + " strikes back !");
                Console.ReadKey();
                mob.Attack(player);
                Console.Clear();

            }
        }
    }
}
