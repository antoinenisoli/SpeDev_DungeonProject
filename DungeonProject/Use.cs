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

            if (player.inventory.items.Count > 0)
            {
                Item pickedItem = Menu.PickElementFromList<Item>(player.inventory.items, "Your inventory :");
                inRoom.itemsInRoom.Remove(pickedItem);
                pickedItem.Effect(player);
            }
            else
            {
                Console.WriteLine("There is no items to use...");
            }

            Console.ReadKey();
            Console.Clear();
        }

        public override string ToString()
        {
            return "Use a item from the inventory";
        }
    }
}
