using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class PotionMaxHealth : Potion
    {
        public PotionMaxHealth(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public void AddMaxHealth(Character chara)
        {
            Console.WriteLine("");
            Console.WriteLine(chara.name + " boit une potion de vie !");
            Console.WriteLine("Ses pv max augmentent de " + Value + " points !");
            Console.WriteLine("");
            Console.ReadKey();

            chara.MaxHealth += Value;
        }
    }
}
