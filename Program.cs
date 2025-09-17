using System.Text.RegularExpressions;

namespace CompSciCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022 as a guide
            //Numbers to input, initialized to zero
                double num1 = 0;
                double num2 = 0;

            //Title Display
                Console.WriteLine("Console Calculator in C#\r");
                Console.WriteLine("------------------------\n");

            //Choose version
                Console.WriteLine("Choose your version:");
                Console.WriteLine("\t1. - Simple & Quick");
                Console.WriteLine("\t2. - Detailed & Dedicated");
                Console.Write("Your option? ");

            //switch statement to choose version
                switch (Console.ReadLine())
                {
                case "1":
                    //num1 input
                        Console.WriteLine("Input your first number. Press Enter to continue");
                        num1 = Convert.ToDouble(Console.ReadLine());
                    //num2 input
                        Console.WriteLine("Input your second number. Press Enter to continue\n");
                        num2 = Convert.ToDouble(Console.ReadLine());

                    //Addition, Subtraction, Multiplication, Division
                        Console.WriteLine($"Your numbers added together: {num1} + {num2} = " + (num1 + num2));
                        Console.WriteLine($"Your numbers subtracted: {num1} - {num2} = " + (num1 - num2));
                        Console.WriteLine($"Your numbers multiplied: {num1} * {num2} = " + (num1 * num2));
                        Console.WriteLine($"Your numbers divided: {num1} / {num2} = " + (num1 / num2));

                    //End Program
                        Console.Write("Press any key to close the Calculator...");
                        Console.ReadKey();
                break;

                case "2":
                    //num1 input
                    Console.WriteLine("Input your first number. Press Enter to continue");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    //num2 input
                    Console.WriteLine("Input your second number. Press Enter to continue\n");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    //Choose Calculation Operator
                    Console.WriteLine("Choose an option from the following list:");
                        Console.WriteLine("\t1. - Add");
                        Console.WriteLine("\t2. - Subtract");
                        Console.WriteLine("\t3. - Multiply");
                        Console.WriteLine("\t4. - Divide");
                        Console.Write("Your option? ");

                    //Sub Switch statement to choose operator
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                                break;
                            case "2":
                                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                                break;
                            case "3":
                                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                                break;
                            case "4":
                                // Ask the user to enter a non-zero divisor until they do so.
                                    while (num2 == 0)
                                    {
                                        Console.WriteLine("Enter a non-zero divisor: ");
                                        num2 = Convert.ToDouble(Console.ReadLine());
                                    }
                                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                            break;
                    }
                    //End Program
                        Console.Write("Press any key to close the Calculator...");
                        Console.ReadKey();
                    break;
                    
                default:
                    //if (case null || !Regex.IsMatch(op, "[1|2]"))
                    { Console.WriteLine("Invalid option. Please choose 1 or 2."); }
                break;
            }

            
        }
    }
}
