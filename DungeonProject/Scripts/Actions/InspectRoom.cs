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
            Console.Clear();

            if (inRoom.Bed) //show the bed in the room
            {
                Console.WriteLine("There's a bed hidden in this room...\n");
                Console.ReadKey();
            }

            if (inRoom.ennemiesInRoom.Count > 0) //show the ennemies in the room
            {
                Console.WriteLine("This room contains these ennemies :");

                foreach (Ennemy mob in inRoom.ennemiesInRoom)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(mob.ToString());
                    mob.ShowInventory();
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("There is no ennemies here.");
                Console.ReadKey();
            }

            if (inRoom.itemsInRoom.Count > 0) //show the items in the room
            {
                Console.WriteLine("");
                Console.WriteLine("\nThis room contains these items :");

                foreach (Item item in inRoom.itemsInRoom)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("There is no items here.");
                Console.ReadKey();
            }            

            Console.WriteLine("");
            Console.Clear();
        }

        public override string ToString()
        {
            return "Inspect the room";
        }
    }
}
