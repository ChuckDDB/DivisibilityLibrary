using DivisibilityLibrary;

namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberChecker divChecker = new NumberChecker();
            string[] returnedVal = divChecker.CheckNumbers(200);
            foreach (string val in returnedVal)
            {
                Console.WriteLine(val);
            }
        }
    }
}