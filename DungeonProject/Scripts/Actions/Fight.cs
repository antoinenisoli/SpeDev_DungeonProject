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
                    player.ShowCharacter();
                    pickedEnnemy.ShowCharacter();
                    FightChoice pickedChoice = Menu.PickElementFromList<FightChoice>(GameData.FightChoicesList, "What do you do ?");
                    pickedChoice.Choice(player, pickedEnnemy, inRoom);
                }
            }
        }
    }
}
