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
        public Ennemy(string name, int maxHealth, int force, int xpValue) : base(name, maxHealth, force)
        {
            this.xpValue = xpValue;
        }

        public override string ShowCharacter()
        {
            Console.WriteLine("");
            return "[ " + name + " : | PV = " + GetLife() + "/" + maxHealth + " | Force = " + force + " | " + "]";
        }

        public override void ShowInventory()
        {
            inventory.ShowInventory();
        }
    }
}
