using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MethodsOpg1._10
{
    internal class Program
    {
        static int FindMode(int[] numberArray)
        {
            int currentCount = 0;
            int maxCount = 0;
            int mode = 0;
            numberArray.Sort();

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i > 0)
                {
                    if (numberArray[i] == numberArray[i - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 0;
                    }
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;    
                    mode = numberArray[i];

                }
            }


            return mode;
        }

        static int FindMedian(int[] numberArray)
        {
            if (numberArray.Length % 2 != 0)
            {
                return numberArray.Length / 2;
            }
            else
            {
                int arrayInt = (numberArray.Length / 2 + numberArray.Length / 2 - 1) / 2;
                return numberArray[arrayInt];
            }
        }

        static void Main(string[] args)
        {
            int[] numberArray = { 1, 2, 3, 1, 1, 4, 3, 1, 2, 3, 1, 2, 2, 3, 4, 11, 10, 1, 5, 4, 4, 4, 5, 4, 7, 10 };

            Console.WriteLine(FindMode(numberArray));
            Console.WriteLine(FindMedian(numberArray));
            

            numberArray.Sort();
            foreach (int number in numberArray)
            {
                Console.Write(number + " ");
            }
        }
    }
}
