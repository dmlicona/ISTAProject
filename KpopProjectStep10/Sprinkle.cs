//customer's sprinkle choice

using System;

namespace KpopProjectStep10
{
    internal class Sprinkle
    {
        public static string[] sprinkle = { "Purple Pony Party", "Roller Disco", "Little Blue", "Hop Scotch", "LoL Sprinkle" };

        public void custSprikle(int sChoice)
        {

            if (sChoice == 0)
            {
                Console.WriteLine($"Your sprinkle choice is {sprinkle[0]}. We love ponies!");
            }
            else if (sChoice == 1)
            {
                Console.WriteLine($"Your sprinkle choice is {sprinkle[1]}. Right on!");
            }
            else if (sChoice == 2)
            {
                Console.WriteLine($"Your sprinkle choice is {sprinkle[2]}. Bright blue skies!");
            }
            else if (sChoice == 3)
            {
                Console.WriteLine($"Your sprinkle choice is {sprinkle[3]}. Our favorite game!");
            }
            else if (sChoice == 4)
            {
                Console.WriteLine($"Your sprinkle choice is {sprinkle[4]}. LOL!");
            }
        }
    }
}