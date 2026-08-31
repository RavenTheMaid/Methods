using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsOpg4
{
    internal class NumbersMenu
    {
        public static void Numbers()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--Tal--\n" +
                            "1. Er tallet positivt?\n" +
                            "2. Kvadrat og rod.\n" +
                            "3. Tilbage til hovedmenu.");
                if (!int.TryParse(Console.ReadLine(), out int userInput))
                {
                    Console.WriteLine("Inputtet skal være et tal.");
                    Console.WriteLine("Tryk på en knap for at gå videre");
                    Console.ReadKey();
                    continue;
                }
                else if (userInput < 0 || userInput > 3)
                {
                    Console.WriteLine("Tallet skal være imellem 1 og 3 (Tryk på en knap for at gå videre)");
                    Console.WriteLine("Tryk på en knap for at gå videre");
                    Console.ReadKey();
                    continue;
                }

                switch (userInput)
                {
                    case 1:
                        while(true)
                        {
                            Console.Clear();
                            Console.WriteLine("Hvilket tal mener du er positivt?");
                            if (!int.TryParse(Console.ReadLine(), out int isThisPositive))
                            {
                                Console.WriteLine("Inputtet skal være et tal");
                                Console.WriteLine("Tryk på en knap for at gå videre");
                                Console.ReadKey();
                                continue;
                            }
                            bool isTheNumberPositive = IsNumberPositive(isThisPositive);
                            if (isTheNumberPositive == true)
                            {
                                Console.WriteLine("Tallet er positivt!!!");
                                Console.WriteLine("Tryk på en knap for at gå videre");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Tallet er ikke positivt :C");
                                Console.WriteLine("Tryk på en knap for at gå videre");
                                Console.ReadKey();
                            }
                            break;
                        }
                    break;

                    case 2:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Hvilket tal vil du gerne se kvadraten og roden af?");
                            if (!double.TryParse(Console.ReadLine(), out double userNumber))
                            {
                                Console.WriteLine("Husk at skriv et tal >:C");
                                continue;
                            }
                            double numberRoot = SquareRoot(userNumber);
                            double numberSquared = Squared(userNumber);

                            Console.WriteLine($"" +
                                $"Roden er: {numberRoot} \n" +
                                $"Kvadraten er: {numberSquared}");
                            Console.ReadKey();
                            break;
                        }
                    break;

                    case 3:
                        break;
                }
                break;
            }
        }

        public static bool IsNumberPositive(int number)
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

        public static double SquareRoot(double number)
        {
            return Math.Sqrt(number);

        }
        public static double Squared(double number)
        {
            return number * number;

        }
    }
}
