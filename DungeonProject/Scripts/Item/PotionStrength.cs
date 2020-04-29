using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class PotionStrength : Item
    {
        public PotionStrength(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override void Effect(Player player)
        {
            base.Effect(player);
            Console.WriteLine("His strength is increased by " + Value + " points !\n");
            Console.ReadKey();
            player.Inventory.items.Remove(this);
            player.Strength += Value;
        }
    }
}
