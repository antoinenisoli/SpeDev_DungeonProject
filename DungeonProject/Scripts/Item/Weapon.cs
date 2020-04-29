using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Weapon : Equipment
    {
        public Weapon(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override string ToString()
        {
            return " [ Weapon : " + base.ToString();
        }

        public override void GiveTo(Character chara)
        {
            Inventory inventory = chara.Inventory;

            if (inventory.CurrentWeapon.Value == 0)
            {
                inventory.currentEquipment.Add(this);
                inventory.CurrentWeapon = this;
            }
            else
            {
                inventory.ReplaceStuff(this, inventory.CurrentWeapon);
                inventory.CurrentWeapon = this;
            }
        }
    }
}
