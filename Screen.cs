using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    internal class Screen
    {
        // Вывод текста
        public static void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        // Выбор вариантов
        public static void DisplayOptions(List<string> options)
        {
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
        }

        // Вывод текста по буквам
        public static void DisplayCharacterByCharacter(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(35); // Задержка в миллисекундах
            }
        }

        // Вывод прямой речи NPC
        public static void DisplayDialog(string name, string phrase)
        {
            Console.Write($"\n{name}: ");
            Thread.Sleep(500);
            DisplayCharacterByCharacter($"\"- {phrase}\"\n");
            Thread.Sleep(1500);
        }
    }
}
