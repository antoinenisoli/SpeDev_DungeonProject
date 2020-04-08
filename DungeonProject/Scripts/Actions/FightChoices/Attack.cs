using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Attack : FightChoice
    {
        public override string ToString()
        {
            return "Attack the opponent with a simple blow";
        }

        public override void Choice(Player player, Ennemy mob, Room inRoom)
        {
            base.Choice(player, mob, inRoom);
            Console.Clear();
            Console.WriteLine(player.Name + " attack " + mob.Name + " !");
            Console.ReadKey();            
            player.Attack(mob);

            if (mob.CurrentHealth <= 0)
            {
                player.GainXp(mob.XpValue); //the player win mob's xp
                player.Inventory.GainGold(mob.GoldValue); //the player win mob's gold

                Console.WriteLine(mob.Name + " has dropped his inventory on the floor of the room !");
                mob.Inventory.ShowItems();
                inRoom.itemsInRoom.AddRange(mob.Inventory.items);
                inRoom.ennemiesInRoom.Remove(mob);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(mob.Name + " strikes back !");
                mob.Attack(player);
            }

            Console.Clear();
        }
    }
}
