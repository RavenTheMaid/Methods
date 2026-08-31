using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsOpg4
{
    internal class MainMenu
    {
        public static void HovedMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--Hovedmenu--\n" +
                        "1. Gå til tilfældigheder.\n" +
                        "2. Gå til tal.\n" +
                        "3. Afslut programmet");
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
                        RandomMenu.Tilfældigheder();
                        break;

                    case 2:
                        NumbersMenu.Numbers();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;

                }

            }
        }
    }
}
