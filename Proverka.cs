using System;

namespace Lab2
{
    public class Proverka
    {
        // Чтение целого числа
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

        // Чтение неотрицательного целого
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

        // Чтение положительного целого
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

        // Чтение непустой строки (для случаев, где допустимы любые символы)
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

        // Чтение строки, которая может быть пустой
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

        // Чтение имени: только буквы и дефис
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

        // Чтение необязательного имени: только буквы и дефис, либо пусто
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

        // Чтение ненулевого знаменателя
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

        // Проверка: строка состоит только из букв и дефисов
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
                    // Дефис не может быть первым или последним символом
                    if (i == 0 || i == input.Length - 1)
                    {
                        return false;
                    }
                    continue;
                }

                // Любой другой символ (цифра, пробел, знак препинания) — ошибка
                return false;
            }

            return hasLetter;
        }
    }
}
