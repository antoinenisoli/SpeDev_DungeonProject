using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class PotionHeal : Item
    {
        public PotionHeal(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override void Effect(Player player)
        {
            base.Effect(player);
            Console.WriteLine("It heals him by " + Value + " pv !");
            Console.WriteLine("");
            Console.ReadKey();

            player.CurrentHealth += Value;
        }
    }
}
