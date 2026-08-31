using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsOpg4
{
    internal class RandomMenu
    {
        public static void Tilfældigheder()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--Tilfældigheder--\n" +
                        "1. Print et tilfældigt tal.\n" +
                        "2. Print en tilfældig streng.\n" +
                        "3. Tilbage til hovedmenu");
                if (!int.TryParse(Console.ReadLine(), out int userInput))
                {
                    Console.WriteLine("Inputtet skal være et tal.");
                    Console.ReadKey();
                    continue;
                }
                else if (userInput < 0 || userInput > 3)
                {
                    Console.WriteLine("Tallet skal være imellem 1 og 3 (Tryk på en knap for at gå videre)");
                    Console.ReadKey();
                    continue;
                }

                switch (userInput)
                {
                    
                    case 1:
                        Console.Clear();
                        Random numberGenerator = new Random();
                        Console.WriteLine(numberGenerator.Next(1, 10000));
                        Console.WriteLine("Tryk på en knap for at gå videre");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Hvor lang skal din string være? (1 til 100");
                        if (!int.TryParse(Console.ReadLine(), out int generatedStringLength))
                        {
                            Console.WriteLine("inputtet skal være et tal");
                            Console.WriteLine("Tryk på en knap for at gå videre");
                            Console.ReadKey();
                            continue;
                        }
                        else if (generatedStringLength < 1 || generatedStringLength > 100)
                        {
                            Console.WriteLine("inputtet skal være imellem 1 og 100");
                            Console.WriteLine("Tryk på en knap for at gå videre");
                            Console.ReadKey();
                            continue;
                        }
                        Console.WriteLine(GenerateRandomString(generatedStringLength));
                        Console.WriteLine("Tryk på en knap for at gå videre");
                        Console.ReadKey();
                        break;

                    case 3:

                        break;
                }
                break;
            }
        }



        static string GenerateRandomString(int number)
        {
            Random numberGenerator = new Random();

            int generatedNumber = 0;

            int generatedNumberToGenerateNumber;

            string returnedString = "";
            for (int i = 0; i < number; i++)
            {
                generatedNumberToGenerateNumber = numberGenerator.Next(1, 3);
                //numbers in ascii
                if (generatedNumberToGenerateNumber == 1)
                {
                    generatedNumber = numberGenerator.Next(48, 57);
                }
                //capital letters in ascii
                if (generatedNumberToGenerateNumber == 2)
                {
                    generatedNumber = numberGenerator.Next(65, 90);

                }
                //small letters in ascii
                if (generatedNumberToGenerateNumber == 3)
                {
                    generatedNumber = numberGenerator.Next(97, 122);

                }
                char asciiConvertion = (char)generatedNumber;
                returnedString += $"{asciiConvertion}";
            }
            return returnedString;
        }
    }
}
