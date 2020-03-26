using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Rest : Action
    {
        public override string ToString()
        {
            return "Rest in a bed";
        }

        public override void Execute(Player player, Room inRoom)
        {
            if (inRoom.Bed)
            {

                Console.WriteLine("There's a bed in the room !");
                Console.WriteLine(player.Name + " go to sleep in the bed.");
                Console.ReadKey();

                for (int i = 4; i > 0; i--)
                {
                    Console.WriteLine("Zzz... \n");
                    Console.ReadKey();
                }

                Console.WriteLine(player.Name + " has recovered some health !");
                Console.ReadKey();
                player.CurrentHealth += 30;
            }
            else
            {
                Console.WriteLine("You can't sleep here, there's no bed !");
                Console.ReadKey();
            }
        }
    }
}
