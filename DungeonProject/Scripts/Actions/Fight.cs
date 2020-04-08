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
            return "Start a fight with an ennemy";
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
                Console.WriteLine("You choosed to fight " + pickedEnnemy.Name);
                player.InFight = true;
                Console.ReadKey();

                while (pickedEnnemy.CurrentHealth > 0 && player.CurrentHealth > 0 && player.InFight)
                {
                    Console.Clear();
                    Console.WriteLine("=============> IN FIGHT <============\n");
                    player.ShowCharacter();
                    pickedEnnemy.ShowCharacter();
                    FightChoice pickedChoice = Menu.PickElementFromList<FightChoice>(GameData.FightChoicesList, "\nWhat do you do ?");
                    pickedChoice.Choice(player, pickedEnnemy, inRoom);
                }

                if (pickedEnnemy.CurrentHealth <= 0) //the mob is now dead
                {
                    player.GainXp(pickedEnnemy.XpValue); //the player win mob's xp
                    player.Inventory.GainGold(pickedEnnemy.GoldValue); //the player win mob's gold

                    Console.WriteLine(pickedEnnemy.Name + " has dropped his inventory on the floor of the room !");
                    pickedEnnemy.Inventory.ShowItems();
                    inRoom.itemsInRoom.AddRange(pickedEnnemy.Inventory.items);
                    inRoom.ennemiesInRoom.Remove(pickedEnnemy);
                    Console.ReadKey();
                }
            }
        }
    }
}
