namespace DivisibilityLibrary
{
    public class NumberChecker
    {
        public string[] CheckNumbers(int upperBounds)
        {
            string[] values = new string[upperBounds];

            for(int i = 1; i <= upperBounds; i++)
            {
                if (isDivisible(i, 3) && isDivisible(i, 5))
                    values[i - 1] = "Chuck Breedlove";
                else if (isDivisible(i, 3))
                    values[i - 1] += "Chuck";
                else if (isDivisible(i, 5))
                    values[i - 1] = "Breedlove";
                else
                    values[i - 1] = i.ToString();
            }
            return values;
        }
        private bool isDivisible(int val, int num)
        {
            if (val % num == 0)
                return true;
            else
                return false;
        }
    }
}