using System;
namespace SN_Day1
{
    class Program
    {
        static void Main()
        {
            double num1, num2;
            int op;
            Console.WriteLine("Welcome to Haiqa's Basic Calculator.");
            Console.WriteLine("First day training task of Solution Nex.");
            while (true)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Your Choice:");
                op = int.Parse(Console.ReadLine());
                if(op==5)
                    return;
                Console.Write("Enter a number 1: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter a number 2: ");
                num2 = double.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            double Sum = num1 + num2;
                            Console.WriteLine($"Answer: {Sum}");
                        }
                        break;
                    case 2:
                        {
                            double Sub = num1 - num2;
                            Console.WriteLine($"Answer: {Sub}");
                        }
                        break;
                    case 3:
                        {
                            double Mul = num1 * num2;
                            Console.WriteLine($"Answer: {Mul}");
                        }
                        break;
                    case 4:
                        {
                            if (num2 == 0)
                                Console.WriteLine("Error: Division by zero is not Possible");
                            else
                            {
                                double Div = num1 / num2;
                                Console.WriteLine($"Answer: {Div}");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Please Choose a correct option.");
                        break;
                }
            }
        }
    }
}