//customer's frosting choice

using System;

namespace KpopProjectStep10
{
    internal class Frosting
    {
        public static string[] frosting = { "Turquoise", "Orange", "Pink", "Black", "Vibrant Green", "Lavender", "Red", "Royal Blue", "Yellow" };

        public void custFrosting(int fChoice)
        {

            if (fChoice == 0)
            {
                Console.WriteLine($"Your frosting choice is {frosting[0]}. Awesome choice!");
            }
            else if (fChoice == 1)
            {
                Console.WriteLine($"Your frosting choice is {frosting[1]}. Great choice!");
            }
            else if (fChoice == 2)
            {
                Console.WriteLine($"Your frosting choice is {frosting[2]}. Our favorite!");
            }
            else if (fChoice == 3)
            {
                Console.WriteLine($"Your frosting choice is {frosting[3]}. Solid!");
            }
            else if (fChoice == 4)
            {
                Console.WriteLine($"Your frosting choice is {frosting[4]}. Lively choice!");
            }
            else if (fChoice == 5)
            {
                Console.WriteLine($"Your frosting choice is {frosting[6]}. We love this color!");
            }
            else if (fChoice == 6)
            {
                Console.WriteLine($"Your frosting choice is {frosting[6]}. Roses are red and we love roses!");
            }
            else if (fChoice == 7)
            {
                Console.WriteLine($"Your frosting choice is {frosting[7]}. Naval Royalty!");
            }
            else if (fChoice == 8)
            {
                Console.WriteLine($"Your frosting choice is {frosting[8]}. Yellow Mellow!");
            }
        }
    }
}