using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class CoinsBag : Item
    {
        public CoinsBag(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override void Effect(Player player)
        {
            base.Effect(player);
            Console.WriteLine(player.Name + " won " + Value + " coins !");
            Console.WriteLine("");
            Console.ReadKey();
            
            player.Inventory.CurrentGold += Value;
        }
    }
}
