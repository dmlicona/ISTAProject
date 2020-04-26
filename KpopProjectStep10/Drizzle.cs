//customer's drizzle choice

using System;

namespace KpopProjectStep10
{
    internal class Drizzle
    {
        public static string[] drizzle = { "Turquoise", "Orange", "Pink", "Black", "Vibrant Green", "Lavender", "Red", "Royal Blue", "Yellow" };

        public void custDrizzle(int dChoice)
        {

            if (dChoice == 0)
            {
                Console.WriteLine($"Your drizzle choice is {drizzle[0]}. Awesome choice!");
            }
            else if (dChoice == 1)
            {
                Console.WriteLine($"Your drizzle choice is {drizzle[1]}. Great choice!");
            }
            else if (dChoice == 2)
            {
                Console.WriteLine($"Your drizzle choice is {drizzle[2]}. Our favorite!");
            }
            else if (dChoice == 3)
            {
                Console.WriteLine($"Your drizzle choice is {drizzle[3]}. Solid!");
            }
            else if (dChoice == 4)
            {
                Console.WriteLine($"Your drizzle choice is {drizzle[4]}. Lively choice!");
            }
            else if (dChoice == 5)
            {
                Console.WriteLine($"Your drizzle choice is {drizzle[6]}. We love this color!");
            }
            else if (dChoice == 6)
            {
                Console.WriteLine($"Your drizzle choice is {drizzle[6]}. Roses are red and we love roses!");
            }
            else if (dChoice == 7)
            {
                Console.WriteLine($"Your drizzle choice is {drizzle[7]}. Naval Royalty!");
            }
            else if (dChoice == 8)
            {
                Console.WriteLine($"Your drizzle choice is {drizzle[8]}. Yellow Mellow!");
            }
        }
    }
}