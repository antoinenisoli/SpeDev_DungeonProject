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
        Weapon currentSword = new Weapon(null, 0);
        Armor currentArmor = new Armor(null, 0);
        int currentGold;

        public Weapon CurrentSword { get => currentSword; set => currentSword = value; }

        public Armor CurrentArmor { get => currentArmor; set => currentArmor = value; }

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

        public void GainGold(int gold)
        {
            if (gold <= 0)
                return;

            Console.WriteLine("");
            Console.WriteLine("You won " + gold + " coins !");
            Console.WriteLine("");            
            CurrentGold += gold;
        }

        void ReplaceItem(Item newStuff, Item oldStuff)
        {
            Console.WriteLine("\nThis slot is already occupied !");
            Console.WriteLine("The new equipment is added to the inventory.");
            currentEquipment.Remove(oldStuff);
            currentEquipment.Add(newStuff);
        }

        public void GiveSword(Weapon weapon)
        {            
            if (CurrentSword.Value == 0)
            {
                currentEquipment.Add(weapon);
                CurrentSword = weapon;
            }
            else
            {
                ReplaceItem(weapon, CurrentSword);
                CurrentSword = weapon;
            }
        }

        public void GiveArmor(Armor armor)
        {            
            if (CurrentArmor.Value == 0)
            {
                currentEquipment.Add(armor);
                CurrentArmor = armor;
            }
            else
            {
                ReplaceItem(armor, CurrentArmor);
                CurrentArmor = armor;
            }
        }

        public void ShowEquipment()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("-- Current stuff --");
            
            if (currentEquipment.Count > 0)
            {
                if (CurrentArmor != null)
                {
                    Console.WriteLine(CurrentArmor.ToString());
                }
                else
                {
                    Console.WriteLine("*[Armor : None ]*");
                }

                if (CurrentSword != null)
                {
                    Console.WriteLine(CurrentSword.ToString());
                }
                else
                {
                    Console.WriteLine("*[Weapon : None ]*");
                }
            }
            else
            {
                Console.WriteLine("*[Armor : None ]*");
                Console.WriteLine("*[Weapon : None ]*");
            }
        }

        public void ShowItems()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("-- Items in inventory --");

            if (items.Count > 0)
            {
                foreach (Item item in items)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            if (items.Count == 0)
            {
                Console.WriteLine(" | * Empty * | ");
            }            
        }

        public void ShowCoins()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine(" | Gold coins : " + currentGold + " |");
            Console.WriteLine("---------------------------");

        }

        public void ShowInventory()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("[---INVENTORY---]");
            ShowItems();
            ShowEquipment();
            ShowCoins();
        }
    }
}
