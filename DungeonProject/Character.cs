using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Character
    {
        public Inventory inventory = new Inventory();

        public string name;
        public int currentHealth;

        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }

            set
            {
                if (value <= 0)
                {
                    currentHealth = 0;
                    Console.WriteLine("mort");
                }

                if (value > maxHealth)
                {
                    value = maxHealth;
                }
            }
        }

        public int maxHealth;
        public int force;

        public Character(string name, int maxHealth, int force)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            this.force = force;
            currentHealth = this.maxHealth;
        }

        public int GetLife()
        {
            return currentHealth;
        }

        public virtual string ShowCharacter()
        {
            return null;
        }

        public virtual void ShowInventory()
        {
            
        }

        public void Attack(Character target)
        {
            int damage = force;
            Console.WriteLine("");
            Console.WriteLine("////////////");
            Console.WriteLine(name + " inflige " + damage + " points de dégâts à " + target.name);
            Console.WriteLine("////////////");
            Console.WriteLine("");
            Console.ReadKey();
            target.currentHealth -= damage;
        }
    }
}
