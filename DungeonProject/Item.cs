using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Item
    {
        string name;

        public string Name { get => name; set => name = value; }

        int value;

        public int Value { get => this.value; set => this.value = value; }

        public Item(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }

        public string ShowItem()
        {
            return "     | Objet : " + name + " | Valeur : " + value + " | ";
        }
    }
}
