using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class PickUpItem : Action
    {
        public override void Execute(Player player, Room inRoom)
        {
            Console.Clear();
            
            if (inRoom.itemsInRoom.Count > 0)
            {
                Item pickedItem = Menu.PickElementFromList<Item>(inRoom.itemsInRoom, "Items in the room :");
                inRoom.itemsInRoom.Remove(pickedItem);
                pickedItem.GiveTo(player);
                
                Console.WriteLine(player.Name + " add the " + pickedItem.Name + " to his inventory.");
            }
            else
            {
                Console.WriteLine("There is no items in this room...");
            }

            Console.ReadKey();
            Console.Clear();
        }

        public override string ToString()
        {
            return "Pick up an item";
        }
    }
}
