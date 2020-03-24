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

            if (inRoom.ennemiesInRoom.Count > 0)
            {
                Console.WriteLine("Cette piéce semble contenir ces ennemis :");

                foreach (Ennemy mob in inRoom.ennemiesInRoom)
                {
                    Console.WriteLine(mob.ShowCharacter());
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas d'ennemis.");
            }

            if (inRoom.itemsInRoom.Count > 0)
            {                
                Console.WriteLine("\nCette piéce semble contenir ces objets :");

                foreach (Item item in inRoom.itemsInRoom)
                {
                    Console.WriteLine(item.ShowItem());
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas d'objets");
            }            

            Console.WriteLine("");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
