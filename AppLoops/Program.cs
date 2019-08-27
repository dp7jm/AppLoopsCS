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
            int chosenNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine(NumberValidation.Validate(chosenNumber));



        }
    }
}
