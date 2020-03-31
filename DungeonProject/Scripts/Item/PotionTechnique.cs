using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class PotionTechnique : Item
    {
        public PotionTechnique(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override void Effect(Player player)
        {
            base.Effect(player);
            Console.WriteLine("It restores him " + Value + " PT !");
            Console.WriteLine("");
            Console.ReadKey();

            player.CurrentPT += Value;
        }
    }
}
