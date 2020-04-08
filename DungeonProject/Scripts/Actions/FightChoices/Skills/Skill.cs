using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Skill
    {
        int cost;
        public int Cost { get => cost;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                cost = value;
            }
        }

        public Skill(int cost)
        {
            this.Cost = cost;
        }

        public virtual void Effect(Player player, Ennemy target)
        {
            player.CurrentPT -= Cost;
        }
    }
}
