using System;

namespace Progpoe_part1
{
    internal class Recipe
    {
        private int i;

        public string[] IngredientsName { get; set; }
        public string[] IngredientsQuantities { get; set; }
        public string[] IngredientsUnits { get; set; }
        public int NumIngredients { get; set; }
        public int NumSteps { get; set; }
        public string[] Steps { get; set; }

        public Recipe()
        {
            NumIngredients = 0;
            NumSteps = 0;
        }

        public void EnterRecipeDetails()
        {
            //Allows user to input the number of Ingredients that will be used
            Console.Write("Enter the number of Ingredients");
            NumIngredients = Int32.Parse(Console.ReadLine());

            IngredientsName = new string[NumIngredients];
            IngredientsQuantities = new string[NumIngredients];
            IngredientsUnits = new string[NumIngredients];

            //for loop to store ingredients after the input from user
            for(int i=0; i< NumIngredients; i++)
            {
                //Ask user for Ingredient Name and then read user's input
                Console.Write($"Enter Ingredient {i+1} Name:");
                IngredientsName[i] = Console.ReadLine();

                //Ask user for Ingredient Quantity
                Console.Write($"Enter Ingredient {i + 1} Quantity:");
                IngredientsQuantities[i] = Console.ReadLine();

                //Ask user for Ingredient Unit of measurement
                Console.Write($"Enter Ingredient {i + 1} Unit of Measurement:");
                IngredientsQuantities[i] = Console.ReadLine();
            }

            //Asks user the number of steps and then read user's input
            Console.Write("Enter Nuumber of Steps:");
            NumSteps = Int32.Parse(Console.ReadLine());
            Steps = new string[NumSteps];

            //Loop to store the number of steps after being input by the user
            for(int i = 0; i<NumSteps; i++)
            {
                Console.Write($"Enter steps {i + 1}:");
                Steps[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Recipe details Entered successfully");
            Console.WriteLine();
        }
        // Display Recipe and steps after user has entered the details
        public void DisplayRecipe()
        {
            Console.WriteLine("------------------------------------");
            //For loop to display Recipe

            Console.WriteLine("Recipe:");
            for (int i = 0; i < NumIngredients; i++) ;
            {
                int i = 0;
                Console.WriteLine($"{IngredientsQuantities[i]}{IngredientsUnits[i]} of {IngredientsName[i]}");
            }
            //Fpr loop to display steps after getting input from user
            Console.WriteLine("Steps:");
            for (int i = 0; i < NumSteps; i++) ;
            {
                Console.WriteLine($"{Steps[i]}");
            }

            Console.WriteLine("-----------------");
            Console.WriteLine();
        }
        // Method scales recipe by the factor 0.5, 2 or 3

        public void ScaleRecipe()
        {
            Console.Write("Enter scalling factor(0.5, 2 or 3):");
            double scalingFactor = double.Parse(Console.ReadLine());


            for (int i = 0; i < NumIngredients; i++) ;
            {
                IngredientsQuantities[i] *= scalingFactor;
            }
            Console.WriteLine();
            Console.WriteLine("*Recipe has been scaled*");
            Console.WriteLine();
        }

        //Method to Reset Ingredient Quantities back to their original values after being scaled
        public void ResetRecipe()
        {
            //Integers used as divisors to reset Ingredient quantities back original values
            double a = 0.5;
            int b = 2;
            int c = 3;

            for (int i = 0; i < IngredientsQuantities.Length; i++) ;
            {
                //If statement for scaled factors used in ScaleRecipe() method to divide quantities back to original
                if (IngredientsQuantities[i] == a)
                {
                    IngredientsQuantities[i] /= a;
                }
                else if (IngredientsQuantities[i] ==b)
                {
                    IngredientsQuantities[i] /= b;
                }
                else 
                {
                    IngredientsQuantities[i] /= c;
                }
            }

            Console.WriteLine("*Recipe has been Reset*");
            Console.WriteLine();
        }

        //Method which clears recipe entered by the user
        public void ClearRecipeData()
        {
            //Sets arrays to null which clears recipe data
            IngredientsName = new string[0];
            IngredientsQuantities = new double[0];
            IngredientsUnits = new string[0];
            Steps = new string[0];

            Console.WriteLine("*Recipe cleared*");
            Console.WriteLine();
            Console.WriteLine("Please Re-Enter Recipe details by selecting (1) again");
            Console.WriteLine();
        }
    }
}