﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class PotionTechnique : Potion
    {
        public PotionTechnique(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}