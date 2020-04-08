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
            Console.Clear();

            if (player.Inventory.items.Count > 0)
            {
                Item pickedItem = Menu.PickElementFromList<Item>(player.Inventory.items, "Your inventory :");
                player.Inventory.items.Remove(pickedItem);
                pickedItem.Effect(player);
            }
            else
            {
                Console.WriteLine("There is no items to use...");
            }

            Console.Clear();
        }

        public override string ToString()
        {
            return "Use a item from the inventory";
        }
    }
}
