using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Fight : Action
    {
        public override string ToString()
        {
            return "Attack an ennemy";
        }

        public override void Execute(Player player, Room inRoom)
        {
            bool choice = false;
            while (!choice)
            {
                if (inRoom.ennemiesInRoom.Count == 0)
                {
                    Console.WriteLine("There is no ennemies in this room !");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                Console.WriteLine("Which ennemy do you want to fight ?");
                int step = 0;

                foreach (Ennemy ennemy in inRoom.ennemiesInRoom)
                {

                    Console.WriteLine(step + " : " + ennemy.ShowCharacter());
                    step++;
                }

                string answer = Console.ReadLine();
                if (int.TryParse(answer, out int nombre))
                {
                    if (nombre >= 0 && nombre < inRoom.ennemiesInRoom.Count)
                    {
                        choice = true;
                        Ennemy selected = inRoom.ennemiesInRoom[nombre];
                        Battle(player, selected, inRoom);
                    }
                    else
                    {
                        WrongChoice();
                    }
                }
                else
                {
                    WrongChoice();
                }
            }
        }

        public void Battle(Player hero, Ennemy mob, Room inRoom)
        {
            Console.Clear();
            Console.WriteLine("Un combat s'enclenche entre " + hero.Name + " et " + mob.Name + " !");
            Console.ReadKey();
            Console.WriteLine(hero.ShowCharacter());
            Console.WriteLine(mob.ShowCharacter());
            hero.Attack(mob);

            if (mob.CurrentHealth <= 0)
            {
                Console.WriteLine(mob.Name + " est vaincu !");
                Console.ReadKey();
                hero.GainXp(mob);
                inRoom.ennemiesInRoom.Remove(mob);
            }
            else
            {
                Console.WriteLine(mob.Name + " riposte !");
                mob.Attack(hero);                
            }
            
            Console.Clear();
        }
    }
}
