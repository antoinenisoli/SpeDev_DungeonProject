using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    abstract class Character
    {
        public Inventory inventory = new Inventory();

        public string name;
        private int currentHealth;
        private int maxHealth;
        private int force;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Il faut un nom valide !");
                }

                name = value;
            }
        }

        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }

            set
            {
                Console.WriteLine(value);

                if (value <= 0)
                {
                    value = 0;
                    Console.WriteLine("mort");
                }

                if (value > MaxHealth)
                {
                    value = MaxHealth;
                    Console.WriteLine("max");
                }
            }
        }

        public int MaxHealth { get => maxHealth;
            set
            {
                maxHealth = value;
            }
        }

        public int Force { get => force;
            set
            {
                if (force < 0)
                {
                    value = 0;
                }
            }
        }

        public Character(string name, int currentHealth, int maxHealth, int force)
        {
            this.Name = name;
            this.CurrentHealth = currentHealth;
            this.MaxHealth = maxHealth;
            this.Force = force;
            
        }

        public int GetLife()
        {
            return currentHealth;
        }

        public abstract string ShowCharacter();

        public void ShowInventory()
        {
            inventory.ShowInventory();
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
            target.CurrentHealth -= damage;
        }
    }
}
