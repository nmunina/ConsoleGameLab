// v.2.1

using System;

namespace ConsoleGameLab1
{
    public class Game
    {
        // items that user can get
        private bool _hasGrace; // needs to see the Garden locations
        private bool _hasOracle; // needs to see the House locations
        private bool _hasKey;
        private bool _hasSnake;
        private bool _hasCup;
        private bool _hasCookies;
        private bool _hasApple;

        // "Press any key and continue" method
        public void PressAndContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.WriteLine();
            Console.ReadKey(true);
        }

        // show items that user has got
        private void ShowItems()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("You have: ");
            if (_hasSnake)
            {
                Console.Write("Snake ");
            }
            if (_hasCup)
            {
                Console.Write("Cup ");
            }
            if (_hasCookies)
            {
                Console.Write("Cookies ");
            }
            if (_hasApple)
            {
                Console.Write("Apple ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        //show possible locations to the user
        public void GoToLocation()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            if (_hasGrace)
            {
                Console.WriteLine("Type the following keys to navigate outside the house: ");
                Console.WriteLine("To go around the house type a");
                Console.WriteLine("To go inside the house type i");
                Console.WriteLine("To investigate the garden type g");
                Console.WriteLine();
            }
            if (_hasOracle)
            {
                Console.WriteLine("Type the following keys to navigate inside the house: ");
                Console.WriteLine("To talk to the man type t");
                Console.WriteLine("To investigate the bookshelf type b");
                Console.WriteLine("To investigate the window type w");
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        //introduction creates welcome screen and gives basic instructions to a user 
        public void Introduction()
        {
            Console.Clear(); // clear all information that was on the screen
            Console.WriteLine("You wake up on the cloud and see an old woman near the small house.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("“Hello, my friend! My name is Grace and I would like to welcome to the unreal world!”");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Say “Hello” to Grace Hopper.");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("“You are here because you would like to know more about programing.Follow the instructions, find the artifacts, solve the problems, fight the monster and you would get the price”, - says the woman."); // char speach
            Console.ResetColor();

            _hasGrace = true;

            PressAndContinue();
        }

        //quest "Well" to get the key to the House
        public void Well()
        {
            Console.Clear();
            Console.WriteLine("You find the old well in the backyard. Out of the well comes angry Cotopus(it looks like a baby of a cat and octopus).");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("“I am very famous in the software world. Can you guess how many people I know”.");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Guess the number to get the prize.");
            Console.WriteLine();

            //fight octopus. >37000000 winns
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                String input = Console.ReadLine();
                int gitHub;
                Console.ResetColor();

                bool success = Int32.TryParse(input, out gitHub);
                if (!success)
                {
                    Console.WriteLine("Write a NUMBER!");
                    continue;
                }

                if (gitHub < 0)
                {
                    Console.WriteLine("Try a positive number");
                    continue;
                }
                
                if (gitHub < 37000000)
                {
                    Console.WriteLine();
                    Console.WriteLine("Try a much bigger number.");
                    Console.WriteLine();
                    Console.WriteLine("If you want to get the hint, type Y. Otherwise type any key.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    String hint = Console.ReadLine();
                    Console.ResetColor();

                    if (hint.ToLower() == "y")
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Try a number larger than 37 mln.");
                        Console.ResetColor();
                        Console.WriteLine();
                    }

                    continue;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Yes. You can call me GitHub, and in May 2019 GitHub had over 37 million users and more than 100 million repositories. Here is your prise.");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Congratulations! You get the KEY.");

                _hasKey = true; // user has received the key to enter the house

                PressAndContinue();

                break;
            }
        }

        //quest "Gnome"
        public void Gnome()
        {
            Console.Clear();
            Console.WriteLine("You find the garden gnome. Near the gnome sits a snake.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen; 
            Console.WriteLine("“I will help you one day. Take me with you”, - tells you the snake.");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("You take the snake and continue.");

            _hasSnake = true; // user has received the snake to fight the final boss

            PressAndContinue();
        }

        //quest "House" (with allied quests "Window", "Voldemort", "Oracle" and subquests "Cassandra", "Scrum")
        public void House()
        {
            Console.Clear();
            
            if (!_hasKey) // we check is the user has the key to enter the house
            {
                Console.WriteLine("You need a key to enter the house.");
                PressAndContinue();
            
                return;
            }

            // if the user has key, he can see description of the location "House"
            Console.Clear();
            _hasOracle = true;
            Console.WriteLine("The door opens and you see an old man in red clothes in the middle of the room. To the right you see the bookshelf, to the left the window.");
            Console.WriteLine();
            _hasGrace = false;
            PressAndContinue();
        }

        //quest "Window" (part of "House")
        public void Window()
        {
            Console.Clear();
            Console.WriteLine("There is just an old spiderweb on the window and the dirty coffee cup. You take the cup before anybody sees you.");
            _hasCup = true;

            PressAndContinue();
        }

        //quest "Voldemort" (part of "House")
        public void Voldemort()
        {
            Console.Clear();
            Console.WriteLine("On a bookshelf you find a Harry Potter book. You open the book to leaf through. Suddenly a note falls out.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("“Do you know that they made distributed data store from me? LinkedIn uses it now. Can you guess my name?” - read you on the note.");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Guess the name to get the prize.");

            int lives = 4;

            while (lives > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                String dbName = Console.ReadLine();
                Console.ResetColor();

                if (dbName.ToLower() != "voldemort")
                {
                    Console.WriteLine("WRONG!");
                    Console.WriteLine($"You have {lives} attempts left.");
                    Console.WriteLine();
                    Console.WriteLine("If you want to get the first hint, type 1.");
                    Console.WriteLine("If you want to get the second hint, type 2.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    String hintDB = Console.ReadLine();
                    Console.ResetColor();
                    lives--;

                    switch (hintDB)
                    {
                        case "1":
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Distributed data store means that information about me is stored in different places.");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;
                        case "2":
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("I’m the fictional Harry Potter villain.");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You are right! Project Voldemort is my name. Come to the dark side. We have cookies.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Some cookies appear on the bookshelf. You take them with you.");

                    _hasCookies = true; // user has received the cookies for the Oracle
                    PressAndContinue();

                    return;
                }
            }

            Console.WriteLine("AVADA KEDAVRA! You have died.");
            Environment.Exit(0); //end the game
        }

        //quest "Oracle" (part of the "House")
        public bool Oracle()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("“Hello! - says the old man. - What are you looking for? I’m looking for my friend. Can you help me to find him?”");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("You show collected items to the old man");

            ShowItems();

            if (!_hasCookies)
            {
                Console.WriteLine("You can not help me. Probably you could come later?");

                PressAndContinue();
                return false;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Wonderful. He loves cookies. That's what I needed!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Penguin comes from the small door your have not noticed before and eats your cookies.");
            _hasCookies = false;
            Console.WriteLine();
            Console.WriteLine("You say bye to the old man and go through the door.");

            PressAndContinue();
            return true; // after this user can continue to Cassandra quest
        }

        //quest "Cassandra"
        public void Cassandra()
        {
            Console.Clear();
            Console.WriteLine("In the next room you see a young beautiful woman with blue eyes");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("“Hello stranger, - says the woman. - My name is Cassandra. I’m trying to make something useful from this whip. Can you help me?”");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press any key to help her");
            Console.WriteLine();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("“You should throw the dice until you'd be lucky enough.”");
            Console.ResetColor();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Press any key to throw the dice");
                Console.ReadKey(true);

                Random random = new Random();
                int dice = random.Next(1, 50);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(dice);
                Console.ResetColor();

                if (dice >= 35)
                {
                    _hasApple = true;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("“Thank you! What a wonderful loop you made!” - says Cassandra. - Here is a prise from me. Now you are ready!”");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Cassandra gives you an apple and shows the way to the final battle.");
                    Console.WriteLine();

                    PressAndContinue();
                    break;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Please, try again!");
                Console.ResetColor();
            }
        }

       //quest "Scrum" (final boss)
       public void Scrum ()
        {
            var hpScrum = 1000;
            var hpPlayer = 800;

            Console.Clear();
            Console.WriteLine("By this time you should have 3 things in your bag that would help you to fight the boss. Have a look");
            Console.WriteLine();
            ShowItems();
            Console.WriteLine();
            Console.WriteLine("If you want to begin from the beginning, type y. Otherwise type any key to fight the boss.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            String fightBoss = Console.ReadLine();
            Console.ResetColor();

            if (fightBoss != null && fightBoss.ToLower() == "y")
            {
                Introduction();
            }

            Console.WriteLine("You are going to fight SCRUM monster");
            Console.WriteLine("You have " + hpPlayer + " health points, monster has " + hpScrum + " health points.");

            //fight the Scrum moster
            //User and monster have some Health Points (HP) in the begining of the game
            //User can use items to harm the monster. Each item may be used once
            //Monster fights back with the randome damage
            //User can also randomly damage the boss
            //After every interation user can see how many HP is left
            while (hpPlayer > 0 && hpScrum > 0)
            {
                Console.WriteLine("You may use one of your items. Print items name, if you want to use it.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                var item = Console.ReadLine();
                Console.ResetColor();
                Random random = new Random();
                int fightScrum = random.Next(1, 200);

                if (item.ToLower() == "snake")
                {
                    Console.WriteLine("Snake turns out to be a python. It bites the SCRUM monster.");
                    hpScrum -= 300;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Monster loses points. SCRUMs HP are " + hpScrum);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Scrum monster fights back!");
                    hpPlayer -= fightScrum;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Your HP are " + hpPlayer);
                    Console.ResetColor();
                    _hasSnake = false;
                    PressAndContinue();
                }

                else if (item.ToLower() == "cup")
                {
                    Console.WriteLine("Turns out to be Java application that stops the SCRUM monster. He becomes blue and loses some health.");
                    hpScrum -= 200;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Monster becomes blue and loses some HP. SCRUMs HP now are " + hpScrum);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Scrum monster fights back!");
                    hpPlayer -= fightScrum;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Your HP are " + hpPlayer);
                    Console.ResetColor();
                    _hasCup = false;
                    PressAndContinue();
                }

                else if (item.ToLower() == "apple")
                {
                    Console.WriteLine("You see $$ in monsters eyes and he loses health points.");
                    hpScrum -= 100;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("SCRUMs HP now are " + hpScrum);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Scrum monster fights back!");
                    hpPlayer -= fightScrum;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Your HP are " + hpPlayer);
                    Console.ResetColor();
                    _hasApple = false;
                    PressAndContinue();
                }

                Console.WriteLine("Throw the dice to fight monster");
                hpScrum -= fightScrum;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("SCRUMs HP now are " + hpScrum);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Scrum monster fights back!");
                hpPlayer -= fightScrum;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Your HP are " + hpPlayer);
                Console.ResetColor();
            }

            if (hpPlayer <= 0) //user dies
            {
                Console.Clear();
                Console.WriteLine("Sorry. SCRUM monster has beaten your deadlines. Try next time.");
                Environment.Exit(0); //end the game
            }

            if (hpScrum <= 0) //user winns
            {
                Console.Clear();
                Console.WriteLine("Congratulations! SCRUM monster goes banana and you see the glowing chest behind him.");
                Console.WriteLine("You open the chest and see  “The Art of Computer Programming” by Donald Knuth. All the four volumes.");
                Console.WriteLine("The dying monster laughs. You have won but you can not live the cloud before you read all the Knuts monograph.");
                Environment.Exit(0); //end the game
            }
        }
    }
}

