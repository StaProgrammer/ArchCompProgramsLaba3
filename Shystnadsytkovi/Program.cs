using System;

namespace HexadecimalNumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число в шiстнадцятковiй системi:");
            string hexadecimalNumber1 = Console.ReadLine();

            Console.WriteLine("Введiть друге число в шiстнадцятковiй системi:");
            string hexadecimalNumber2 = Console.ReadLine();

            Console.WriteLine("Виберiть операцiю (+):");
            char operation = Console.ReadKey().KeyChar;

            if (IsValidHexadecimal(hexadecimalNumber1) && IsValidHexadecimal(hexadecimalNumber2))
            {
                string resultHexadecimal = "";
                switch (operation)
                {
                    case '+':
                        resultHexadecimal = HexadecimalAddition(hexadecimalNumber1, hexadecimalNumber2);
                        break;
                    default:
                        Console.WriteLine("Некоректна операцiя.");
                        break;
                }

                Console.WriteLine($"Результат: {resultHexadecimal}");
            }
            else
            {
                Console.WriteLine("Некоректний ввiд. Введiть шiстнадцятковi числа.");
            }
        }

        static bool IsValidHexadecimal(string hexadecimalNumber)
        {
            foreach (char digit in hexadecimalNumber)
            {
                if (!((digit >= '0' && digit <= '9') || (digit >= 'A' && digit <= 'F') || (digit >= 'a' && digit <= 'f')))
                {
                    return false;
                }
            }
            return true;
        }

        static string HexadecimalAddition(string hex1, string hex2)
        {
            int decimal1 = Convert.ToInt32(hex1, 16);
            int decimal2 = Convert.ToInt32(hex2, 16);
            int sumDecimal = decimal1 + decimal2;
            return Convert.ToString(sumDecimal, 16).ToUpper();
        }
    }
}
