namespace MethodsOpg2._01
{
    internal class Program
    {
        static int[] Generate(int numbersToGenerate)
        {
            Random numberGenerator = new Random();
            int[] array = new int[numbersToGenerate];
            for (int i = 0; i < array.Length; i++)
            {
                int generatedNumber = numberGenerator.Next(1, 100);
                array[i] = generatedNumber;
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] epicArray = Generate(50);
            for (int i = 0; i < epicArray.Length; i++)
            {
                Console.WriteLine($"{i+ 1}: {epicArray[i]}");
            }
        }
    }
}
