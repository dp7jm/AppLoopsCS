using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLoops
{
    class NumberValidation
    {
        public static string Validate(int number)
        {
            int chosenNumber = number;
            if (chosenNumber == 7)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Please choose the number between 1 and 3 :
1. The program that validates chosen number");
            
            int number = int.Parse(Console.ReadLine()); ;
            switch (number)
            {
                case 1:
                    First();

                break;
                
            }
            int chosenNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine(NumberValidation.Validate(chosenNumber));



        }

        static void First()
        {
            int chosenNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine(NumberValidation.Validate(chosenNumber));

        }
    }
}
