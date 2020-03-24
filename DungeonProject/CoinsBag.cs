﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class CoinsBag : Item
    {
        public CoinsBag(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public void GoldGain(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine(player.name + " a gagné " + Value + " piéces d'or !");
            Console.WriteLine("");
            Console.ReadKey();
            
            player.inventory.currentGold += Value;
        }
    }
}
