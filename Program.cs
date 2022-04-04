using System;

namespace LearnCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AI Bot";
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine(CountWordsInString("I am a human"));


            Console.ReadKey();
        }

        static int CountWordsInString(string s)
        {
            return s.Split(' ').Length;
        }
    }
}
