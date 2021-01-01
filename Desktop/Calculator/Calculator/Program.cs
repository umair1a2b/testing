using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = " ";
            string num2 = " ";

            
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Console.ReadLine();

            double clean1 = 0;
            while (!double.TryParse(num1, out clean1))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                num1 = Console.ReadLine();
            }

            Console.WriteLine("Type another number, and then press Enter");
            num2 = Console.ReadLine();

            double clean2 = 0;
            while (!double.TryParse(num2, out clean2))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                num2 = Console.ReadLine();
            }
            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {clean1} + {clean2} = " + (clean1 + clean2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {clean1} - {clean2} = " + (clean1 - clean2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {clean1} * {clean2} = " + (clean1 * clean2));
                    break;
                case "d":
                    while (clean2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        clean2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {clean1} / {clean2} = " + (clean1 / clean2));
                    break;
            }
          
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}