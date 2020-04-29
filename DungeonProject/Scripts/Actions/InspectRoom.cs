using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class InspectRoom : Action
    {
        public override string ToString()
        {
            return "Inspect the room";
        }

        public void Contains(bool value, string msg)
        {
            if (value) //show the bed or the exit in the room
            {
                Console.WriteLine("There's a " + msg + " in this room...\n");
                Console.ReadKey();
            }
        }

        public void PrintList<T>(string msg, string emptyMsg, List<T> list)
        {
            if (list.Count > 0) //show the elements in the room
            {
                Console.WriteLine(msg);

                foreach (T obj in list)
                {
                    Console.WriteLine("\n" + obj.ToString());
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine(emptyMsg);
                Console.ReadKey();
            }
        }

        public override void Execute(Player player, Room inRoom)
        {
            void ShowOrNot()
            {
                foreach (Ennemy ennemy in inRoom.ennemiesInRoom)
                {
                    ennemy.ShowStuff = !ennemy.ShowStuff;
                }
            }
            Console.Clear();
            Contains(inRoom.ContainBed, "bed");
            Contains(inRoom.ContainExit, "exit");

            ShowOrNot();
            PrintList("This room contains these ennemies :", "There is no ennemies here. ", inRoom.ennemiesInRoom);
            ShowOrNot();
            PrintList("This room contains these items :", "There is no items here.", inRoom.itemsInRoom);            
            Console.WriteLine("\nThat's all !");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
