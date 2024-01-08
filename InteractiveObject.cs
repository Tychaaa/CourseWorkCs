using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    internal abstract class InteractiveObject
    {
        private string name;             // Имя объекта
        private string description;      // Описание объекта

        // Конструктор
        public InteractiveObject()
        {
            name = "";
            description = "";
        }

        // Конструктор с параметрами
        public InteractiveObject(string n, string desc)
        {
            name = n;
            description = desc;
        }

        // Метод для получения имени объекта
        public string GetName()
        {
            return name;
        }

        // Метод для получения описания объекта
        public string GetDescription()
        {
            return description;
        }

        // Метод для установки имени объекта
        public void SetName(string n)
        {
            name = n;
        }

        // Метод для установки описания объекта
        public void SetDescription(string desc)
        {
            description = desc;
        }

        // Виртуальная функция для взаимодействия
        public abstract void Interact();

        // Виртуальная функция, возвращающая варианты действий
        public abstract List<Action> GetAvailableActions();

        // Виртуальная функция для обработки выбранного действия
        public abstract void PerformAction(Action action);
    }
}
