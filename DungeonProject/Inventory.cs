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
        public List<Item> currentEquipment = new List<Item>();

        int currentGold;

        public int CurrentGold { get => currentGold;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                
                if (value > 1000)
                {
                    value = 1000;
                }

                currentGold = value;
            }
        }

        public void ShowInventory()
        {           
            Console.WriteLine("");
            Console.WriteLine("-- Your inventory : ");
            Console.WriteLine("[");

            if (items.Count > 0)
            {
                foreach (Item item in items)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            
            if (currentEquipment.Count > 0)
            {
                foreach (Item equipment in currentEquipment)
                {
                    Console.WriteLine(equipment.ToString());
                }
            }

            if (currentEquipment.Count == 0 && items.Count == 0)
            {
                Console.WriteLine(" | * Empty * ");
            }

            Console.WriteLine("");
            Console.WriteLine(" | Gold coins : " + currentGold);
            Console.WriteLine("]");
            Console.WriteLine("");
        }
    }
}
