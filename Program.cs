

namespace CalculatorApp
{
    internal class Program
    {

        static void PrintMenu()
        {
            Console.WriteLine("This is a calculator wich ables you to make calculations of two integer numbers ");
                Console.WriteLine();
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                Console.WriteLine();
            return;
        }

        static double operandAddition(double numberOne, double numberTwo)
        { return numberOne + numberTwo; }

        static double operandSubtraction (double numberOne, double numberTwo)
        { return numberOne - numberTwo; }

        static double operandMultiplication (double numberOne, double numberTwo)
        { return numberOne * numberTwo; }

        static double operandDivision (double numberOne, double numberTwo)
        { 
            if (numberOne == 0) 
                {
                Console.WriteLine();
                Console.WriteLine("Division Error ");
                return -0;   
                }
            if (numberTwo == 0)
                {
                Console.WriteLine();
                Console.WriteLine("Division Error - Division by Zero not Allowed ");
                return -0;
                }
            return numberOne / numberTwo; 
         }


        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            // Console.TreatControlCAsInput = true;    // Prevent example from ending if CTRL+C is pressed.

           do
           {
                Console.WriteLine("Guten Morgen Eurex Traders!");
                Console.WriteLine();
                PrintMenu();
                Console.Write("Enter first number ");
                double numberOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second ");
                double numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter operand ");
                int userOperand = Convert.ToInt32(Console.ReadLine());
                double result = 0;
                switch (userOperand)
                    {
                        case 1: { result = operandAddition( numberOne, numberTwo ); break; }
                        case 2: { result = operandSubtraction ( numberOne, numberTwo); break; }
                        case 3: { result = operandMultiplication ( numberOne, numberTwo ); break; }
                        case 4: { result = operandDivision ( numberOne, numberTwo ); break; }
                    }

                Console.WriteLine();
                Console.WriteLine("The result is " + result);
                Console.WriteLine();
                Console.WriteLine("Press any key to make a new calculation - Press C to quit");
                cki = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("You pressed " + cki.Key.ToString());
            } while (cki.Key != ConsoleKey.C); 
        }  
    }
}
