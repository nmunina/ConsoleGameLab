using System;

namespace ConsoleGameLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new game
            Game quest = new Game();
  
            quest.Introduction();// starting the Introduction method

            // GARDEN. Main location
            Console.Clear();
            Console.WriteLine("You stand in front of the small house.");

            while (true)
            {
                quest.GoToLocation();

                Console.ForegroundColor = ConsoleColor.DarkBlue; // сhange players speech color to Dark Blue
                String direction = Console.ReadLine(); // dialog imitation
                Console.ResetColor();
                Console.WriteLine();

                switch (direction.ToLower())
                {
                    case "a":
                        quest.Well();
                        break;
                    case "g":
                        quest.Gnome();
                        break;
                    case "i":
                        quest.House();
                        break;
                    case "b":
                        quest.Voldemort();
                        continue;
                    case "w":
                        quest.Window();
                        continue;
                    case "t":
                    {
                        if (quest.Oracle()) // if boolean Oracle is true, user can continue
                        {
                            quest.Cassandra();
                            quest.Scrum(); //final boss. End of the game
                        }

                        break;
                    }
                }
            }
        }
    }
}