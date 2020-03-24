using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Inventory
    {
        public List<Item> items = new List<Item>();
        public int currentGold;

        public Inventory()
        {
            
        }

        public void ShowInventory()
        {           
            Console.WriteLine("");
            Console.WriteLine("-- Inventaire : ");
            Console.WriteLine("[");

            if (items.Count > 0)
            {
                foreach (Item item in items)
                {
                    Console.WriteLine(item.ShowItem());
                }
            }
            else
            {
                Console.WriteLine("     | * Vide * ");
            }

            Console.WriteLine("");
            Console.WriteLine("     | Piéces d'or : " + currentGold);
            Console.WriteLine("]");
            Console.WriteLine("");
        }
    }
}
