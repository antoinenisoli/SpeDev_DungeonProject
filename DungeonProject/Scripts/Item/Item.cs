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

        public override string ToString()
        {
            return " | Item : " + name + " | Value : " + value + " | ";
        }        

        public virtual void GiveTo(Character chara)
        {
            chara.Inventory.items.Add(this);
        }

        public virtual void Effect(Player player)
        {
            Console.WriteLine("\n" + player.Name + " use a " + Name + " !");
        }

        public virtual void Restore(Player player, string unitValue, string valueName)
        {            
            
        }
    }
}
