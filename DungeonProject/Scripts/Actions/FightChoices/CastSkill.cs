using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class CastSkill : FightChoice
    {
        public override string ToString()
        {
            return "Use a skill";
        }

        public override void Choice(Player player, Ennemy mob, Room inRoom)
        {
            Skill pickedSkill = Menu.PickElementFromList(GameData.SkillList, "\nWhich skill do you want to cast ?");
            
            if (player.CurrentPT >= pickedSkill.Cost)
            {
                pickedSkill.Effect(player, mob);
                mob.Attack(player);
            }
            else
            {
                Console.WriteLine(player.Name + " don't have enough PT !");
                Console.ReadKey();
            }
        }
    }
}
