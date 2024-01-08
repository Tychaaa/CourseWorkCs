using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    internal class NPC : InteractiveObject
    {
        private List<string> talkPhrases = new List<string>();

        // Перечисление для возможных действий NPC
        public enum NPCAction
        {
            Talk,
            Examine
        }

        // Конструктор
        public NPC() : base()
        {
        }

        // Конструктор с параметрами 1
        public NPC(string n, string desc) : base(n, desc)
        {
            // Инициализация фраз NPC
            talkPhrases.Add("Привет, путник!");
            talkPhrases.Add("Добро пожаловать в этот мир!");
            talkPhrases.Add("Что привело тебя сюда?");
            talkPhrases.Add("Будь осторожен, в этих землях не всегда спокойно.");
            talkPhrases.Add("Ты уже давно здесь?");
            talkPhrases.Add("Помни, здесь могут быть опасности за каждым углом.");
            talkPhrases.Add("Если у тебя есть вопросы, спрашивай.");
            talkPhrases.Add("Не все здесь такие, как кажутся.");
            talkPhrases.Add("Говорят, в этом мире много тайн.");
            talkPhrases.Add("Будь готов ко всему.");
        }

        // Конструктор с параметрами 2
        public NPC(string n, string desc, List<string> phrases) : base(n, desc)
        {
            // Инициализация фраз NPC
            talkPhrases = phrases;
        }

        // Функция для взаимодействия с неигровым персонажем
        public override void Interact()
        {
            // Выводим фразы по порядку
            if (talkPhrases.Count > 0)
            {
                Screen.DisplayDialog(GetName(), talkPhrases[0]);

                // Удаляем использованную фразу
                talkPhrases.RemoveAt(0);
            }
            else
            {
                Screen.DisplayDialog(GetName(), "- Иди своей дорогой, путник!");
            }
        }

        // Функция для получения вариантов действий
        public override List<Action> GetAvailableActions()
        {
            // Возвращаем действия для NPC
            List<Action> actions = new List<Action>
        {
            new Action(Action.ActionType.Talk, "Поговорить"),
            new Action(Action.ActionType.Examine, "Осмотреть")
        };
            return actions;
        }

        // Функция для обработки выбранного действия
        public override void PerformAction(Action action)
        {
            switch (action.GetActionType())
            {
                // Действие "Поговорить"
                case Action.ActionType.Talk:
                    Interact();
                    break;

                // Действие "Осмотреть"
                case Action.ActionType.Examine:
                    Screen.DisplayCharacterByCharacter($"\nВы осматриваете \"{GetName()}\".\n{GetDescription()}");
                    Console.WriteLine();
                    break;

                default:
                    Screen.DisplayText("Неподдерживаемое действие.");
                    break;
            }
        }
    }
}
