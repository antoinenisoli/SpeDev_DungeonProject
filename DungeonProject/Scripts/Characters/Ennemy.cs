using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Ennemy : Character
    {
        public int xpValue;
        public int goldValue;

        public Ennemy(string name, int currentHealth, int maxHealth, int force, int xpValue, int goldValue) : base(name, currentHealth, maxHealth, force)
        {
            this.xpValue = xpValue;
            this.goldValue = goldValue;
        }

        public override void IsDead()
        {
            Console.WriteLine(Name + " is now dead !");
            Console.ReadKey();
        }

        public override string ShowCharacter()
        {
            return "[ " + Name + " : | PV = " + CurrentHealth + "/" + MaxHealth + " | Strength = " + Strength + " | " + "]";
        }

        public override void ShowInventory()
        {
            inventory.ShowItems();
            inventory.ShowEquipment();
        }

        public void SetName(string newName)
        {
            Name = base.Name + newName;
        }

        public override string ToString()
        {
            ShowInventory();
            return ShowCharacter();
        }
    }
}
