using System;

namespace LearnCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AI Bot";
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Random numberGen = new Random();
            int roll1 = 0;
            int roll2 = 1;
            int attemp = 0;
            Console.WriteLine("Press key to roll dices");
            while(roll1 != roll2)
            {
                Console.ReadKey();
                roll1 = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);
                Console.WriteLine("The number of dice 1 is " + roll1);
                Console.WriteLine("The number of dice 2 is " + roll2);
                attemp++;
            }

            Console.WriteLine("You take " + attemp + " attemps to roll a kind of dices");

            Console.ReadKey();
        }
    }
}
