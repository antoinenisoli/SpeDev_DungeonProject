using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class PotionHeal : Item
    {
        public PotionHeal(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override void Effect(Player player)
        {            
            Restore(player, "pv", "health");
        }

        public override void Restore(Player player, string unitValue, string valueName)
        {
            if (player.CurrentHealth < player.MaxHealth)
            {
                Console.WriteLine("It restores him " + Value + " " + unitValue + " !\n");
                Console.ReadKey();
                player.CurrentHealth += Value;
                player.Inventory.items.Remove(this);
            }
            else
            {
                Console.WriteLine("Your " + valueName + " is already full !\n");
                Console.ReadKey();
            }
        }
    }
}
