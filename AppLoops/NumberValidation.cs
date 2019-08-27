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
    }
}