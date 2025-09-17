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

            //num1 input
                Console.WriteLine("Input your first number. Press Enter to continue");
                num1 = Convert.ToDouble(Console.ReadLine());
            //num2 input
                Console.WriteLine("Input your second number. Press Enter to continue");
                num2 = Convert.ToDouble(Console.ReadLine());

            //Addition, Subtraction, Multiplication, Division
                Console.WriteLine($"Your numbers added together: {num1} + {num2} = " + (num1 + num2));
                Console.WriteLine($"Your numbers subtracted: {num1} - {num2} = " + (num1 - num2));
                Console.WriteLine($"Your numbers multiplied: {num1} * {num2} = " + (num1 * num2));
                Console.WriteLine($"Your numbers divided: {num1} / {num2} = " + (num1 / num2));

            //End Program
                Console.Write("Press any key to close the Calculator...");
                Console.ReadKey();
        }
    }
}
