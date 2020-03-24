﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    abstract class Potion : Item
    {
        public Potion(string name, int value) : base(name,value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
