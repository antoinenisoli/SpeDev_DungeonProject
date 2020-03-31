using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Equipment : Item
    {
        int bonus;

        public int Bonus { get => bonus;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                bonus = value;
            }
        }

        public Equipment(string name, int value, int bonus) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
            this.Bonus = bonus;
        }
    }
}
