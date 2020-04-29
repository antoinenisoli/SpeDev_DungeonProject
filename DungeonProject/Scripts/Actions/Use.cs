using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Use : Action
    {
        public override void Execute(Player player, Room inRoom)
        {
            if (player.Inventory.items.Count > 0)
            {
                Console.Clear();
                Item pickedItem = Menu.PickElementFromList<Item>(player.Inventory.items, "Your inventory :");
                pickedItem.Effect(player);
            }
            else
            {
                Console.WriteLine("There is no items to use...");
                Console.ReadKey();
            }

            Console.Clear();
        }

        public override string ToString()
        {
            return "Use a item from the inventory";
        }
    }
}
