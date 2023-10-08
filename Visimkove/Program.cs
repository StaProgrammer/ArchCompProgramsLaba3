using System;

namespace OctalNumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число в вiсiмковiй системi:");
            string octalNumber1 = Console.ReadLine();

            Console.WriteLine("Введiть друге число в вiсiмковiй системi:");
            string octalNumber2 = Console.ReadLine();

            Console.WriteLine("Виберiть операцiю (+):");
            char operation = Console.ReadKey().KeyChar;

            if (IsValidOctal(octalNumber1) && IsValidOctal(octalNumber2))
            {
                string resultOctal = "";
                switch (operation)
                {
                    case '+':
                        resultOctal = OctalAddition(octalNumber1, octalNumber2);
                        break;
                    default:
                        Console.WriteLine("Некоректна операцiя.");
                        break;
                }

                Console.WriteLine($"Результат: {resultOctal}");
            }
            else
            {
                Console.WriteLine("Некоректний ввiд. Введiть вiсiмковi числа.");
            }
        }

        static bool IsValidOctal(string octalNumber)
        {
            foreach (char digit in octalNumber)
            {
                if (digit < '0' || digit > '7')
                {
                    return false;
                }
            }
            return true;
        }

        static string OctalAddition(string octal1, string octal2)
        {
            int decimal1 = Convert.ToInt32(octal1, 8);
            int decimal2 = Convert.ToInt32(octal2, 8);
            int sumDecimal = decimal1 + decimal2;
            return Convert.ToString(sumDecimal, 8);
        }
    }
}
