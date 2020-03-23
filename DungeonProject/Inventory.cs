using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Item
    {
        public string name;
        public int value;

        public Item(string name, int value)
        {
            this.name = name;
            this.value = value;
        }

        public string ShowItem()
        {
            return "     | Objet : " + name + " | Valeur : " + value + " | ";
        }
    }

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
