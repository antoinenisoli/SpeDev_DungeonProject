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
            if (inRoom.ennemiesInRoom.Count == 0)
            {
                Console.WriteLine("There is no ennemies in this room !");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Ennemy pickedEnnemy = Menu.PickElementFromList<Ennemy>(inRoom.ennemiesInRoom, " Which ennemy do you want to fight ? ");
                Battle(player, pickedEnnemy, inRoom);
            }
        }

        public void Battle(Player hero, Ennemy mob, Room inRoom) //fight between a character and his opponent
        {
            Console.Clear();
            Console.WriteLine("Un combat s'enclenche entre " + hero.Name + " et " + mob.Name + " !");
            Console.ReadKey();
            Console.WriteLine(hero.ShowCharacter());
            Console.WriteLine(mob.ShowCharacter());
            hero.Attack(mob);

            if (mob.CurrentHealth <= 0)
            {                
                hero.GainXp(mob.XpValue);
                hero.inventory.GainGold(mob.GoldValue);
                inRoom.ennemiesInRoom.Remove(mob);
                mob.inventory.GiveLoot(hero);
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
