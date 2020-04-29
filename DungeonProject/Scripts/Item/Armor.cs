using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Armor : Equipment
    {
        public Armor(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public Armor InstantiateArmor() //create a copy of a precise item
        {
            return new Armor(Name, Value);
        }

        public override string ToString()
        {
            return " [ Armor : " + base.ToString();
        }

        public override void GiveTo(Character chara)
        {
            Inventory inventory = chara.Inventory;            
            Armor newArmor = InstantiateArmor();

            if (inventory.CurrentArmor.Value == 0)
            {
                inventory.currentEquipment.Add(newArmor);
                inventory.CurrentArmor = newArmor;
            }
            else
            {
                inventory.ReplaceStuff(newArmor, inventory.CurrentArmor);
                inventory.CurrentArmor = newArmor;
            }
        }
    }
}
