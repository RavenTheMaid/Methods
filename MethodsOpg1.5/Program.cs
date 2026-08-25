namespace MethodsOpg1._5
{
    internal class Program
    {
        static void Calculate(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("no");
            }
            else if (number < 0)
            {
                int squared = number * number;
                Console.WriteLine($"Your number squared is: {squared}");
            }
            else
            {
                int squared = number * number;
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine($"Your number squared is: {squared}");
                Console.WriteLine($"Your numbers square root is: {squareRoot}");
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("gib number");
            Calculate(int.Parse(Console.ReadLine()));
        }
    }
}
