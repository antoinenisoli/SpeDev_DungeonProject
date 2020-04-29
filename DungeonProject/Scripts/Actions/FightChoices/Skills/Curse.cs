using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Curse : Skill
    {
        public override string ToString()
        {
            return "CURSE " + "[" + Cost + "PT]" + " (Reduce the target's health by a half)";
        }

        public Curse(int cost) : base(cost)
        {

        }

        public override void Effect(Player player, Ennemy target) //reduce the ennemy's health by a half
        {
            base.Effect(player, target);
            Console.WriteLine(player.Name + " cast a terrible curse on his ennemy !");
            Console.ReadKey();
            
            if ((target.CurrentHealth / 2) > 0 && (target.MaxHealth / 2) > 0)
            {
                Console.WriteLine(target.Name + " is now cursed ! His life is reduced by a falf !!");
                Console.ReadKey();
                target.CurrentHealth /= 2;
                target.MaxHealth /= 2;
            }
            else
            {
                Console.WriteLine("It seems that " + target.Name + " is too much cursed...");
                Console.ReadKey();
            }
        }
    }
}
