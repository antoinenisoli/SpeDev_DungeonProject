using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class IceRay : Skill
    {
        public override string ToString()
        {
            return "ICE RAY " + "[" + Cost + "PT]" + " (Freeze and break the target's armor)";
        }

        public IceRay(int cost) : base(cost)
        {

        }

        public override void Effect(Player player, Ennemy target)
        {
            base.Effect(player, target);
            Console.WriteLine(player.Name + " shoot a incredibly powerful ice beam on his target !");
            Console.ReadKey();
            
            if (target.Inventory.CurrentArmor.Value > 0)
            {
                Console.WriteLine("\nIt instantly destroy his armor !");
                Console.ReadKey();
                Armor destroyedArmor = target.Inventory.CurrentArmor;
                destroyedArmor.Value = 0;
                target.Inventory.currentEquipment.Remove(destroyedArmor);
            }
            else
            {
                Console.WriteLine("\nHe doesn't have a armor, that spell is uneffective on him !");
                Console.ReadKey();
            }
        }
    }
}
