using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Program
    {
        static Action action = new Action();

        static void WrongChoice()
        {
            Console.WriteLine("");
            Console.WriteLine("Il faut entrer un choix valide !");
            Console.ReadLine();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Player hero = new Player("Hero", 10, 10, 3, 0, 1);
            Console.WriteLine(hero.ShowCharacter());
            bool nextRoom = false;

            while (!nextRoom)
            {
                Room currentRoom = new Room(10, 10);                

                Console.WriteLine("***************************************");
                Console.WriteLine(hero.ShowCharacter());
                Console.WriteLine("");

                Console.WriteLine("Vous voila dans une nouvelle piéce, que voulez vous faire ?");
                Console.WriteLine("1 : Inspecter la piéce");
                Console.WriteLine("2 : Se déplacer");
                Console.WriteLine("3 : Attaquer un ennemi");
                Console.WriteLine("4 : Ramasser un objet");
                Console.WriteLine("5 : Se reposer dans un lit");
                Console.WriteLine("6 : Utiliser un objet dans l'inventaire");

                string answer = Console.ReadLine();
                if (int.TryParse(answer, out int nombre))
                {
                    switch (nombre)
                    {
                        case 1:
                            currentRoom.InspectRoom();
                            break;
                        case 3:
                            Ennemy mob = currentRoom.ennemiesInRoom[0];
                            Fight fight = new Fight(hero, mob);
                            fight.Battle();
                            break;
                        default:
                            WrongChoice();
                            break;
                    }
                }
                else
                {
                    WrongChoice();
                }                    
            }           
        }        
    }
}
