using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Action
    {
        public Action()
        {
            
        }

        public virtual void Execute(Player player, Room inRoom)
        {

        }

        public void WrongChoice()
        {
            Console.WriteLine("");
            Console.WriteLine("Your choice must be valid !");
            Console.ReadLine();
        }
    }    
}
