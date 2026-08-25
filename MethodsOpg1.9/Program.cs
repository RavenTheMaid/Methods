using System.Diagnostics.CodeAnalysis;

namespace MethodsOpg1._9
{
    internal class Program
    {
        static double FindAverage(int[] numberArray)
        {
            int sum = 0;
            foreach(int item in numberArray)
            {
                sum += item;
            }
            return sum / numberArray.Length;
        }

        static void Main(string[] args)
        {
            int[] numberArray = { 1, 3, 124, 5123, 51, 23, 1, 1, 1, 1 };
            Console.WriteLine(FindAverage(numberArray));
        }
    }
}
