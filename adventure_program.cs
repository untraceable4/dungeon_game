/*
 * Dungeon Crawling Adventure Game
 * by Nathaniel Mick, 2/25/20
 * 
 * This work is a derivative of:
 * http://programmingisfun.com/learn/c-sharp-adventure-game/c_sharp_05_classes_objects/
 * 
 */

// Hey, when you want to share this with someone, use this command:
// dotnet "publish" -r win-x64 -c Release "c:\Users\Nathaniel Mick\CU Boulder\C#\dungeon_game\dungeon_crawling_game.sln" -p:PublishSingleFile=true
// Big file for big programs

using System;

namespace Adventure
{
    public static class Game 
    {
        static string characterName = ""; // Define name as an empty string
        static int scenarios = 2; // Establish the number of scenes
        static string[] partOne = { // This string array contains all the text in the game (well, almost all)
            "You've been ordered to save the blacksmith's daughter.\nThe goblins have taken her to their hideout, which you have just located.\nYou must be prepared to fight; there may be danger ahead.\n", // 0
            "You sneak through  the dungeon. However, ahead you spot a single goblin down the hallway.", 
            "Do you want [fight] or [sneak past]?", 
            "You've chosen to fight! But, you forgot your sword. The goblin turns around and kills you.", 
            "You've chosen to sneak past! The goblin is distracted on his new noise-cancelling AirPods, so you go right past without issue", 
            "Once past the goblin, you arrive at the main room in the dungeon. \nThere are two more goblins, both looking away, and the blacksmith's daugher in chains.", 
            "You can [fight] or you can [sneak past].", 
            "You've chosen to fight! The goblins in this room don't have swords, so with your awesome karate skills you manage to overpower them.", 
            "You've chosen to sneak past! However, this goblins aren't wearing new AirPods, so they easily hear and kill you.", 
            "You unchain the blacksmith's daughter and bring her back to the village. You're the hero!" 
        };

        // print title, and run the game
        public static void StartGame()
        {
            string title = "Nathaniel's Dungeon Crawling Game"; // Set the title for the game
            Console.WriteLine($"{title.ToUpper()} \n"); // Print the title in all upper-case
            Console.WriteLine("This game takes palce in a dungeon. \nYour goal is to reach the end and find the treasure. \nYou lose by dying."); // Brief description of the game
            NameCharacter(); // call the method Name Character
            Choice();
            EndGame();
        }

        public static void EndGame()
        {
            Console.WriteLine("Game over!"); // Establish an end screen
        }

        // ask for player name and save it   
        static void NameCharacter()
        {
            Console.WriteLine("What is your name?");
            characterName = Console.ReadLine(); // Wait for user to inupt a string as their name
            Console.WriteLine($"Your name is {characterName}!"); // Refirm their choice
            // Console.WriteLine("Your name is " + characterName); // this also works
        }

        // Setting method for player choices
        static void Choice()
        {

        // this for loop contains all the code that runs the game
        for (int section = 1; section <= scenarios; section++)
            {
                string input = "";

                switch (section)
                {

                    case 1:

                        // Part 1
                        Console.WriteLine(partOne[0]); // Print out the initial statement
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.WriteLine(partOne[1]);
                        Console.ForegroundColor = ConsoleColor.Green; // change console color for the user-recommended inputs
                        Console.WriteLine(partOne[2]);
                        Console.ResetColor();
                        input = Console.ReadLine();
                        input = input.ToUpper();

                        if (input == "FIGHT")
                        {
                            Console.WriteLine(partOne[3]);
                            break; // The loop ends because you die
                
                        }

                        else
                        {
                            Console.WriteLine(partOne[4]);
                        }
                        
                        Console.WriteLine(partOne[5]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(partOne[6]);
                        Console.ResetColor();
                        input = Console.ReadLine();
                        input = input.ToUpper();

                        if (input == "FIGHT")
                        {
                            Console.WriteLine(partOne[7]);
                        }
                        else
                        {
                            Console.WriteLine(partOne[8]);
                            break; // the loop ends because you die
                        }

                        Console.WriteLine(partOne[9]);

                    break;

                    default:
                    // if scenario != 1 || 2
                    break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
 
    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        } 
    }
}