using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Lightning : Skill
    {
        int damage;
        public int Damage { get => damage; set => damage = value; }

        public override string ToString()
        {
            return "LIGHTNING " + "[" + Cost + "PT]" + " (Inflict " + damage + " damage points, ignoring the target's armor)";
        }

        public Lightning(int cost, int damage) : base(cost)
        {
            this.Damage = damage;
        }

        public override void Effect(Player player, Ennemy target)
        {
            base.Effect(player, target);
            Console.WriteLine(player.Name + " shoot a powerful lightning on his target !!");
            Console.ReadKey();
            target.TakeDamages(Damage);
        }
    }
}
