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
        public Ennemy(string name, int currentHealth, int maxHealth, int force, int xpValue) : base(name, currentHealth, maxHealth, force)
        {
            this.xpValue = xpValue;
        }

        public override string ShowCharacter()
        {
            Console.WriteLine("");
            return "[ " + Name + " : | PV = " + GetLife() + "/" + MaxHealth + " | Force = " + Force + " | " + "]";
        }
    }
}
