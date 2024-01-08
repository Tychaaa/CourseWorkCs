using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    internal class Action
    {
        // Перечисление для типов действий
        public enum ActionType
        {
            Talk,         // Действие "Поговорить"
            Examine,      // Действие "Осмотреть"
            Open          // Действие "Открыть"
        }

        private ActionType type;      // Тип действия
        private string description;   // Описание действия

        // Конструктор
        public Action()
        {
            type = ActionType.Talk;
            description = "";
        }

        // Конструктор с параметрами
        public Action(ActionType type, string description)
        {
            this.type = type;
            this.description = description;
        }

        // Геттер для получения типа действия
        public ActionType GetActionType()
        {
            return type;
        }

        // Геттер для получения описания действия
        public string GetDescription()
        {
            return description;
        }
    }
}
