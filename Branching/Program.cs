using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement: First line of the program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // --- Weight Check ---
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // If weight exceeds 50, terminate the program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program
            }

            // --- Dimensions Input ---
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // --- Size Check ---
            // Requirement: Check if the sum of dimensions is greater than 50
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program
            }

            // --- Quote Calculation ---
            // Formula: (Width * Height * Length * Weight) / 100
            float product = width * height * length;
            float quote = (product * weight) / 100;

            // --- Final Output ---
            // Displaying the result formatted as a currency ($)
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Keeps the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
