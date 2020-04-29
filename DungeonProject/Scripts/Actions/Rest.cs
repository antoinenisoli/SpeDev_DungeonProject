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

        public override void Execute(Player player, Room inRoom) //heal the player but destroy the bed after use
        {
            if (inRoom.ennemiesInRoom.Count > 0) //you can't sleep in a room which contains a ennemy
            {
                Console.WriteLine("You can't sleep here, there are enemies nearby !");
                Console.ReadKey();
                return;
            }

            if (inRoom.ContainBed)
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
                Console.WriteLine("But the bed is fading away !");
                Console.ReadKey();
                inRoom.ContainBed = false;
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
