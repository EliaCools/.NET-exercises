using System;
using Microsoft.VisualBasic;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
        }

        static void gameTitle()
        {
            Console.WriteLine("Welcome to the adventure game, press enter to continue");
            Console.ReadLine();
            First();
        }

        static void First()
        {
            string choice;

            Console.WriteLine("Where am I? I don't remember what happened last night");
            Console.WriteLine("I seem to be in some sort of forest, no idea what forest though");
            Console.WriteLine("What should I do?");
            Console.WriteLine("1.Look for help");
            Console.WriteLine("2.Look for water");
            Console.WriteLine("3.Build a shelter");
            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "1":
                {
                    Console.WriteLine("As you are desperately looking for help, you wander of");
                    Console.WriteLine("You see a graveyard, with a mysterious tomb");
                   
                    foundTomb();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("You find a river");
                    foundwater();
                    break;
                }
                case "3":
                {
                    Console.WriteLine("You build shelter and go to sleep");
                    sleep();
                    break;
                }
                default:
                {
                    Console.WriteLine("Your option was not selectable, try again");
                    First();
                    break;
                }
            }

            static void sleep()
            {
                string choice;
                Console.WriteLine("You wake up in the middle of the night to some weird chants");
                Console.WriteLine("1. Continue sleeping, better not get involved with whatever that is");
                Console.WriteLine("2. Go investigate");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1" :
                    {
                        Console.WriteLine("You wake up the next day, well rested. Still thinking about those weird noises");
                        Console.WriteLine("You find your way out of the forest");
                        playerWon();
                        break;
                    }
                    case "2":
                    {
                        Console.WriteLine("You go investigate, there seems to be a weird ceremony going on");
                        Console.WriteLine("One of the people sees you, and decides you don't belong to the " +
                                          "land of the living anymore");
                        gameover();
                        break;
                    }
                    
                }

            }

            static void foundwater()
            {
                string choice;
                Console.WriteLine("1.Follow river");
                Console.WriteLine("2.Go set up camp");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    {
                        Console.WriteLine("You followed the river and found a way out of the forest");
                        playerWon();
                        break;
                    }
                    case "2":
                    {
                        Console.WriteLine("You decided to spend the night");
                        Console.WriteLine(
                            "You hear a loud sound, suddenly you see nails sharp as blades coming your way");
                        Console.WriteLine("You close your eyes for one last time");
                        gameover();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("I didn't get that, choose again");
                        foundwater();
                        break;
                    }
                }
            }

            static void foundTomb()
            {
                string choice;
                Console.WriteLine("To enter the tomb you have to input some sort of code");
                Console.WriteLine("1.Enter code");
                Console.WriteLine("2.Keep searching for help");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                    {
                        entercode();
                        break;
                    }
                    case "2":
                    {
                        Console.WriteLine("Maybe I should not be messing with this");
                        Console.WriteLine("You find a village nearby with people who helped you get out this weird place");
                        playerWon();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Please choose again");
                        foundTomb();
                        break;
                    }

                }
                

            }

            static void entercode()
            {
                
                Console.WriteLine("the format says XXXX/XX/XX, maybe I should enter some kind of date in it");
                Console.WriteLine("for fun, lets try out my own birthdate");

                string inputbirthdate;
                inputbirthdate = Console.ReadLine();

                DateTime outputBirthdate;

                if (DateTime.TryParse(inputbirthdate, out outputBirthdate))
                {
                    DateTime today = DateTime.Now;

                    var months = today.Month - outputBirthdate.Month;
                    var age = today.Year - outputBirthdate.Year;
                    if (months < 0)
                    {
                        age = today.Year - outputBirthdate.Year - 1;
                    }

                    Console.WriteLine("you died at age " + age);
                    gameover();
                }
                else
                {
                    Console.WriteLine("invalid format");
                    entercode();
                }
            }


            static void gameover()
            {
                Console.WriteLine("You didn't survive, try again");
            }

            static void playerWon()
            {
                Console.WriteLine("You survived the forest!");
            }
        }
    }
}