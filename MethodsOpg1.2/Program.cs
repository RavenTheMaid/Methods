namespace MethodsOpg1._2
{
    internal class Program
    {
        static void Print(int number)
        {
            Console.WriteLine($"Tallet er: {number}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("gib number");
            int number = int.Parse(Console.ReadLine());

            Print(number);




        }
    }
}
