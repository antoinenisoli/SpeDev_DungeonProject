using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class PotionHeal : Potion
    {
        public PotionHeal(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public void Heal(Character chara)
        {
            Console.WriteLine("");
            Console.WriteLine(chara.name + " boit une potion de soin !");
            Console.WriteLine("Cela lui restaure " + Value + " pv !");
            Console.WriteLine("");
            Console.ReadKey();

            chara.CurrentHealth += Value;
        }
    }
}
