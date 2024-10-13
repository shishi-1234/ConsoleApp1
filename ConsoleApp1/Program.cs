using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string a = "nanana";
            char b = 'h';
            string h = "Hello";
            string up = h.ToUpper();
            string d = h.ToLower();
            string rep = h.Replace("о", "O");
            Console.WriteLine(up);
            Console.WriteLine(d);
            Console.WriteLine(rep);
            string s1 = "Hello ";
            string s2 = "World!";
            string s3 = s1 + s2;
            Console.Write("Ваш текст ");
            string text = Console.ReadLine();
            Console.WriteLine("Количество символов: " + text.Length);
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.Replace(" ", "_"));
            /*Console.SetCursorPosition(0, 0);
            Console.WriteLine("Hello, World!");
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Имя: " + name);*/
            /*Random random = new Random();
            int numberToGuess = random.Next(1, 101); // Загадать число от 1 до 100
            int userGuess = 0;
            int attempts = 0;

            Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
            Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать его!");

            // Цикл, пока пользователь не угадает число
            while (userGuess != numberToGuess)
            {
                Console.Write("Введите ваше предположение: ");
                string input = Console.ReadLine();

                // Проверка на корректность ввода
                if (int.TryParse(input, out userGuess))
                {
                    attempts++;
                    if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Слишком маленькое число. Попробуйте снова.");
                    }
                    else if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Слишком большое число. Попробуйте снова.");
                    }
                    else
                    {
                        Console.WriteLine($"Поздравляю! Вы угадали число {numberToGuess} за {attempts} попыток.");
                    }
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректное целое число.");
                }
            }*/
        }
    }
}
