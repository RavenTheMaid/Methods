namespace MethodsOpg1._3
{
    internal class Program
    {
        static void Calculate(double numberOne, double numberTwo)
        {
            double addition = numberOne + numberTwo;
            double subtraction = numberOne - numberTwo;
            double multiplication = numberOne * numberTwo;
            double division = numberOne / numberTwo;
            Console.WriteLine($"" +
                $"Addition: {addition}\n" +
                $"Subtraction: {subtraction}\n" +
                $"Multiplication: {multiplication}\n" +
                $"Division: {division}");
        }
        //calculate mult, div, add, sub

        static void Main(string[] args)
        {
            double numOne = 523;
            double numTwo = 9123;

            Calculate(numOne, numTwo);
            Console.ReadLine();




        }
    }
}
