using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Please choose the number between 1 and 3 :
1. The program that validates, chosen number
2. Chose a greater number from two inputted characters");
            
            int number = int.Parse(Console.ReadLine()); ;
            switch (number)
            {
                case 1:
                    First();

                break;
                case 2:
                    Second();

                break;

            }
            



        }

        static void First()
        {
            int chosenNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine(NumberValidation.Validate(chosenNumber));

        }
        static void Second()
        {
            Console.WriteLine("Input first number");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input second number");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Greater Number is " + NumberValidation.EvaluateNumbers(firstNumber, secondNumber));

        }
    }
}
