using System;

namespace Progpoe_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calls information from recipe class
            Recipe recipe = new Recipe();

            //Helps Exit the program after user inputs the number 0
            bool exit = false;

            Console.WriteLine("Welcome to my Recipe Application");

            while (!exit)
            {
                // Display options for user
                Console.WriteLine("Enter your option:");
                Console.WriteLine("1. Enter Recipe details");
                Console.WriteLine("2. Display Recipe");
                Console.WriteLine("3. Scale Recipe");
                Console.WriteLine("4. Reset Recipe");
                Console.WriteLine("5. Clear Recipe");
                Console.WriteLine("6. Quit");

                //Stores input of the user
                string userInput = Console.ReadLine();
                Console.WriteLine();

                //Uses whatever value the user inputs to display methods from the Recipe class
                switch (userInput)
                {
                    case "1":
                        recipe.EnterRecipedetails();
                            break;
                    case "2":
                        recipe.DisplayRecipe();
                        break;
                    case "3":
                        recipe.ScaleRecipe();
                        break;
                    case "4":
                        recipe.ReseRecipe();
                        break;
                    case "5":
                        recipe.ClearRecipeData();
                        break;
                    case "6":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Option incorrect! Please try again");
                        break;
                }
            }
        }
    }
}
