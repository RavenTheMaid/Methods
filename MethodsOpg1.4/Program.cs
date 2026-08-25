namespace MethodsOpg1._4
{
    internal class Program
    {
        static bool IsPositive(int number)
        {
            if (number > 0)
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
            Console.WriteLine("gib num");
            int num = int.Parse(Console.ReadLine());

            if (IsPositive(num) == true)
            {
                Console.WriteLine("YOUR NUMBER IS POSITIVE HOOOOORAAAYY");
            }
            else
            {
                Console.WriteLine("YOUR NUMBER IS NEGATIVE BOOOOOOOOOOOOOOOOOOOOOOOOOO");
            }

        }
    }
}
