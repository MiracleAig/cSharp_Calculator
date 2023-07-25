using System.Numerics;
using System.Security.Authentication;

namespace C__Calculator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to my calculator made in 100% C#, by Miracle Aigbogun (press enter to continue)");

            Console.WriteLine("Before we start what is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, this calculator can do the the 4 basic types of math.");
            Console.WriteLine("To start just enter the first letter of the opperation you want to do!");

            string opperation = Console.ReadLine();


            // addition opperator
            if(opperation == "A")
            {
                Console.WriteLine("You have chose Addition please enter your first number");

                double add_1 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine($"The first number you have entered is {add_1}, please enter the second number now");

                double add_2 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine($"The second number you have entered is {add_2}, would you like to add a third number? (Y or N)");

                string thirdNumbnerYorN = Console.ReadLine();

                if (thirdNumbnerYorN == "Y")
                {
                    Console.WriteLine("Please enter the the third number");
                    double add_3 = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine($"The third number you have entered is {add_3}");
                    Console.WriteLine($"The sum of {add_1} plus {add_2} plus {add_3} is equal to {add_1 + add_2 + add_3}");
                    Console.WriteLine("Thank you for using my Calculator");
                    Console.WriteLine("pres any key to close this console app");
                    Console.ReadKey();

                }
                else if (thirdNumbnerYorN == "N")
                {
                    Console.WriteLine($"Your sum of {add_1} plus {add_2} is equal to {add_1 + add_2}");
                    Console.WriteLine("Thank you for using my Calculator");
                    Console.WriteLine("pres any key to close this console app");
                    Console.ReadKey();
                }


            }



            Console.ReadKey();


        }

      
        
    }
}