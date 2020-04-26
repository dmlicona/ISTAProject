using System;

namespace KpopProjectStep10
{
    class Program
    {
        static void makeOrder()
        {
            Start:
            Console.WriteLine("Enter '0' to exit, '1' to know more about us or '2' to build your cake pop");
            int userinput = int.Parse(Console.ReadLine());

            if (userinput == 0)
            {
                Console.WriteLine("Thank you for visiting us!");
                System.Environment.Exit(1);
            }
            else if (userinput == 1)
            {
                Console.WriteLine("Two little entrepreneurs, doing what we love, to earn money to go on our dream vacation: Disney World & Universal Studios. Thank you for the support!");
                Console.WriteLine();
                Console.WriteLine("Enter '0' to exit, '3' to go back");
                int newinput = int.Parse(Console.ReadLine());
                if (newinput == 0)
                {
                    Console.WriteLine("Thank you for visiting us!");
                    System.Environment.Exit(1);
                }
                else if (newinput == 3)
                {
                    goto Start;
                }
            }
            else if (userinput == 2)
            {
            start1:
                Customer newUser = new Customer();
                Console.WriteLine("Great! Please enter your first name:");
                string cfName = Console.ReadLine();
                Console.WriteLine("Please enter your last name:");
                string clName = Console.ReadLine();
                newUser.Name(cfName, clName);
                Console.WriteLine();
                Console.WriteLine("Enter a phone number to contact you:");
                string phone = Console.ReadLine();
                newUser.custPhone(phone);
                Console.WriteLine();
                Console.WriteLine("Enter your city:");
                string cCity = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Enter your state:");
                string cState = Console.ReadLine();
                newUser.custAdd(cCity, cState);
                Console.WriteLine();
                Console.WriteLine("Your contact information is: ");
                Console.WriteLine($"{cfName} {clName}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"{cCity} {cState}");
                Console.WriteLine();
                Console.WriteLine("Is this correct? Please enter '1' for yes or '2' to make changes.");
                int nameValid = int.Parse(Console.ReadLine());
                if (nameValid == 2)
                    goto start1;
                else if (nameValid == 1)
                    Console.WriteLine();
                Console.WriteLine($"Got it {cfName} {clName}. Let's design your cake pop!");

                Console.WriteLine();

            batterStart:
                Console.WriteLine("Step 1: Choose your batter");
                Console.WriteLine("Enter '0' for chocolate or '1' for vanilla");
                int custBat = int.Parse(Console.ReadLine());

                Batter newBatter = new Batter();
                newBatter.custBatter(custBat);
                Console.WriteLine();

                Console.WriteLine("Enter 1 to continue to the next step or 2 to go back");
                int batValid = int.Parse(Console.ReadLine());
                if (batValid == 2)
                    goto batterStart;
                else if (batValid == 1)
                    Console.WriteLine($"Got it {cfName} {clName}. Let's pick some fun frosting color!");

                Console.WriteLine();

            frostingStart:
                Console.WriteLine("Step 2: Choose your frosting color");
                Console.WriteLine();
                Console.WriteLine("Enter '0' for Turquoise");
                Console.WriteLine("Enter '1' for Orange");
                Console.WriteLine("Enter '2' for Pink");
                Console.WriteLine("Enter '3' for Black");
                Console.WriteLine("Enter '4' for Vibrant Green");
                Console.WriteLine("ENter '5' for Lavender");
                Console.WriteLine("Enter '6' for Red");
                Console.WriteLine("Enter '7' for Royal Blue");
                Console.WriteLine("Enter '8' for Yellow");
                int custFrost = int.Parse(Console.ReadLine());
                Frosting newFrost = new Frosting();
                newFrost.custFrosting(custFrost);
                Console.WriteLine();

                Console.WriteLine("Enter 1 to continue to the next step or 2 to go back and change your choice");
                int frostValid = int.Parse(Console.ReadLine());
                if (frostValid == 2)
                    goto frostingStart;
                else if (frostValid == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Got it {cfName} {clName}.");
                }
                Console.WriteLine();

                Console.WriteLine($"Your cake pop design currently has:");
                Console.WriteLine();
                Console.WriteLine("Batter: " + Batter.batter[custBat]);
                Console.WriteLine("Frosting color: " + Frosting.frosting[custFrost]);
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadKey();
                Console.WriteLine();

            drizzleStart:
                Console.WriteLine("Let's now pick drizzle colors");
                Console.WriteLine();
                Console.WriteLine("Enter '0' for Turquoise");
                Console.WriteLine("Enter '1' for Orange");
                Console.WriteLine("Enter '2' for Pink");
                Console.WriteLine("Enter '3' for Black");
                Console.WriteLine("Enter '4' for Vibrant Green");
                Console.WriteLine("Enter '5' for Lavender");
                Console.WriteLine("Enter '6' for Red");
                Console.WriteLine("Enter '7' for Royal Blue");
                Console.WriteLine("Enter '8' for Yellow");
                int custDriz = int.Parse(Console.ReadLine());
                Drizzle newDriz = new Drizzle();
                newDriz.custDrizzle(custDriz);
                Console.WriteLine();

                Console.WriteLine("Enter 1 to continue to the next step or 2 to go back");
                int drizzleValid = int.Parse(Console.ReadLine());
                if (drizzleValid == 2)
                    goto drizzleStart;
                else if (drizzleValid == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Got it {cfName} {clName}.");
                }
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadKey();

                Console.WriteLine($"Your cake pop design currently has:");
                Console.WriteLine();
                Console.WriteLine("Batter: " + Batter.batter[custBat]);
                Console.WriteLine("Frosting color: " + Frosting.frosting[custFrost]);
                Console.WriteLine("Drizzle color: " + Drizzle.drizzle[custDriz]);
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadKey();
                Console.WriteLine();

            sprinkleStart:
                Console.WriteLine("For the last step, let's pick your sprinkles");
                Console.WriteLine();
                Console.WriteLine("Enter '0' for Purple Pony Party");
                Console.WriteLine("Enter '1' for Roller Disco");
                Console.WriteLine("Enter '2' for Little Blue");
                Console.WriteLine("Enter '3' for Hop Scotch");
                Console.WriteLine("Enter '4' for LoL Sprinkle");
                int custSprink = int.Parse(Console.ReadLine());
                Sprinkle newSprinkle = new Sprinkle();
                newSprinkle.custSprikle(custSprink);
                Console.WriteLine();

                Console.WriteLine("Enter 1 to continue to the next step or 2 to go back");
                int sprinkleValid = int.Parse(Console.ReadLine());
                if (sprinkleValid == 2)
                    goto sprinkleStart;
                else if (sprinkleValid == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Got it {cfName} {clName}.");
                }
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");

                Console.WriteLine($"Your cake pop final design has:");
                Console.WriteLine();
                Console.WriteLine("Batter: " + Batter.batter[custBat]);
                Console.WriteLine("Frosting color: " + Frosting.frosting[custFrost]);
                Console.WriteLine("Drizzle color: " + Drizzle.drizzle[custDriz]);
                Console.WriteLine("Sprinkles: " + Sprinkle.sprinkle[custSprink]);
                Console.WriteLine();

                Console.WriteLine("Enter '0' to exit, '1' to start all over from the begining, or '123' to complete your cake pop order");
                int finalInput = int.Parse(Console.ReadLine());

                if (finalInput == 0)
                {
                    Console.WriteLine("Thank you for visiting us! Maybe next time.");
                    System.Environment.Exit(1);
                }
                else if (finalInput == 1)
                    goto Start;

                else if (finalInput == 123)
                {
                    Console.WriteLine("You order is baking... We will contact you within 24 hours to coordinate delivery and payment.");
                    Console.WriteLine();
                    Console.WriteLine("Thank you for your support in gettings us one step closer to our dream vacation!");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadKey();
                }
                Console.WriteLine("Enter '0' to place another order or '1' to exit");
                int closeInput = int.Parse(Console.ReadLine());
                if (closeInput == 0)
                    goto Start;
                if (closeInput == 1)
                    System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand what you wanted to do.");
                Console.WriteLine();
                goto Start;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AKA Cake Pops! We appreciate your support.");
            Console.WriteLine();
            try
            {
                makeOrder();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

        }
    }
}
