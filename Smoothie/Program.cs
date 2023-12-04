using System;
using System.Collections.Generic;

class SmoothieMachine
{
    static void Main()
    {
        // Define a dictionary to store ingredients for each smoothie
        Dictionary<string, List<string>> smoothieIngredients = new Dictionary<string, List<string>>
        {
            {"Berry Blast", new List<string>{"Berries", "Banana", "Yogurt", "Milk"}},
            {"Green Machine", new List<string>{"Spinach", "Kale", "Apple", "Banana", "Orange Juice"}},
            {"Tropical Paradise", new List<string>{"Mango", "Pineapple", "Coconut Water"}},
            // Add more smoothies and ingredients as needed
        };

        Console.WriteLine("Welcome to the Smoothie Machine!");

        while (true)
        {
            Console.Clear(); // Clear the console screen

            // Display the list of available smoothies
            Console.WriteLine("Choose a smoothie:");

            foreach (var smoothie in smoothieIngredients.Keys)
            {
                Console.WriteLine(smoothie);
            }

            // Get user input for smoothie selection
            Console.Write("Enter the name of the smoothie (or type 'exit' to quit): ");
            string selectedSmoothie = Console.ReadLine();

            if (selectedSmoothie.ToLower() == "exit")
            {
                break; // Exit the loop if the user types 'exit'
            }

            // Check if the selected smoothie exists in the dictionary
            if (smoothieIngredients.ContainsKey(selectedSmoothie))
            {
                // Display the ingredients for the selected smoothie
                Console.Clear(); // Clear the console screen
                Console.WriteLine($"Ingredients for {selectedSmoothie}:");
                foreach (var ingredient in smoothieIngredients[selectedSmoothie])
                {
                    Console.WriteLine("- " + ingredient);
                }
            }
            else
            {
                Console.WriteLine("Invalid smoothie selection. Please choose a valid smoothie.");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine(); // Pause before continuing to the next iteration
        }

        Console.WriteLine("Thank you for using the Smoothie Machine!");
    }
}
