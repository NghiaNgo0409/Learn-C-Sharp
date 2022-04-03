using System;

namespace LearnCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AI Bot";
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            int numsOfStudent = 0;
            Console.Write("Please type number of students in this class: ");
            numsOfStudent = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[numsOfStudent];
            for (int i = 0; i < numsOfStudent; i++)
            {
                names[i] = Console.ReadLine();
            }

            Array.Sort(names);
            for (int i = 0; i < numsOfStudent; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadKey();
        }
    }
}
