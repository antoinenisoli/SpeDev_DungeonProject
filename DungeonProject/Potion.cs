using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Potion : Item
    {
        public Potion(string name, int value) : base(name,value)
        {
            this.name = name;
            this.value = value;
        }

        public void Heal(Character chara)
        {
            Console.WriteLine("");
            Console.WriteLine(chara.name + " boit une potion de soin !");
            Console.WriteLine("Cela lui restaure " + value + " pv !");
            Console.WriteLine("");
            Console.ReadKey();
            
            chara.CurrentHealth += value;
        }

        public void AddForce(Character chara)
        {
            Console.WriteLine("");
            Console.WriteLine(chara.name + " boit une potion de force !");
            Console.WriteLine("Sa force augmente de " + value + " points !");
            Console.WriteLine("");
            Console.ReadKey();

            chara.Force += value;
        }

        public void AddMaxHealth(Character chara)
        {
            Console.WriteLine("");
            Console.WriteLine(chara.name + " boit une potion de vie !");
            Console.WriteLine("Ses pv max augmentent de " + value + " points !");
            Console.WriteLine("");
            Console.ReadKey();

            chara.MaxHealth += value;
        }
    }
}
