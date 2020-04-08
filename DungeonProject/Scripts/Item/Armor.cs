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

        public override string ToString()
        {
            return " [Armor : " + base.ToString();
        }

        public override void GiveTo(Character chara)
        {
            Inventory inventory = chara.Inventory;

            if (inventory.CurrentArmor.Value == 0)
            {
                inventory.currentEquipment.Add(this);
                inventory.CurrentArmor = this;
            }
            else
            {
                inventory.ReplaceStuff(this, inventory.CurrentArmor);
                inventory.CurrentArmor = this;
            }
        }
    }
}
