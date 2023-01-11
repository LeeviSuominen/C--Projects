using System;

namespace Taikakanuuna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrow = 1;
            while (arrow <= 100)
            {
                if (arrow % 3 == 0 && arrow % 5 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(arrow + ": Fire");
                    Console.ResetColor();
                }
                else if (arrow % 3 != 0 && arrow % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(arrow + ": Electric");
                    Console.ResetColor();
                }
                else if (arrow % 3 == 0 && arrow % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(arrow + ": Electric and Fire");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(arrow + ": Normal");
                }
                arrow++;
            }
        }
    }
}