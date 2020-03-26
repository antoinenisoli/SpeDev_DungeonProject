using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class InspectRoom : Action
    {
        public override void Execute(Player player, Room inRoom)
        {
            Console.WriteLine("");

            if (inRoom.Bed)
            {
                Console.WriteLine("There's a bed hidden in this room...\n");
            }

            if (inRoom.ennemiesInRoom.Count > 0)
            {
                Console.WriteLine("This room contains these ennemies :");

                foreach (Ennemy mob in inRoom.ennemiesInRoom)
                {
                    Console.WriteLine(mob.ShowCharacter());
                }
            }
            else
            {
                Console.WriteLine("There is no ennemies here.");
            }

            if (inRoom.itemsInRoom.Count > 0)
            {                
                Console.WriteLine("\nThis room contains these items :");

                foreach (Item item in inRoom.itemsInRoom)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("There is no items here.");
            }            

            Console.WriteLine("");
            Console.ReadLine();
            Console.Clear();
        }

        public override string ToString()
        {
            return "Inspect the room";
        }
    }
}
