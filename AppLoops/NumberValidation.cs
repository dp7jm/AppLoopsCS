using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace AppLoops
{
    class NumberValidation
    {
        public static string Validate(int number)
        {

            return (number == 9) ? "Valid" : "Invalid";
        }

        public static int EvaluateNumbers(int first, int second)
        {
            return first > second ? first : second;
        }

        public static string LandscapePosition(int height, int width)
        {
            return height > width ? "Vertical" : "Horizontal";
        }
    }
}