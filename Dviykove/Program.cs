using System;

namespace NumberSystemOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число в двiйковiй системi:");
            string binaryNumber1 = Console.ReadLine();

            Console.WriteLine("Введiть друге число в двiйковiй системi:");
            string binaryNumber2 = Console.ReadLine();

            Console.WriteLine("Виберiть операцiю (+, -, *, /):");
            char operation = Console.ReadKey().KeyChar;

            if (IsValidBinary(binaryNumber1) && IsValidBinary(binaryNumber2))
            {
                string resultBinary = "";
                switch (operation)
                {
                    case '+':
                        resultBinary = BinaryAddition(binaryNumber1, binaryNumber2);
                        break;
                    case '-':
                        resultBinary = BinarySubtraction(binaryNumber1, binaryNumber2);
                        break;
                    case '*':
                        resultBinary = BinaryMultiplication(binaryNumber1, binaryNumber2);
                        break;
                    case '/':
                        resultBinary = BinaryDivision(binaryNumber1, binaryNumber2);
                        break;
                    default:
                        Console.WriteLine("Некоректна операцiя.");
                        break;
                }

                Console.WriteLine($"Результат: {resultBinary}");
            }
            else
            {
                Console.WriteLine("Некоректний ввiд. Введiть двiйковi числа.");
            }
        }

        static bool IsValidBinary(string binaryNumber)
        {
            foreach (char digit in binaryNumber)
            {
                if (digit != '0' && digit != '1')
                {
                    return false;
                }
            }
            return true;
        }

        static string BinaryAddition(string binary1, string binary2)
        {
            return Convert.ToString(Convert.ToInt32(binary1, 2) + Convert.ToInt32(binary2, 2), 2);
        }

        static string BinarySubtraction(string binary1, string binary2)
        {
            return Convert.ToString(Convert.ToInt32(binary1, 2) - Convert.ToInt32(binary2, 2), 2);
        }

        static string BinaryMultiplication(string binary1, string binary2)
        {
            return Convert.ToString(Convert.ToInt32(binary1, 2) * Convert.ToInt32(binary2, 2), 2);
        }

        static string BinaryDivision(string binary1, string binary2)
        {
            return Convert.ToString(Convert.ToInt32(binary1, 2) / Convert.ToInt32(binary2, 2), 2);
        }
    }
}
