using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Leave : Action
    {
        public override string ToString()
        {
            return "If there is an exit, try to leave the dungeon";
        }

        public override void Execute(Player player, Room inRoom)
        {
            if (inRoom.ContainExit)
            {
                Console.WriteLine("There is an exit right here !");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Congratulations !");
                Console.WriteLine(player.Name + " go through the exit and leave the dungeon with " + player.Inventory.CurrentGold + " gold !");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("There is no exit here !");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
