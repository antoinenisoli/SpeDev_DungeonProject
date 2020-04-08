using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Ennemy : Character
    {
        int xpValue;
        int goldValue;

        public int XpValue { get => xpValue;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                xpValue = value;
            }
        }

        public int GoldValue { get => goldValue;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                goldValue = value;
            }
        }

        public Ennemy(string name, int currentHealth, int maxHealth, int strength, int xpValue, int goldValue) : base(name, currentHealth, maxHealth, strength)
        {
            this.XpValue = xpValue;
            this.GoldValue = goldValue;
        }

        public Ennemy InstatiateCopy() //create a copy of a precise enemy
        {
            return new Ennemy(Name, CurrentHealth, MaxHealth, Strength, XpValue, GoldValue);
        }

        public override void IsDead()
        {
            Console.WriteLine(Name + " is now dead !");
        }
        
        public override void ShowCharacter()
        {
            Console.WriteLine("[ " + Name + " : | PV = " + CurrentHealth + "/" + MaxHealth + " | Strength = " + Strength + " | " + "]");
        }
        
        public override void ShowInventory()
        {
            Inventory.ShowItems();
            Inventory.ShowEquipment();
        }

        public void SetName(string newName)
        {
            Name = base.Name + newName;
        }

        public override string ToString()
        {
            ShowCharacter();
            ShowInventory();
            return null;
        }
    }
}
