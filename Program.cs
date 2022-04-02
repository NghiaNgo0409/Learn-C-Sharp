using System;

namespace LearnCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AI Bot";
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            double num1, num2, num3, average;
            Console.WriteLine("Input number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input number 3: ");
            num3 = Convert.ToDouble(Console.ReadLine());
            average = (num1 + num2 + num3) / 3;
            Console.WriteLine("The average of three number is " + average);

            Console.ReadKey();
        }
    }
}
