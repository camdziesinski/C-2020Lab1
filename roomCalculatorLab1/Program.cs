using System;

namespace roomCalculatorLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Hello, let's measure a room.\n");

            decimal width, length, height, area;
            string userInput = "y";

            while(userInput == "y")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("What is the length of the room? ");
                length = decimal.Parse(Console.ReadLine());
                Console.Write("what is the width of the room? ");
                width = decimal.Parse(Console.ReadLine());
                Console.Write("what is the height of the room? ");
                height = decimal.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\nlength: {length}\nWidth: {width}\nHeight: {height}");
                area = width * length;
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {width * 2 + length * 2}");
                Console.WriteLine($"Volume: {area * height}\n");

                userInput = " ";

                while (userInput != "y" && userInput != "n")
                {

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Would you like to measure another room?(y/n) ");
                    userInput = Console.ReadLine();
                }
                Console.WriteLine();
            }
        }
    }
}
