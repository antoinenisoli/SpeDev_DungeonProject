using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class PotionMaxHealth : Item
    {
        public PotionMaxHealth(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override void Effect(Player player)
        {
            base.Effect(player);
            Console.WriteLine("His maximum Health points are increased by " + Value + " points !");
            Console.WriteLine("");
            Console.ReadKey();

            player.MaxHealth += Value;
        }
    }
}
