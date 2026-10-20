using System;

namespace Lab2
{
    public class Proverka
    {
        public int ReadInt(string message)
        {
            Console.Write(message);
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Некорректный ввод. " + message);
            }
            return value;
        }

        public int ReadNonNegativeInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out value))
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число.");
                    continue;
                }

                if (value < 0)
                {
                    Console.WriteLine("Число должно быть неотрицательным.");
                    continue;
                }

                return value;
            }
        }

        public int ReadPositiveInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out value))
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число.");
                    continue;
                }

                if (value <= 0)
                {
                    Console.WriteLine("Число должно быть положительным.");
                    continue;
                }

                return value;
            }
        }

        public string ReadString(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (input == null || input.Trim() == "")
                {
                    Console.WriteLine("Строка не может быть пустой.");
                    continue;
                }

                return input;
            }
        }

        public string ReadOptionalString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (input == null || input.Trim() == "")
            {
                return null;
            }

            return input;
        }

        public string ReadName(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (input == null || input.Trim() == "")
                {
                    Console.WriteLine("Строка не может быть пустой.");
                    continue;
                }

                input = input.Trim();

                if (!IsLettersOnly(input))
                {
                    Console.WriteLine("Имя должно содержать только буквы (и, возможно, дефис).");
                    continue;
                }

                return input;
            }
        }

        public string ReadOptionalName(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (input == null || input.Trim() == "")
                {
                    return null;
                }

                input = input.Trim();

                if (!IsLettersOnly(input))
                {
                    Console.WriteLine("Имя должно содержать только буквы (и, возможно, дефис).");
                    continue;
                }

                return input;
            }
        }

        public int ReadNonZeroInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out value))
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число.");
                    continue;
                }

                if (value == 0)
                {
                    Console.WriteLine("Знаменатель не может быть нулём.");
                    continue;
                }

                return value;
            }
        }

        private bool IsLettersOnly(string input)
        {
            bool hasLetter = false;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsLetter(c))
                {
                    hasLetter = true;
                    continue;
                }

                if (c == '-')
                {
                    if (i == 0 || i == input.Length - 1)
                    {
                        return false;
                    }
                    continue;
                }

                return false;
            }

            return hasLetter;
        }
    }
}
