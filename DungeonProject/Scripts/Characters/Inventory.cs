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
        Character chara;

        public Character Chara { get => chara; set => chara = value; }

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

        public Inventory(Character chara)
        {
            this.Chara = chara;
        }

        public void GainGold(int gold) //add coins in the inventory
        {
            if (gold <= 0)
                return;

            Console.WriteLine("");
            Console.WriteLine("You won " + gold + " coins !");
            Console.WriteLine("");            
            CurrentGold += gold;
        }

        public void ReplaceStuff(Equipment newStuff, Equipment oldStuff) //if a slot is already occupied, the player can replace it by the new looted item
        {
            Console.WriteLine("\nThis slot is already occupied !");
            Console.WriteLine("The new equipment is added to the inventory.");
            currentEquipment.Remove(oldStuff);
            currentEquipment.Add(newStuff);
        }

        public void ShowEquipment()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("-- Current stuff --");
            
            if (currentEquipment.Count > 0)
            {
                if (CurrentArmor != null && CurrentArmor.Value > 0)
                {
                    Console.WriteLine(CurrentArmor.ToString());
                }
                else
                {
                    Console.WriteLine("*[Armor : None ]*");
                }

                if (CurrentSword != null && CurrentSword.Value > 0)
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
            Console.WriteLine("-- Items in " + chara.Name + "'s inventory --");

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

        public override string ToString()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("[---INVENTORY---]");
            ShowItems();
            ShowEquipment();
            ShowCoins();
            return null;
        }
    }
}
