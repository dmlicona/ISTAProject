//customer's batter choice

using System;

namespace KpopProjectStep10
{
    internal class Batter
    {
        public static string[] batter = { "Chocolate", "Vanilla" };
        public void custBatter (int bChoice)
        {
            if (bChoice == 0)
            {
                Console.WriteLine($"Your batter choice is {batter[0]}. Delicious!");
            }
            else if (bChoice == 1)
            {
                Console.WriteLine($"Your batter choice is {batter[1]}. Our favorite!");
            }
        }
    }
}