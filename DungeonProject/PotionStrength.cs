using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class PotionStrength : Potion
    {
        public PotionStrength(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public void AddForce(Character chara)
        {
            Console.WriteLine("");
            Console.WriteLine(chara.name + " boit une potion de force !");
            Console.WriteLine("Sa force augmente de " + Value + " points !");
            Console.WriteLine("");
            Console.ReadKey();

            chara.Strength += Value;
        }
    }
}
