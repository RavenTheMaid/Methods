namespace MethodsOpg1._6
{
    internal class Program
    {
        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("gib number");
            Console.WriteLine(IsEven(int.Parse(Console.ReadLine())));

        }
    }
}
