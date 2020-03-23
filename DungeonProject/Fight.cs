using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Fight : Action
    {
        Ennemy mob;
        Player hero;

        public Fight(Player hero, Ennemy mob)
        {
            this.hero = hero;
            this.mob = mob;
        }

        public void Battle()
        {
            Console.WriteLine(hero.ShowCharacter());
            Console.WriteLine(mob.ShowCharacter());

            hero.Attack(mob);

            if (mob.currentHealth <= 0)
            {
                Console.WriteLine(mob.name + " est vaincu !");
                Console.ReadKey();
            }

            Console.WriteLine(mob.name + " riposte !");
            mob.Attack(hero);

            Console.Clear();
        }
    }
}
