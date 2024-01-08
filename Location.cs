using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    internal class Location
    {
        private string name;                          // Название локации
        private string description;                   // Описание локации
        private List<InteractiveObject> objects;      // Список объектов для взаимодействия

        // Конструктор
        public Location()
        {
            name = "";
            description = "";
            objects = new List<InteractiveObject>();
        }

        // Конструктор с параметрами 1
        public Location(string n, string desc)
        {
            name = n;
            description = desc;
            objects = new List<InteractiveObject>();
        }

        // Конструктор с параметрами 2
        public Location(string n, string desc, List<InteractiveObject> objs)
        {
            name = n;
            description = desc;
            objects = objs;
        }

        // Метод, вызываемый при входе в локацию
        public void OnEnter()
        {
            // Выводим текущую локацию и её описание
            Screen.DisplayCharacterByCharacter($"\nВы находитесь в {name}.\n{description}\n");
            Thread.Sleep(1000);

            // Основной цикл, реализующий взаимодействие с объектами
            while (true)
            {
                // Выводим информацию о доступных объектах
                Screen.DisplayText("\n\t~~Доступные объекты для взаимодействия~~\n");
                Thread.Sleep(500);

                // Выводим имена NPC, доступных для взаимодействия
                for (int i = 0; i < objects.Count; ++i)
                {
                    Screen.DisplayText($"{i + 1}. {objects[i].GetName()}");
                    Thread.Sleep(300);
                }

                // Вариант "закончить взаимодействие"
                Screen.DisplayText("0. Закончить взаимодействие");
                Thread.Sleep(700);

                int selectedObjectIndex;
                Console.Write("\nВаш выбор: ");
                // Проверка наличия ошибок ввода и ввода букв
                while (!int.TryParse(Console.ReadLine(), out selectedObjectIndex) || (selectedObjectIndex < 0 || selectedObjectIndex > objects.Count))
                {
                    // Выводим сообщение об ошибке и просим ввести ответ заново
                    Screen.DisplayDialog("Рассказчик", "Неверный выбор. Пожалуйста, введите корректный номер.");
                    Console.Write("\nВаш выбор: ");
                }

                // Пользователь выбрал "закончить взаимодействие"
                if (selectedObjectIndex == 0)
                {
                    break;
                }

                // Выводим варианты действий для выбранного объекта
                List<Action> objectActions = objects[selectedObjectIndex - 1].GetAvailableActions();
                Thread.Sleep(300);

                Screen.DisplayText($"\n\t~~\"{objects[selectedObjectIndex - 1].GetName()}\"~~\n");
                Thread.Sleep(100);

                for (int i = 0; i < objectActions.Count; ++i)
                {
                    Screen.DisplayText($"{i + 1}. {objectActions[i].GetDescription()}");
                    Thread.Sleep(500);
                }

                int selectedActionIndex;
                Console.Write("\nВаш выбор: ");
                // Проверка наличия ошибок ввода и ввода букв
                while (!int.TryParse(Console.ReadLine(), out selectedActionIndex) || (selectedActionIndex < 0 || selectedActionIndex > objectActions.Count))
                {
                    // Выводим сообщение об ошибке и просим ввести ответ заново
                    Screen.DisplayDialog("Рассказчик", "Неверный выбор. Пожалуйста, введите корректный номер.");
                    Console.Write("\nВаш выбор: ");
                }

                // Выполняем выбранное действие
                Action selectedAction = objectActions[selectedActionIndex - 1];
                objects[selectedObjectIndex - 1].PerformAction(selectedAction);
            }
        }

        // Метод для добавления интерактивных объектов
        public void AddInteractiveObject(InteractiveObject obj)
        {
            objects.Add(obj);
        }
    }
}