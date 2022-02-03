using System;

namespace WEB1001_Calculator_App
{
    internal class Program
    {
        private const string INVALID_EQ_ERROR = "Please provide a valid equation.";

        static void Main()
        {
            bool whileRun = true;
            Console.WriteLine("Dulith's Calculator");

            do
            {
                Console.WriteLine("Please enter a calculation ex. 1 1 +");
                String equation = Console.ReadLine();

                if (equation != null)
                {
                    if (equation == "quit")
                    {
                        whileRun = false;
                    }

                    String[] args = equation.Split(' ');

                    if (args.Length == 3)
                    {
                        string symbol = args[2];
                        int lvalue = 0;
                        int rvalue = 0;

                        if (int.TryParse(args[0], out lvalue) && int.TryParse(args[1], out rvalue))
                        {
                            double answer = 0;

                            switch (symbol)
                            {
                                case "+":
                                    answer = lvalue + rvalue;
                                    break;
                                case "-":
                                    answer = lvalue - rvalue;
                                    break;
                                case "/":
                                    answer = lvalue / rvalue;
                                    break;
                                case "*":
                                    answer = lvalue * rvalue;
                                    break;
                                default:
                                    Console.WriteLine(INVALID_EQ_ERROR);
                                    break;
                            }

                            Console.WriteLine($"The answer to {equation} is {answer}.");
                        }
                        else
                        {
                            Console.WriteLine(INVALID_EQ_ERROR);
                        }
                    }
                    else
                    {
                        Console.WriteLine(INVALID_EQ_ERROR);
                    }
                }
                else
                {
                    Console.WriteLine(INVALID_EQ_ERROR);
                }
            } while (whileRun);
        }
    }
}
