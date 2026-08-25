namespace MethodsOpg1._7
{
    internal class Program
    {
        static void Print(params int[] numbersArray)
        {
            foreach (int number in numbersArray)
            {
                Console.WriteLine(number);
            }
        }
        static void Main(string[] args)
        {
            int[] numbersArray = { 1, 2, 3, 4, 5, 6, 5, 6, 2, 8, 9, 10 };
            Print(numbersArray);
        }
    }
}
