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

        public static int EvaluateNumbers(int first, int second)
        {
            return first > second ? first : second;
        }
    }
}