using System;
using UnboundKey;

namespace Lexicon_Calculator_Assignment
{
    class Program
    {
        private static readonly string[] programs = { "Exit", "Addition", "Subtraction", "Division", "Multiplication" };

        static void Main()
        {
            Console.WriteLine("Welcome to Calculator!");
            while (true)
            {
                Console.WriteLine("Write a number to pick a program");
                for (int i = 0; i < programs.Length; i++)
                {
                    Console.WriteLine(i + ") " + programs[i]);
                }
                string conInput = Console.ReadLine();
                // makes sure input is a number, if not it defaults to one past the max programs triggering the default response;
                int conParsedInput = conInput.ParseInt(programs.Length);

                switch (conParsedInput)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Addition();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Division();
                        break;
                    case 4:
                        Multiplication();
                        break;
                }
            }
        }

        private static void Addition()
        {
            Console.WriteLine("Welcome to addition");
            //double firstNum = Helper.ParseDouble(Helper.ConWriteRead("Please enter a number to add:"));
            double firstNum = Helper.ConWriteRead("Please enter a number to add:").ParseDouble();
            double secondNum = Helper.ConWriteRead("Please enter another number:").ParseDouble();

            Console.Write("The Sum of these numbers are: ");
            Console.WriteLine(firstNum + secondNum);
        }
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        private static void Subtraction()
        {
            Console.WriteLine("Welcome to subtraction");
            double firstNum = Helper.ConWriteRead("Please enter a number:").ParseDouble();
            double secondNum = Helper.ConWriteRead("Please enter what to subtract:").ParseDouble();

            Console.Write("The Sum of these numbers are: ");
            Console.WriteLine(firstNum - secondNum);
        }

        private static void Division()
        {
            Console.WriteLine("Welcome to division");
            double firstNum = Helper.ConWriteRead("Please enter a number:").ParseDouble();
            double secondNum = Helper.ConWriteRead("Please enter what to divide by:").ParseDouble();
            if (firstNum == 0 || secondNum == 0)
            {
                Console.WriteLine("Dividing by zero (0) is not possible");
            }
            else
            {
                Console.Write("The Result is: ");
                Console.WriteLine(firstNum / secondNum);
            }
        }

        private static void Multiplication()
        {
            Console.WriteLine("Welcome to multiply");
            double firstNum = Helper.ConWriteRead("Please enter a number:").ParseDouble();
            double secondNum = Helper.ConWriteRead("Please enter what to multiply by:").ParseDouble();
            

            Console.Write("The Result is: ");

            Console.WriteLine(firstNum * secondNum);
        }
    }
}
