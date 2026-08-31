using System.Reflection.PortableExecutable;

namespace MethodsOpg3._01
{
    internal class Program
    {
        static string ToString(char[] array)
        {
            string charToString = "";
            for (int i = 0; i < array.Length; i++)
            {
                charToString += array[i];
            }
            return charToString;
        }

        static string Generate(int number)
        {
            Random numberGenerator = new Random();

            int startNumbers = 48;
            int endNumbers = 57;

            int startCapitalLetters = 65;
            int endCapitalLetters = 90;

            int startSmallLetters = 97;
            int endSmallLetters = 122;

            int generatedNumber = 0;

            int generatedNumberToGenerateNumber;

            string returnedString = "";
            for (int i = 0; i < number; i++)
            {generatedNumberToGenerateNumber = numberGenerator.Next(1, 3);
            if (generatedNumberToGenerateNumber == 1)
            {
                generatedNumber = numberGenerator.Next(48, 57);
            }
            if (generatedNumberToGenerateNumber == 2)
            {
                generatedNumber = numberGenerator.Next(65, 90);

            }
            if (generatedNumberToGenerateNumber == 3)
            {
                generatedNumber = numberGenerator.Next(97, 122);

            }
            char asciiConvertion = (char)generatedNumber;
                returnedString += $"{asciiConvertion}";
            }
            return returnedString;
        }

        static void Main(string[] args)
        {
            string stringToArray = "blimbleblomble";
            char[] array = stringToArray.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }

            Console.WriteLine(ToString(array));

            int number = 20;
            Console.WriteLine(Generate(number));

        }
    }
}
