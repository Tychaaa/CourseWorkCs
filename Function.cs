using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    internal class Function
    {
        // Функция для вывода заставки игры (медленно)
        public static void GameTitleSlow()
        {
            Console.Clear();

            // ASCII-арт, разбитый на строки
            List<string> asciiArt = new List<string>
        {
            " ____   __,     ____, ____,  ____,  ____,    ____,  ____,    ____,  ____,  ____,  ____,  __,   _,  _, _  _, ",
            "(-|__) (-|     (-/_| (-|  \\ (-|_,  (-(__    (-/  \\ (-|_,    (-|  \\ (-|_,  (-(__  (-|    (-|   (-|\\ | (-\\_/  ",
            " _|__)  _|__,  _/  |, _|__/  _|__,  ____)    _\\__/, _|       _|__/  _|__,  ____)  _|,    _|_,  _| \\|,  _|,  ",
            "(      (      (      (      (      (        (      (        (      (      (      (      (     (       (     "
        };

            // Выводим ASCII-арт построчно с задержкой
            foreach (var line in asciiArt)
            {
                Console.WriteLine(line);
                Thread.Sleep(100);
            }

            Console.WriteLine("\n");
            Thread.Sleep(1000);
        }

        // Функция для вывода заставки игры
        public static void GameTitle()
        {
            Console.Clear();

            // ASCII-арт, разбитый на строки
            List<string> asciiArt = new List<string>
        {
            " ____   __,     ____, ____,  ____,  ____,    ____,  ____,    ____,  ____,  ____,  ____,  __,   _,  _, _  _, ",
            "(-|__) (-|     (-/_| (-|  \\ (-|_,  (-(__    (-/  \\ (-|_,    (-|  \\ (-|_,  (-(__  (-|    (-|   (-|\\ | (-\\_/  ",
            " _|__)  _|__,  _/  |, _|__/  _|__,  ____)    _\\__/, _|       _|__/  _|__,  ____)  _|,    _|_,  _| \\|,  _|,  ",
            "(      (      (      (      (      (        (      (        (      (      (      (      (     (       (     "
        };

            // Выводим ASCII-арт построчно
            foreach (var line in asciiArt)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\n");
        }

        // Функция для вывода заставки разработчиков
        public static void ProdTitle()
        {
            Console.Clear();

            // ASCII-арт, разбитый на строки
            List<string> asciiArt = new List<string>
        {
            " _______               _      _                  ",
            "|__   __|             | |    | |                 ",
            "   | |    _   _   ___ | |__  | | __  ___  __   __",
            "   | |   | | | | / __|| '_ \\ | |/ / / _ \\ \\ \\ / /",
            "   | |   | |_| || (__ | | | ||   < | (_) | \\ V / ",
            "   |_|    \\__, | \\___||_| |_||_|\\_\\ \\___/   \\_/  ",
            "           __/ |                                 ",
            "          |___/                                  ",
            "                   _                             ",
            "                  | |                            ",
            "  __ _  _ __    __| |                            ",
            " / _` || '_ \\  / _` |                            ",
            "| (_| || | | || (_| |                            ",
            " \\__,_||_| |_| \\__,_|                            ",
            "                                                 ",
            "                                                 ",
            "  _____  _                   _                      ",
            " / ____|| |                 | |                     ",
            "| (___  | |__    ___ __   __| |_  ___   ___  __   __",
            " \\___ \\ | '_ \\  / _ \\\\ \\ / /| __|/ __| / _ \\ \\ \\ / /",
            " ____) || | | ||  __/ \\ V / | |_ \\__ \\| (_) | \\ V / ",
            "|_____/ |_| |_| \\___/  \\_/   \\__||___/ \\___/   \\_/  ",
            "                                                     ",
            "                                                     ",
            " _____                    _               _    _               ",
            "|  __ \\                  | |             | |  (_)              ",
            "| |__) | _ __   ___    __| |  __ _   ___ | |_  _   ___   _ __  ",
            "|  ___/ | '__| / _ \\  / _` | / _` | / __|| __|| | / _ \\ | '_ \\ ",
            "| |     | |   | (_) || (_| || (_| || (__ | |_ | || (_) || | | |",
            "|_|     |_|    \\___/  \\__,_| \\__,_| \\___| \\__||_| \\___/ |_| |_|",
            "                                                                "
        };

            // Выводим ASCII-арт построчно с задержкой
            foreach (var line in asciiArt)
            {
                Console.WriteLine(line);
                Thread.Sleep(100);
            }

            Thread.Sleep(1000);
        }

        // Функция для вывода главного меню игры
        public static void MainMenu()
        {
            int choice;

            GameTitleSlow();

            do
            {
                Console.WriteLine("Главное меню:\n");
                Thread.Sleep(100);
                Console.WriteLine("1. Начать игру");
                Thread.Sleep(100);
                Console.WriteLine("2. Авторы");
                Thread.Sleep(100);
                Console.WriteLine("3. Выйти из игры");

                Console.Write("\nВыберите опцию: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out choice))
                {
                    Screen.DisplayDialog("Рассказчик", "Ты что-то путаешь, мой дорогой. Выбирай внимательнее.");
                    GameTitle();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        // Начать игру
                        GameTitle();
                        Thread.Sleep(1000);
                        break;
                    case 2:
                        // Показать информацию об авторах
                        ProdTitle();

                        Console.WriteLine("Тимофей Тычков - студент АлтГТУ 2 курса группы ПИ-23");
                        Thread.Sleep(100);
                        Console.WriteLine("Артём Шевцов - студент АлтГТУ 2 курса группы ПИ-23\n");
                        Thread.Sleep(100);

                        Console.WriteLine("Игра выполнена в рамках курсовой работы за 2 курс");
                        Thread.Sleep(100);
                        Console.WriteLine("на тему \"Текстовая RPG в консоли\" на языке C#\n");
                        Thread.Sleep(100);

                        Console.WriteLine("По любым вопросам, предложениям или баг репортам");
                        Thread.Sleep(100);
                        Console.WriteLine("обращайтесь в telegram: @tychaaaa или @Sh1chik\n");
                        Thread.Sleep(100);

                        Screen.DisplayText("\nНажмите Enter, чтобы продолжить...");
                        Console.ReadLine();

                        GameTitleSlow();
                        break;
                    case 3:
                        // Выйти из игры
                        Screen.DisplayDialog("Рассказчик", "Ты уверен, что хочешь покинуть этот захватывающий мир? Буду ждать твоего возвращения!");
                        Environment.Exit(0);  // Завершить программу
                        break;
                    default:
                        Screen.DisplayDialog("Рассказчик", "Ты что-то путаешь, мой дорогой. Выбирай внимательнее.");
                        Console.Clear();
                        GameTitle();
                        break;
                }
            } while (choice != 1);  // Цикл продолжается, пока пользователь не выберет "Начать игру"
        }

        // Функция для создания оружия и магии в зависимости от класса
        public static Tuple<Weapon, Magic> CreateEquipment(string className)
        {
            Weapon defaultWeapon = new Weapon("Старый меч", 10, 3);       // Оружие по умолчанию
            Magic defaultMagic = new Magic("Простое заклинание", 15, 5);  // Магия по умолчанию

            if (className == "Воин")
            {
                return Tuple.Create(new Weapon("Меч Воина", 25, 35), new Magic("Силовой удар", 15, 25));
            }
            else if (className == "Маг")
            {
                return Tuple.Create(new Weapon("Посох Мага", 15, 15), new Magic("Огненная вспышка", 30, 30));
            }
            else if (className == "Вор")
            {
                return Tuple.Create(new Weapon("Кинжал Вора", 30, 25), new Magic("Теневой удар", 25, 30));
            }
            else if (className == "Бродяга")
            {
                return Tuple.Create(new Weapon("Старый Кастет", 25, 25), new Magic("Стиль паука", 30, 30));
            }
            else if (className == "Жрец")
            {
                return Tuple.Create(new Weapon("Святой Жезл", 25, 17), new Magic("Лавовое дыхание", 25, 40));
            }
            else if (className == "Рыцарь")
            {
                return Tuple.Create(new Weapon("Меч Рыцаря", 40, 30), new Magic("Меткая атака", 20, 15));
            }
            else
            {
                // По умолчанию возвращаем стандартное оружие и магию
                return Tuple.Create(defaultWeapon, defaultMagic);
            }
        }

        // Функция для создания главного героя
        public static Character CreateMainCharacter()
        {
            // Вводим имя героя
            Screen.DisplayDialog("Рассказчик", "Помнишь ли ты свое имя?");

            string name;
            do
            {
                Console.Write("\nВведите ваше имя: ");
                #pragma warning disable CS8600
                name = Console.ReadLine();
                #pragma warning restore CS8600
            } while (string.IsNullOrWhiteSpace(name));

            Screen.DisplayDialog("Герой", "Меня зовут " + name);

            Screen.DisplayDialog("Рассказчик", "Твое имя звучит великолепно, " + name + ". Но чего-то не хватает....");

            // Вектор прилагательных для имени
            List<string> adjectives = new List<string>
        {
            "Драконорожденный", "Громовержец", "Сияющий", "Неустрашимый", "Магистр", "Повелитель огня", "Стальной",
            "Теневладыка", "Сокрушитель", "Бесстрашный", "Лунный", "Живучий", "Стремительный", "Искусный",
            "Непобедимый", "Величественный", "Благословенный", "Меткий", "Невидимый", "Великолепный"
        };

            // Генератор случайных чисел
            Random random = new Random();

            // Выбираем случайное прилагательное
            int randomIndex = random.Next(adjectives.Count);
            string randomAdjective = adjectives[randomIndex];

            // Добавляем прилагательное к имени героя
            name = name + " " + randomAdjective;

            Screen.DisplayDialog("Рассказчик", "Как насчёт - " + name + "?");

            // Выбираем класс
            List<string> classes = new List<string> { "Воин", "Маг", "Вор", "Бродяга", "Жрец", "Рыцарь" };
            Screen.DisplayDialog("Рассказчик", "Теперь скажи мне, в чём твоё призвание?");

            // Выводим таблицу с характеристиками классов
            Console.WriteLine("\n+----+---------------+---------------+---------------+---------------+----------------------------------------+--------------------------------------------------+");
            Thread.Sleep(100);
            Console.WriteLine("| #  |    Класс      |   Здоровье    | Выносливость  |     Мана      |                 Оружие                 |                      Магия                       |");
            Thread.Sleep(100);
            Console.WriteLine("+----+---------------+---------------+---------------+---------------+----------------------------------------+--------------------------------------------------+");

            for (int i = 0; i < classes.Count; ++i)
            {
                /// Получаем характеристики класса
                string currentClassName = classes[i];
                var currentEquipment = CreateEquipment(currentClassName);
                Weapon currentWeapon = currentEquipment.Item1;
                Magic currentMagic = currentEquipment.Item2;

                // Выводим информацию в таблице
                Console.Write($"| {i + 1,-2} |{currentClassName,-15}");

                // Выводим характеристики в зависимости от класса
                if (currentClassName == "Воин")
                {
                    Console.Write($"|{110,-15}|{120,-15}|{80,-15}|");
                }
                else if (currentClassName == "Маг")
                {
                    Console.Write($"|{80,-15}|{80,-15}|{150,-15}|");
                }
                else if (currentClassName == "Вор")
                {
                    Console.Write($"|{90,-15}|{90,-15}|{110,-15}|");
                }
                else if (currentClassName == "Бродяга")
                {
                    Console.Write($"|{110,-15}|{110,-15}|{110,-15}|");
                }
                else if (currentClassName == "Жрец")
                {
                    Console.Write($"|{110,-15}|{90,-15}|{110,-15}|");
                }
                else if (currentClassName == "Рыцарь")
                {
                    Console.Write($"|{140,-15}|{100,-15}|{100,-15}|");
                }

                // Выводим информацию об оружии и магии
                Console.WriteLine(
                    $"{currentWeapon.GetName().PadLeft(15)} (dmg: {currentWeapon.GetDamage(),2}, stm: -{currentWeapon.GetCost(),2})     |" +
                    $"{currentMagic.GetName().PadLeft(25)} (dmg: {currentMagic.GetDamage(),2}, mana: -{currentMagic.GetCost(),2})    |"
                );
            }

            // Закрываем таблицу
            Console.WriteLine("+----+---------------+---------------+---------------+---------------+----------------------------------------+--------------------------------------------------+");

            int choice;

            // Запрашиваем выбор пользователя
            Console.Write("\nВаш выбор: ");

            // Проверка наличия ошибок ввода и ввода букв
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > classes.Count)
            {
                // Выводим сообщение об ошибке и запрашиваем выбор заново
                Screen.DisplayDialog("Рассказчик", "Ты что-то путаешь, мой дорогой. Попробуй выбрать снова");
                Console.Write("\nВаш выбор: ");
            }

            // Получаем название выбранного класса
            string className = classes[choice - 1];

            // Устанавливаем параметры в конструкторе
            Weapon defaultWeapon = null;
            Magic defaultMagic = null;

            // Создаем героя с базовыми параметрами в зависимости от класса
            Character mainCharacter = new Character(name, 100, 50, 50, defaultWeapon, defaultMagic, className);

            // Получаем указатели на оружие и магию в зависимости от класса и устанавливаем их герою
            var equipment = CreateEquipment(className);
            mainCharacter.SetWeapon(equipment.Item1);
            mainCharacter.SetMagic(equipment.Item2);

            if (className == "Воин")
            {
                // Устанавливаем параметры для выбранного класса
                mainCharacter.SetHealth(110);
                mainCharacter.SetStamina(120);
                mainCharacter.SetMana(80);

                mainCharacter.SetMaxHealth(mainCharacter.GetHealth());
                mainCharacter.SetMaxStamina(mainCharacter.GetStamina());
                mainCharacter.SetMaxMana(mainCharacter.GetMana());
            }
            else if (className == "Маг")
            {
                // Устанавливаем параметры для выбранного класса
                mainCharacter.SetHealth(80);
                mainCharacter.SetStamina(80);
                mainCharacter.SetMana(150);

                mainCharacter.SetMaxHealth(mainCharacter.GetHealth());
                mainCharacter.SetMaxStamina(mainCharacter.GetStamina());
                mainCharacter.SetMaxMana(mainCharacter.GetMana());
            }
            else if (className == "Вор")
            {
                // Устанавливаем параметры для выбранного класса
                mainCharacter.SetHealth(90);
                mainCharacter.SetStamina(90);
                mainCharacter.SetMana(110);

                mainCharacter.SetMaxHealth(mainCharacter.GetHealth());
                mainCharacter.SetMaxStamina(mainCharacter.GetStamina());
                mainCharacter.SetMaxMana(mainCharacter.GetMana());
            }
            else if (className == "Бродяга")
            {
                // Устанавливаем параметры для выбранного класса
                mainCharacter.SetHealth(110);
                mainCharacter.SetStamina(110);
                mainCharacter.SetMana(110);

                mainCharacter.SetMaxHealth(mainCharacter.GetHealth());
                mainCharacter.SetMaxStamina(mainCharacter.GetStamina());
                mainCharacter.SetMaxMana(mainCharacter.GetMana());
            }
            else if (className == "Жрец")
            {
                // Устанавливаем параметры для выбранного класса
                mainCharacter.SetHealth(110);
                mainCharacter.SetStamina(90);
                mainCharacter.SetMana(110);

                mainCharacter.SetMaxHealth(mainCharacter.GetHealth());
                mainCharacter.SetMaxStamina(mainCharacter.GetStamina());
                mainCharacter.SetMaxMana(mainCharacter.GetMana());
            }
            else if (className == "Рыцарь")
            {
                // Устанавливаем параметры для выбранного класса
                mainCharacter.SetHealth(140);
                mainCharacter.SetStamina(100);
                mainCharacter.SetMana(100);

                mainCharacter.SetMaxHealth(mainCharacter.GetHealth());
                mainCharacter.SetMaxStamina(mainCharacter.GetStamina());
                mainCharacter.SetMaxMana(mainCharacter.GetMana());
            }

            // Выводим информацию о герое
            Console.WriteLine("\n\t~~Приветствуйте нового героя~~\n");
            Thread.Sleep(100);
            Console.WriteLine("Имя: " + mainCharacter.GetName());
            Thread.Sleep(100);
            Console.WriteLine("Класс: " + mainCharacter.GetClassType());
            Thread.Sleep(100);
            Console.WriteLine("Уровень: " + mainCharacter.GetLevel());
            Thread.Sleep(100);
            Console.WriteLine("Здоровье: " + mainCharacter.GetHealth());
            Thread.Sleep(100);
            Console.WriteLine("Мана: " + mainCharacter.GetMana());
            Thread.Sleep(100);
            Console.WriteLine("Выносливость: " + mainCharacter.GetStamina());
            Thread.Sleep(100);
            Console.WriteLine("Оружие: " + mainCharacter.GetWeapon().GetName());
            Thread.Sleep(100);
            Console.WriteLine("Магия: " + mainCharacter.GetMagic().GetName());
            Thread.Sleep(100);

            return mainCharacter;
        }

        // Вступление
        public static void Introduction(ref Character character)
        {
            // Определяем отступ слева
            int leftIndent = 10;

            // ASCII-арт для названия главы с отступом слева
            List<string> chapterArt = new List<string>
        {
            "     _____                _                            ",
            "    |  __ \\              | |                           ",
            "    | |__) | _ __   ___  | |  ___    __ _  _   _   ___ ",
            "    |  ___/ | '__| / _ \\ | | / _ \\  / _` || | | | / _ \\",
            "    | |     | |   | (_) || || (_) || (_| || |_| ||  __/",
            "    |_|     |_|    \\___/ |_| \\___/  \\__, | \\__,_| \\___|",
            "                                     __/ |              ",
            "                                    |___/               "
        };

            foreach (string line in chapterArt)
            {
                // Добавляем отступ слева
                Console.WriteLine(new string(' ', leftIndent) + line);
            }

            Thread.Sleep(1500);

            Console.WriteLine("\n\n");

            // Рассказ о мире
            Screen.DisplayText("\nДобро пожаловать в увлекательный мир приключений!");
            Thread.Sleep(1000);

            Screen.DisplayText("\nДавным-давно, в таинственном мире, где свет и тьма танцуют вечный вальс, началось ваше приключение.");
            Thread.Sleep(1500);

            Screen.DisplayText("\nЗдесь, среди древних руин и неисследованных земель, каждый шаг может привести к открытию тайны или смертельной опасности.");
            Thread.Sleep(1500);

            Screen.DisplayText("\nТемный лес, городские переулки — перед вами открыты неисследованные земли.");
            Thread.Sleep(1500);

            Screen.DisplayText("\nЭтот мир слышит своих героев, истории которых еще не написаны.");
            Thread.Sleep(1500);

            Screen.DisplayText("\nИ вот вы просыпаетесь, ощущая, что ваше призвание велико, и что вас ждут невероятные испытания.");
            Thread.Sleep(1500);

            Screen.DisplayText("\nГолос раздаётся в вашей голове!");
            Thread.Sleep(1500);

            Screen.DisplayDialog("Рассказчик", "Привет, путник! Ты проснулся в мире, где каждое решение, каждый поступок,\nможет повлиять на судьбу всего мира. Я - твой проводник в этом удивительном приключении.");

            Screen.DisplayCharacterByCharacter("\n\"- Кто ты? Где я?\"");
            Thread.Sleep(1000);

            Screen.DisplayText(" - спрашиваете вы, смутно осознавая себя в этом загадочном мире.");
            Thread.Sleep(1500);

            Screen.DisplayDialog("Рассказчик", "Меня зовут Элдрик, рассказчик этого мира. Это Страна Семи Клинков.");

            Screen.DisplayDialog("Рассказчик", "А ты — тот, кто изменит ход истории. Твое имя пока забыто, но оно станет легендой.\nТы вольный герой, и твой выбор определит судьбу этого мира.");

            // Задержка и создание главного героя
            Screen.DisplayDialog("Рассказчик", "Секундочку, у меня есть несколько вопросов... Отвечай на вопросы внимательно, они определят твою судьбу.");

            character = CreateMainCharacter();

            Screen.DisplayDialog("Рассказчик", "Впереди вас ждет долгий путь. На востоке расположен прекрасный город Эмердейл. Туда и направляйтесь.");

            Screen.DisplayDialog("Рассказчик", "Удачи, " + character.GetName() + "!");

            // Ожидаем нажатия клавиши перед продолжением
            Screen.DisplayText("\nНажмите Enter, чтобы продолжить...");
            Console.ReadLine();
        }

        // Глава "Пролог"
        public static void Prologue(ref Character character)
        {
            GameTitle();

            // Переход от разговора с рассказчиком к началу путешествия
            Screen.DisplayText("\nРассветное утро озаряет страну, когда вы решаете следовать по указанию рассказчика.");
            Thread.Sleep(1500);

            Screen.DisplayText("\nВы отправляетесь в путь... Впереди виднеется повозка, стоящая на обочине дороги.");
            Thread.Sleep(1500);

            Screen.DisplayText("\nНа повозке сидит старый мужчина, собирающийся вот-вот отправиться в путь.");
            Thread.Sleep(1500);

            Screen.DisplayDialog("Старик", "Дорогой путник, судя по всему, наши пути совпадают. Желаете ли вы составить мне компанию в пути?");

            Screen.DisplayText("\n1. \"- Да, я присоединюсь. Безопаснее двигаться вдвоем.\"");
            Thread.Sleep(500);
            Screen.DisplayText("2. \"- Благодарю за предложение, но я предпочту идти в одиночестве.\"");
            Thread.Sleep(500);

            Console.Write("\nВаш ответ: ");

            int choice;
            // Проверка наличия ошибок ввода и ввода букв
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                // Выводим сообщение NPC об ошибке и просим ввести ответ заново
                Screen.DisplayDialog("Старик", "Извините, я не расслышал ваш ответ. Пожалуйста, повторите его");
                Console.Write("\nВаш ответ: ");
            }

            switch (choice)
            {
                case 1:
                    Screen.DisplayDialog("Старик", "Отлично! Присаживайтесь, в путь!");

                    Screen.DisplayText("\nВы садитесь на повозку и начинаете беседовать с попутчиком.");

                    Screen.DisplayDialog("Старик", "Куда направляемся?");

                    Screen.DisplayText("\n1. \"- В город Эмердейл, там меня ждут дела.\"");
                    Thread.Sleep(500);
                    Screen.DisplayText("2. \"- Просто иду, куда дорога занесет.\"");
                    Thread.Sleep(500);

                    Console.Write("\nВаш ответ: ");

                    int destinationChoice;
                    // Проверка наличия ошибок ввода и ввода букв
                    while (!int.TryParse(Console.ReadLine(), out destinationChoice))
                    {
                        // Выводим сообщение NPC об ошибке и просим ввести ответ заново
                        Screen.DisplayDialog("Старик", "Извините, я не расслышал ваш ответ. Пожалуйста, повторите его");
                        Console.Write("\nВаш ответ: ");
                    }

                    switch (destinationChoice)
                    {
                        case 1:
                            Screen.DisplayDialog("Старик", "Отличный выбор! Эмердейл - великолепный город. Давайте вместе отправимся туда.");
                            break;
                        case 2:
                            Screen.DisplayDialog("Старик", "Дорога часто приносит сюрпризы. Давайте в путь! Я отправляюсь в Эмердейл.");
                            break;
                        default:
                            Screen.DisplayDialog("Старик", "Видимо ты не настроен на разговор. Значит отправимся куда глаза глядят!");
                            break;
                    }

                    Screen.DisplayText("\nВаше путешествие начинается. Всю поездку вы общаетесь со стариком, и дорога пролетает незаметно.");
                    Thread.Sleep(1500);
                    Screen.DisplayText("\nВы приобрели немного опыта.");
                    Thread.Sleep(1000);
                    Screen.DisplayText("\n(Добавлено +20 опыта)");
                    Thread.Sleep(1000);

                    // Увеличение опыта персонажа
                    character.SetExperience(character.GetExperience() + 20);
                    break;

                case 2:
                    Screen.DisplayDialog("Старик", "Понимаю, каждый выбирает свой путь. Надеюсь, встретимся вновь.");

                    Screen.DisplayText("\nСтарик махнул вам на прощание, и вы отправились в путь одни.");
                    Thread.Sleep(1500);
                    Screen.DisplayText("\nВы решили идти пешком, укрепляя свою выносливость и получая дополнительный опыт.");
                    Thread.Sleep(1000);
                    Screen.DisplayText("\n(Добавлено +50 опыта. Потеряно -20 выносливости)");
                    Thread.Sleep(1000);

                    // Увеличение опыта и уменьшение выносливости персонажа
                    character.SetExperience(character.GetExperience() + 50);
                    character.SetStamina(character.GetStamina() - 20);
                    break;

                default:
                    break;
            }

            // Ожидаем нажатия клавиши перед продолжением
            Screen.DisplayText("\nНажмите Enter, чтобы продолжить...");
            Console.ReadLine();
        }

        // Посещение локации "Эмердейл"
        public static void EnterEmerdaleLocation(ref Character character)
        {
            Location emerdealLocation = new Location("г.Эмердейл", "Город предоставляет разнообразные возможности для приключений, от торговли и заданий до исследования таинственных мест в его окрестностях.\nЭмердейл - место, где начинаются великие истории, и каждый приезжий ощущает волнение перед неизведанным.");

            // Трактирщик
            List<string> innkeeperPhrases = new List<string>
            {
                $"\"- Добро пожаловать в 'Золотую Лиру', {character.GetName()}! Что привело вас сегодня в наш прекрасный трактир?\"",
                "\"- Если вы хотите узнать больше о нашем городе, поговорите с Воеводой Стелсвином. Он знает много интересного.\"",
                "\"- Здесь всегда рады новым гостям. В 'Золотой Лире' вы найдете не только отличные напитки, но и приятное общество.\"",
                "\"- Расскажите мне о своих приключениях, и я расскажу вам старинные легенды этого места.\"",
                "\"- Необычайные события происходят вокруг. Будьте готовы к встречам, которые могут изменить вашу судьбу.\""
            };
            NPC innkeeper = new NPC("Трактирщик Гастин",
                "Хозяин таверны 'Золотая Лира'. Гастин - приветливый хозяин, умеющий рассказывать интересные истории.\n"
                + "В его таверне всегда теплая атмосфера и отличный выбор напитков. Здесь можно встретить путешественников и местных жителей.",
                innkeeperPhrases);
            emerdealLocation.AddInteractiveObject(innkeeper);

            // Воевода
            List<string> wardenPhrases = new List<string>
            {
                $"\"- Добро пожаловать в Эмердейл, {character.GetName()}. Я - Капитан Стелсвин, воевода города.Если у вас есть вопросы,\nобращайся ко мне, я готов помочь.Наш город всегда открыт для новых героев.\"",
                "\"- Когда вы закончите свои дела в городе, не забудьте вернуться ко мне. Может быть, у меня будет для вас задание.\"",
                "\"- В Эмердейле каждый герой находит свой путь. Мы гордимся своими жителями и всегда готовы приветствовать новых обитателей.\"",
                "\"- За городом много опасностей, но и много возможностей. Исследуйте мир, и, может быть, вы станете частью наших легенд.\"",
                "\"- Наш город богат не только историей, но и торговлей. Посетите рынок, чтобы найти необходимые вам вещи.\""
            };
            NPC warden = new NPC("Капитан Стелсвин",
                "Воевода Эмердейла. Капитан Стелсвин - опытный лидер, посвятивщий свою жизнь защите города.\n"
                + "Его решительность и мудрость сделали его уважаемым лидером, который присматривает за безопасностью города.",
                wardenPhrases);
            emerdealLocation.AddInteractiveObject(warden);

            // Еще один житель города
            List<string> citizenPhrases = new List<string>
            {
                $"\"- Приветствую вас, {character.GetName()}! Если у вас есть вопросы или нужна информация, обращайтесь. В Эмердейле всегда рады новым знакомствам.\"",
                "\"- Здесь так много интересных мест. Если вы решите исследовать город, обратите внимание на нашу ткацкую мастерскую. Там создают удивительные вещи.\"",
                "\"- Недавно в лесу возле города появилась странная пещера. Говорят, что внутри она полна загадок и сокровищ. Может быть, вам стоит проверить?\"",
                "\"- Если вы заблудитесь в городе, обратитесь к стражам. Они всегда готовы помочь и указать верное направление.\"",
                "\"- В Эмердейле много тайн. Если у вас есть смелость и жажда приключений, вам точно не будет скучно.\""
            };
            NPC citizen = new NPC("Эльза Белль",
                "Местная жительница. Эльза - добрая и отзывчивая женщина.\n"
                + "Она знает много интересных историй о городе и его жителях.",
                citizenPhrases);
            emerdealLocation.AddInteractiveObject(citizen);

            GameTitle();

            emerdealLocation.OnEnter();
        }

        // Обучение бою
        public static void CombatTraining(ref Character character)
        {
            GameTitle();

            // Продолжение после исследования города Эмердейл
            Screen.DisplayText($"\nПосле тщательного исследования города Эмердейл, {character.GetName()} решил двинуться дальше по своим делам.\n");
            Thread.Sleep(1500);

            Screen.DisplayText("Герой заскочил в таверну, насладился беседой с гостеприимным трактирщиком, встретил лично воеводу города,\nвзял на себя обязанность пообщаться с местными жителями и, наконец, заглянул в ткацкую мастерскую.");
            Thread.Sleep(1500);

            // Внезапно, воевода Стелсвин подходит к герою.
            Screen.DisplayDialog("Капитан Стелсвин", $"{character.GetName()}, я видел, как ты исследовал наш город. У меня есть предложение для тебя.");

            Screen.DisplayDialog("Капитан Стелсвин", "Мы ищем сильных воинов, способных защитить нашу страну Семи Клинков. Я хочу предложить тебе тренировку.");

            Screen.DisplayDialog("Капитан Стелсвин решительно продолжает", "Это будет тренировочный бой, в котором ты сможешь продемонстрировать свои навыки. Что скажешь?");

            // Пользователь делает выбор
            Console.Write("\n1. Принять предложение и приступить к тренировке."
                + "\n2. Отказаться и продолжить свое путешествие."
                + "\n\nВаш выбор: ");

            int trainingChoice;
            // Проверка наличия ошибок ввода и ввода букв
            while (!int.TryParse(Console.ReadLine(), out trainingChoice) || (trainingChoice != 1 && trainingChoice != 2))
            {
                // Выводим сообщение NPC об ошибке и просим ввести ответ заново
                Screen.DisplayDialog("Капитан Стелсвин", "Не понял твоего ответа. Повтори ещё раз!");
                Console.Write("\nВаш ответ: ");
            }

            switch (trainingChoice)
            {
                case 1:
                    Screen.DisplayDialog("Капитан Стелсвин", "Отлично! Давай начнем тренировку. Пойдем на тренировочную площадку.");
                    break;

                case 2:
                    Screen.DisplayDialog("Капитан Стелсвин", "Но я вижу в тебе потенциал. Даже если ты не хочешь, я проведу тренировочный бой, чтобы помочь тебе развить свои навыки.");
                    break;

                default:
                    Screen.DisplayDialog("Капитан Стелсвин", "Так как ты молчишь, давай начнем!");
                    break;
            }

            Weapon captainSword = new Weapon("Меч капитана", 35, 25);
            Character enemy = new Character("Капитан Стелсвин", 200, 150, 150, captainSword, null, 100);

            CombatSystem fight = new CombatSystem();

            // Продолжение сюжета после тренировочного боя с капитаном Стелсвином
            Screen.DisplayText($"\nТренировочный бой начался. Капитан Стелсвин демонстрировал свою силу и мастерство, но {character.GetName()} не оставался в стороне.\n");
            Thread.Sleep(1500);

            fight.StartGameTraining(character, enemy);

            // Подводим итоги тренировочного боя
            if (enemy.GetHealth() <= 0)
            {
                Screen.DisplayText("Герой справился с тренировочным боем, но Капитан Стелсвин выражает восхищение.");
                Screen.DisplayDialog("Капитан Стелсвин", $"Отличная работа, {character.GetName()}! Ты проявил себя в бою, и я уверен, что у тебя впереди великие подвиги.");
            }
            else
            {
                Screen.DisplayText("К сожалению, герой проиграл тренировочный бой, но Капитан Стелсвин подходит к нему с улыбкой.");
                Screen.DisplayDialog("Капитан Стелсвин", $"Ты проявил силу и решимость, даже если не смог одолеть меня. Ты обучаешься быстро.");
            }

            Screen.DisplayDialog("Капитан Стелсвин", "Теперь, когда ты прошел тренировку, у меня есть для тебя новое задание. Вокруг Эмердейла происходят странные события, и я нуждаюсь в твоей помощи.");

            // Пользователь делает выбор
            Console.Write("\n1. Принять новое задание и отправиться на новые приключения."
                + "\n2. Отказаться и продолжить свое путешествие."
                + "\n\nВаш выбор: ");

            int questChoice;

            // Проверка наличия ошибок ввода и ввода букв
            while (!int.TryParse(Console.ReadLine(), out questChoice) || (questChoice != 1 && questChoice != 2))
            {
                // Выводим сообщение NPC об ошибке и просим ввести ответ заново
                Screen.DisplayDialog("Капитан Стелсвин", "Не понял твоего ответа. Повтори ещё раз!");
                Console.Write("\nВаш ответ: ");
            }

            switch (questChoice)
            {
                case 1:
                    Screen.DisplayDialog("Капитан Стелсвин", $"Отлично! Иди к стражнику на входе в город. Он даст тебе все необходимые инструкции для нового задания.");
                    break;

                case 2:
                    Screen.DisplayDialog("Капитан Стелсвин", $"Ты проявляешь решительность, {character.GetName()}. Однако новое задание поможет тебе стать еще сильнее. Иди к стражнику на входе в город.");
                    break;

                default:
                    break;
            }

            // Ожидаем нажатия клавиши перед продолжением
            Screen.DisplayText("\nНажмите Enter, чтобы продолжить...");
            Console.ReadLine();
        }

        // Глава 1
        public static void ChapterOne(ref Character character)
        {
            GameTitle();

            // Определяем отступ слева
            int leftIndent = 10;

            // ASCII-арт для главы 1 с отступом слева
            List<string> chapterOneArt = new List<string>
            {
                "  _____  _                    _                  ____               ",
                " / ____|| |                  | |                / __ \\              ",
                "| |     | |__    __ _  _ __  | |_   ___  _ __  | |  | | _ __    ___ ",
                "| |     | '_ \\  / _` || '_ \\ | __| / _ \\| '__| | |  | || '_ \\  / _ \\",
                "| |____ | | | || (_| || |_) || |_ |  __/| |    | |__| || | | ||  __/",
                " \\_____||_| |_| \\__,_|| .__/  \\__| \\___||_|     \\____/ |_| |_| \\___|",
                "                      | |                                            ",
                "                      |_|                                            "
            };

            // Выводим ASCII-арт для главы 1
            foreach (string line in chapterOneArt)
            {
                // Добавляем отступ слева
                Console.WriteLine(new string(' ', leftIndent) + line);
            }

            Thread.Sleep(1500);

            Console.WriteLine("\n\n");

            // Описание пути к стражнику
            Screen.DisplayText($"\n{character.GetName()} шел по узкой дорожке, ведущей к воротам Эмердейла. По сторонам тянулись густые леса, и воздух наполнялся звуками природы.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nВдалеке мелькали странные тени, но герой не обращал на них внимания, сосредотачившись на своем предстоящем задании.");
            Thread.Sleep(1500);

            // Встреча со стражником
            Screen.DisplayDialog("Стражник", $"Здравствуй, {character.GetName()}! Я слышал, что ты собираешься отправиться в путь.");

            Screen.DisplayDialog("Стражник", "У меня есть для тебя задание. В округе появились опасные монстры, и мы нуждаемся в твоей помощи.");

            Screen.DisplayDialog("Стражник", "Твоя задача проста: уничтожь нескольких монстров в окрестностях Эмердейла. Не дай им приблизиться к городу.");

            // Задание начинается
            Screen.DisplayText("\nЗадание началось: 'Очистка окрестностей от монстров'.");
            Thread.Sleep(1500);

            Screen.DisplayText("\nВы встречаете огра и двух гоблинов.");
            Thread.Sleep(1500);

            Screen.DisplayText("\nПервыми на бой вышли гоблины.");
            Thread.Sleep(1500);

            CombatSystem fight = new CombatSystem();

            Ogre ogre = new Ogre("Огр", 100, 100, 0);

            Goblin goblin1 = new Goblin("Гоблин 1", 60, 100, 100);
            Goblin goblin2 = new Goblin("Гоблин 2", 60, 100, 100);

            fight.StartGame(character, goblin1);

            fight.StartGame(character, goblin2);

            Screen.DisplayText("\nТеперь нам предстоит битва с огром.");
            Thread.Sleep(1500);

            fight.StartGame(character, ogre);

            Screen.DisplayText("\nМонстры повержены, и окрестности города теперь безопасны.");
            Thread.Sleep(1500);

            Screen.DisplayDialog("Стражник", $"Отличная работа, {character.GetName()}! Спасибо за твою помощь в очистке окрестностей.");
            Thread.Sleep(1500);

            Screen.DisplayDialog("Стражник", "Ты доказал, что являешься настоящим героем, защищающим наши земли.");
            Thread.Sleep(1500);

            Screen.DisplayDialog("Стражник", "Город Эмердейл гордится такими отважными и преданными защитниками, как ты.");
            Thread.Sleep(1500);

            Screen.DisplayDialog("Стражник", "Если у тебя есть еще какие-то вопросы или нужна помощь, не стесняйся обращаться к нам.");
            Thread.Sleep(1500);

            Screen.DisplayDialog("Стражник", "Ты можешь отдохнуть и пополнить свои запасы в городе перед новыми приключениями.");
            Thread.Sleep(1500);

            // Ожидаем нажатия клавиши перед продолжением
            Screen.DisplayText("\nНажмите Enter, чтобы продолжить...");
            Console.ReadLine();
        }

        // Глава 2
        public static void ChapterTwo(ref Character character)
        {
            GameTitle();

            // Определяем отступ слева
            int leftIndent = 10;

            // ASCII-арт для главы 2 с отступом слева
            List<string> chapterTwoArt = new List<string>
            {
                "  _____  _                    _                 _______                  ",
                " / ____|| |                  | |               |__   __|                 ",
                "| |     | |__    __ _  _ __  | |_   ___  _ __     | |   __      __  ___  ",
                "| |     | '_ \\  / _` || '_ \\ | __| / _ \\| '__|    | |   \\ \\ /\\ / / / _ \\ ",
                "| |____ | | | || (_| || |_) || |_ |  __/| |       | |    \\ V  V / | (_) |",
                " \\_____||_| |_| \\__,_|| .__/  \\__| \\___||_|       |_|     \\_/\\_/   \\___/ ",
                "                      | |                                                 ",
                "                      |_|                                                 "
            };

            // Выводим ASCII-арт для главы 2
            foreach (string line in chapterTwoArt)
            {
                // Добавляем отступ слева
                Console.WriteLine(new string(' ', leftIndent) + line);
            }

            Thread.Sleep(1500);

            Console.WriteLine("\n\n");

            // Описание пути героя к новой локации
            Screen.DisplayText($"\n{character.GetName()} отправился в путь, и его следующей целью стала таинственная лесная долина.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nПуть был труден, но герой несмотря на все трудности продолжал идти, стремясь к новым приключениям.");
            Thread.Sleep(1500);

            Location forestValleyLocation = new Location("Лесная долина", "Таинственная лесная долина, полная загадок и опасностей.\n"
                + "Здесь обитают древние существа и духи природы. Путники должны быть осторожны и готовы к встрече с темными силами.");

            // Эльфийка
            List<string> elfPhrases = new List<string>
            {
                $"\"- Добро пожаловать в лесную долину, {character.GetName()}. Здесь вы почувствуете силу природы и встретите ее хранительницу.\"",
                $"\"- Лес - место таинственное и магическое. Рада видеть тебя здесь, искатель приключений.\"",
                $"\"- Если у тебя есть вопросы о лесе или природе, не стесняйся спрашивать. С удовольствием поделюсь своими знаниями.\"",
                $"\"- В этом лесу спрятаны древние тайны и сокровища. Только тот, кто с уважением относится к природе, может раскрывать их.\"",
                $"\"- Будь осторожен в своих действиях, и лес откроет тебе свои тайны.\""
            };
            NPC elf = new NPC("Эльфийка Себилла",
                "Древняя эльфийка, живущая в лесной долине. Себилла - стражница леса и его древних тайн.\n"
                + "Она может помочь герою понять природу леса и его особенности.",
                elfPhrases);
            forestValleyLocation.AddInteractiveObject(elf);

            // Друид
            List<string> druidPhrases = new List<string>
            {
                $"\"- Добро пожаловать в лесную долину, {character.GetName()}. Я - Дриада Элина, хранительница природы.\"",
                $"\"- В этом лесу каждое дерево - часть меня. С уважением к природе, ты найдешь здесь свою силу и понимание.\"",
                $"\"- Лес - место силы и энергии. Я готова помочь тебе освоиться в этом волшебном мире.\"",
                $"\"- Если ты нуждаешься в совете по вопросам природы и ее магии, приходи ко мне.\"",
                $"\"- Береги природу, и она ответит тебе взаимностью.\""
            };
            NPC druid = new NPC("Друид Элина",
                "Покровительница леса и природы. Дриада Элина - душа лесной долины, чуткая к сердцам всех его обитателей.\n"
                + "Она может помочь герою понять связь с природой и использовать ее магию.",
                druidPhrases);
            forestValleyLocation.AddInteractiveObject(druid);

            // Лесной странник
            List<string> rangerPhrases = new List<string>
            {
                $"\"- Приветствую, странник! В лесу полно опасностей, но и много сокровищ. Ты готов исследовать его тайны?\"",
                $"\"- Лес - место для сильных и смелых. Ты выглядишь таким. Если нужна помощь или совет, обращайся ко мне.\"",
                $"\"- В каждом уголке леса есть что-то удивительное. Следуй за своим сердцем, и ты обнаружишь его тайны.\"",
                $"\"- Если тебе нужна защита или компания в пути, я готов предложить свою помощь.\"",
                $"\"- Слушай звуки леса и будь готов ко всему. В этом мире ты можешь найти свою судьбу.\""
            };
            NPC ranger = new NPC("Лесной странник Фарин",
                "Охотник и разведчик, знающий все уголки леса. Фарин - искусный стрелок и опытный наблюдатель за дикой природой.\n"
                + "Он может быть надежным компаньоном и помощником в приключениях.",
                rangerPhrases);
            forestValleyLocation.AddInteractiveObject(ranger);

            forestValleyLocation.OnEnter();

            // Вступление перед боем
            Screen.DisplayText($"\nНаконец, {character.GetName()} достиг лесной долины. Воздух наполнился ароматом цветов и шумом листьев.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nНо вдруг вокруг него замелькали темные фигуры. Таинственные силуэты выходили из тени, поджидая исследователя.");
            Thread.Sleep(1500);

            // Бой с монстрами в лесной долине
            Screen.DisplayText("\nВнезапно героя окружили темные силуэты. Наверное, это не всеобъемлющий привет.");

            Wolf wolf = new Wolf("Волчара", 60, 50, 0);

            Skeleton skeleton1 = new Skeleton("Зловещий скелет Фейн", 40, 100, 100);

            Skeleton skeleton2 = new Skeleton("Загадочный Скелет Балд", 40, 100, 100);

            CombatSystem fight = new CombatSystem();

            Screen.DisplayText("\nВы встречаете волка и двух скелетов.");
            Thread.Sleep(1500);

            Screen.DisplayText("\nПервыми на бой вышли скелеты.");
            Thread.Sleep(1500);

            fight.StartGame(character, skeleton1);
            fight.StartGame(character, skeleton2);

            Screen.DisplayText("\nТеперь нам предстоит битва с волком.");
            Thread.Sleep(1500);

            fight.StartGame(character, wolf);

            // Ожидаем нажатия клавиши перед продолжением
            Screen.DisplayText("\nНажмите Enter, чтобы продолжить...");
            Console.ReadLine();
        }

        // Улучшение персонажа перед финалом
        public static void CharacterUpgrade(ref Character character)
        {
            character.SetHealth(420);
            character.SetMaxHealth(420);
            character.SetStamina(360);
            character.SetMaxStamina(360);
            character.SetMana(360);
            character.SetMaxMana(360);
            character.SetLevel(50);

            string className = character.GetClassType();

            // Создаем новые, еще более улучшенные объекты оружия и магии в зависимости от класса
            #pragma warning disable CS8600
            Weapon newWeapon = null;
            Magic newMagic = null;
            #pragma warning restore CS8600

            if (className == "Воин")
            {
                newWeapon = new Weapon("Героический Меч Защитника", 90, 80);
                newMagic = new Magic("Неукротимый Гнев", 80, 60);
            }
            else if (className == "Маг")
            {
                newWeapon = new Weapon("Архимагический Жезл Стихий", 70, 40);
                newMagic = new Magic("Взрыв Астральных Пламеней", 100, 70);
            }
            else if (className == "Вор")
            {
                newWeapon = new Weapon("Клинок Скрытной Тени", 100, 65);
                newMagic = new Magic("Спектральный Перехват", 90, 65);
            }
            else if (className == "Бродяга")
            {
                newWeapon = new Weapon("Стальные Кастеты Паука", 90, 60);
                newMagic = new Magic("Техника Волкобой", 95, 65);
            }
            else if (className == "Жрец")
            {
                newWeapon = new Weapon("Священный Жезл", 90, 50);
                newMagic = new Magic("Божественное Пламя", 90, 85);
            }
            else if (className == "Рыцарь")
            {
                newWeapon = new Weapon("Меч Паладина Света", 105, 65);
                newMagic = new Magic("Луч Солнца", 85, 50);
            }

            // Устанавливаем новые улучшенные оружие и магию герою
            #pragma warning disable CS8604
            character.SetWeapon(newWeapon);
            character.SetMagic(newMagic);
            #pragma warning restore CS8604
        }

        // Глава "Финал"
        public static void ChapterFinal(ref Character character)
        {
            GameTitle();

            // Определяем отступ слева
            int leftIndent = 10;

            // ASCII-арт для главы 2 с отступом слева
            List<string> chapterFinalArt = new List<string>
            {
                " ______  _                _ ",
                "|  ____|(_)              | |",
                "| |__    _  _ __    __ _ | |",
                "|  __|  | || '_ \\  / _` || |",
                "| |     | || | | || (_| || |",
                "|_|     |_||_| |_| \\__,_||_|",
                "                            ",
                "                            "
            };

            // Выводим ASCII-арт для главы 2
            foreach (string line in chapterFinalArt)
            {
                // Добавляем отступ слева
                Console.WriteLine(new string(' ', leftIndent) + line);
            }

            Thread.Sleep(1500);

            Console.WriteLine("\n\n");

            CharacterUpgrade(ref character);

            // Переход к финалу после прошествия времени
            Screen.DisplayText($"\nПрошло много лет с тех пор, как {character.GetName()} отправился в свое первое приключение.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nГерой преодолел множество испытаний, стал опытным воином и завоевал славу в различных уголках мира.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nТеперь {character.GetName()} почти стал легендой, его история рассказывается вокруг костра и в песнях таверн.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nОднако у героя осталось еще одно последнее задание, которое предстоит выполнить.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nВладыка тьмы, темный повелитель, вновь пробудился и угрожает миру. {character.GetName()} готовится к последнему столкновению.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nВремя подошло. Последнее задание ждет, и герой готов встретить свою судьбу.");

            // Вставка от разработчиков
            Screen.DisplayDialog("[От разработчиков]", "В связи с нехваткой времени, часть сюжета была пропущена. Мы приносим извинения за это, но надеемся, что вы все равно насладитесь финалом игры!");

            // Фраза от рассказчика
            Screen.DisplayDialog("Рассказчик", "На самом деле, история героя затянулась, и чтобы вы, уважаемый игрок, не заскучали, я решил пропустить самую пафосную и неинтересную часть про становление героя легендой.\nВедь это, действительно, клише в любой истории, не так ли? Давайте сразу перейдем к финалу приключений нашего героя!");

            // Фраза от рассказчика
            Screen.DisplayDialog("Рассказчик", "К тому же, давайте не будем винить разработчиков, они тоже старались!");

            Location darkLordCastle = new Location("Княжество Владыки Тьмы", "Мрачное княжество, подвластное владыке тьмы. Здесь царит тьма и зло.\n"
                + "Странные создания и демоны прячутся в тени замка, готовые исполнить волю своего повелителя.");

            // Владыка тьмы
            List<string> darkLordPhrases = new List<string>
            {
                $"\"- Добро пожаловать в мое владение, {character.GetName()}. Ты зашёл слишком далеко, и теперь ты здесь навсегда.\"",
                $"\"- Ты смело идешь на свою гибель, {character.GetName()}. Моя тьма поглотит тебя, как и всех, кто осмеливается встать на мой путь.\"",
                $"\"- Видишь ли, {character.GetName()}, ты не оставишь эти земли живым. Твоя судьба уже решена.\"",
                $"\"- Ты - последняя преграда перед моим владычеством. Подготовься к битве, но знай, что всё бесполезно.\"",
                $"\"- Этот мир был обречен с самого начала. Сейчас ты станешь свидетелем его падения, {character.GetName()}.\""
            };
            NPC darkLord = new NPC("Владыка Тьмы Вергилий",
                "Могущественный владыка тьмы, властелин Княжества Тьмы. Он обладает магией тьмы и стремится подчинить мир своей воле.",
                darkLordPhrases);
            darkLordCastle.AddInteractiveObject(darkLord);

            // Демоны в замке
            List<string> demonPhrases = new List<string>
            {
                "\"- Ты не пройдешь дальше, смертный! Владыка тьмы приказал охранять этот коридор.\"",
                "\"- Мы служим тьме и готовы отдать свои жизни, чтобы защитить нашего повелителя.\"",
                "\"- В этом мире нет места для света. Поддайся тьме или погибни!\"",
                "\"- Отступай, человек, пока не столкнулся с нашим гневом!\"",
                "\"- Твоя смерть приближается, и никакие твои силы не спасут тебя от нашей ярости!\""
            };
            NPC demon = new NPC("Демон стражник Азгар", "Могучий демон, присланный владыкой тьмы для защиты замка.", demonPhrases);
            darkLordCastle.AddInteractiveObject(demon);

            // Зловещие сущности в замке
            List<string> succubusPhrases = new List<string>
            {
                "\"- О, новый посетитель. Какой чудесный экземпляр для наших забав!\"",
                "\"- Сладкий человек, ты оказался в ловушке тьмы. Наслаждайся этим моментом.\"",
                "\"- Ты привлек мое внимание. Может быть, я позволю тебе остаться... на вечность.\"",
                "\"- Твоя душа такая наивная. Я увлеку тебя в мир наслаждений и страданий.\"",
                "\"- Владыка тьмы обрадуется новой игрушке. Что ты думаешь об этом, милый человек?\""
            };
            NPC succubus = new NPC("Суккуб Малина", "Обольстительная демоница, соблазняющая своим видом и манипулирующая чувствами.", succubusPhrases);
            darkLordCastle.AddInteractiveObject(succubus);

            List<string> witchPhrases = new List<string>
            {
                "\"- Ты наступил на святую землю замка. Здесь твои дни сочтены.\"",
                "\"- Смертный, ты дерзнул вторгнуться в святилище владыки тьмы. Теперь ты заплатишь за свою дерзость.\"",
                "\"- Здесь царит тьма, и ты не достоин взирать на это. Ты станешь пищей для моих заклинаний.\"",
                "\"- Судьба твоя уже предрешена. Ты стал частью этого замка, на веки веков.\"",
                "\"- Ты несешь свою участь, смертный. Владыка ждет нового трофея.\""
            };
            NPC witch = new NPC("Ведьма Лилит", "Жестокая ведьма, владеющая темной магией и преданная владыке тьмы. Ее магия страха и смерти окутывает замок тьмы.", witchPhrases);
            darkLordCastle.AddInteractiveObject(witch);

            List<string> enchantressPhrases = new List<string>
            {
                "\"- Зачем ты сюда пришел, смертный? Ты не достоин стоять передо мной.\"",
                "\"- Моя магия превзойдет все твои ничтожные попытки сопротивления.\"",
                "\"- Сгинь в огне моего взгляда, бесполезный герой. Ты лишь пыль под моими ногами.\"",
                "\"- Я дарю тебе последний шанс уйти, прежде чем моя магия поглотит тебя.\"",
                "\"- Ты думаешь, что можешь сразиться со мной? Подготовься к своей гибели.\""
            };
            NPC enchantress = new NPC("Зачаровательница Моргана", "Могущественная чародейка, владеющая темной магией и преданная владыке тьмы.", enchantressPhrases);
            darkLordCastle.AddInteractiveObject(enchantress);

            List<string> darkElfPhrases = new List<string>
        {
            "\"- Ты вступил в святилище владыки тьмы. Здесь нет места для твоего светлого взгляда.\"",
            "\"- Великий владыка ждет тебя, смертный. Ты не сможешь ему сопротивляться.\"",
            "\"- Сгинь во мраке наших сердец, несчастный. Твоя душа принадлежит владыке тьмы.\"",
            "\"- Ты сталкиваешься с силой, против которой не устоит ни один герой. Подготовься к тьме.\"",
            "\"- Твоя участь решена, смертный. Время служить вечности во тьме.\""
        };
            NPC darkElf = new NPC("Темная эльфийка Аделлия", "Хитрая и сильная темная эльфийка, преданная владыке тьмы.", darkElfPhrases);
            darkLordCastle.AddInteractiveObject(darkElf);

            darkLordCastle.OnEnter();

            // Подготовка к битве в Княжестве Тьмы
            Screen.DisplayText($"\nПосле тщательного исследования замка {character.GetName()} осознал, что столкнется с могуществом и тьмой.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nТемные силы сгущаются в каждом уголке замка. Жители Княжества Тьмы, преданные владыке тьмы, готовы сразиться за своего повелителя.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nВсе обитатели этого зловещего места выходят на тропу битвы. Суккубы, ведьмы, демоны, и темные эльфы - все они готовы исполнить волю владыки тьмы.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nСердце замка бьется от мрачной энергии, и {character.GetName()} понимает, что перед ним стоит сама эссенция тьмы - Владыка Тьмы.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nСудьба мира теперь зависит от исхода этой схватки. Герой готовится к битве, которая станет решающей в их судьбе.");
            Thread.Sleep(1500);

            Screen.DisplayText($"\nПоследнее приключение начинается, и {character.GetName()} вступает в бой со всеми силами Княжества Тьмы!");
            Thread.Sleep(1500);

            FinalFight(ref character);

            ChooseGameEnding(ref character);

            // Ожидаем нажатия клавиши перед продолжением
            Screen.DisplayText("\nНажмите Enter, чтобы продолжить...");
            Console.ReadLine();
        }

        // Сцена финальной битвы
        public static void FinalFight(ref Character character)
        {
            CombatSystem fight = new CombatSystem();

            // Характеристики соперников
            DarkLord darklord = new DarkLord("Владыка Тьмы Вергилий", 600, 500, 400);
            Demon demon = new Demon("Демон-стражник Азгар", 550, 450, 450);
            Succubus succubus = new Succubus("Суккуб Малина", 500, 400, 500);
            Witch witch = new Witch("Ведьма Лилит", 550, 500, 450);
            Enchantress enchantress = new Enchantress("Зачаровательница Моргана", 500, 450, 500);
            DarkElf darkElf = new DarkElf("Темная эльфийка Аделлия", 520, 480, 480);

            Console.WriteLine("Рассказчик: Главный герой подходит к темным вратам, за которыми состоится последний бой.");
            Console.WriteLine("Рассказчик: Перед вами возвышается Демон-стражник Азгар, готовый испытать ваши силы.");
            Console.WriteLine("Демон-стражник Азгар: Так, ты добрался сюда, смертный. Но это будет твой последний шаг!");
            Console.WriteLine($"{character.GetName()}: Я не остановлюсь, пока не сокрушу твои темные планы!");
            Console.WriteLine("Демон-стражник Азгар: Увидим, увидим... Начнем наше последнее противостояние!");

            // Бой с Демон - стражник Азгар
            Console.WriteLine("Рассказчик: И вот, первым выходит на бой Демон - стражник Азгар!\n");
            fight.StartGame(character, demon);

            // Бой с Суккуб Малина
            Console.WriteLine("Рассказчик: Теперь на арену выходит Суккуб Малина!");
            Console.WriteLine("Суккуб Малина: О, мой милый герой, я видела твой путь через тьму и свет.");
            Console.WriteLine($"{character.GetName()}: Твои обманчивые слова не помогут тебе в этой битве, Малина!");
            Console.WriteLine("Суккуб Малина: О, я не собираюсь убеждать тебя. Давай окунемся в танец страсти и смерти!");
            fight.StartGame(character, succubus);

            // Бой с Ведьмой Лилит
            Console.WriteLine("Рассказчик: Следующая на подмогу приходит Ведьма Лилит!");
            Console.WriteLine("Ведьма Лилит: Ты думаешь, что можешь победить меня, чужеземец? Ты заблуждаешься.");
            Console.WriteLine($"{character.GetName()}: Твои зловещие заговоры не остановят меня. Приготовься к своему поражению!");
            Console.WriteLine("Ведьма Лилит: Смелые слова. Позволь мне увидеть, на что ты способен!");
            fight.StartGame(character, witch);

            // Бой с Зачаровательницей Морганой
            Console.WriteLine("Рассказчик: Теперь в бой вступает Зачаровательница Моргана!");
            Console.WriteLine("Зачаровательница Моргана: Ты, чужеземец, наступил на святую землю. Ты заплатишь за свою дерзость.");
            Console.WriteLine($"{character.GetName()}: Твои чары не пугают меня. Я докажу, что тьма не может поглотить свет!");
            Console.WriteLine("Зачаровательница Моргана: Твои слова бесполезны. Готовься к поражению!");
            fight.StartGame(character, enchantress);

            // Бой с Темной эльфийкой Аделлией
            Console.WriteLine("Рассказчик: На последнем этапе боя появляется Темная эльфийка Аделлия!");
            Console.WriteLine("Темная эльфийка Аделлия: Ты смеешь встать на пути Владыки Тьмы? Ты поплатишься за свою дерзость!");
            Console.WriteLine($"{character.GetName()}: Твои тени не смогут поглотить свет моей силы. Я завершу это!");
            Console.WriteLine("Темная эльфийка Аделлия: Смешно. Но в этот раз ты не уйдешь от своей участи.");
            fight.StartGame(character, darkElf);

            // Бой с Главным боссом - Владыка Тьмы Вергилий
            Console.WriteLine("Рассказчик: И, наконец, на арене появляется Владыка Тьмы Вергилий, главный босс этой истории!");
            Console.WriteLine("Владыка Тьмы Вергилий: Так, ты добрался до меня, смертный. Но твой путь заканчивается здесь.");
            Console.WriteLine($"{character.GetName()}: Вергилий, твоя тень не затмит свет моего меча. Я пришел завершить твои злодеяния!");
            Console.WriteLine("Владыка Тьмы Вергилий: Ты смеешь бросить вызов мне, Владыке Тьмы? Ты будешь последним, кто увидит свет.");
            Console.WriteLine($"{character.GetName()}: Вергилий, твоя тень могущественна, но я не позволю ей поглотить этот мир!");
            Console.WriteLine("Владыка Тьмы Вергилий: Ты лишь маленький светоч во мраке. Твоя сила исчезнет перед моей тьмой.");
            Console.WriteLine($"{character.GetName()}: Мрак не может победить свет, Вергилий. Мой меч пронзит твою тень, и тьма будет побеждена!");
            Console.WriteLine("Владыка Тьмы Вергилий: Ты говоришь много, смертный. Но я покажу тебе истинную силу тьмы!");
            fight.StartGame(character, darklord);
        }

        // Функция для выбора концовки игры
        public static void ChooseGameEnding(ref Character character)
        {
            Screen.DisplayText($"\nПосле жесткой битвы в замке, Владыка Тьмы лежит побежденным перед {character.GetName()}.");
            Thread.Sleep(1500);

            Screen.DisplayDialog("Владыка Тьмы Вергилий", "Ты, смертный, добился своего. Но что ты получил?");
            Screen.DisplayDialog("Владыка Тьмы Вергилий", "Свободу этого мира? Но он не заслуживает свободы. В нем течет тьма, как в моих жилах.");
            Screen.DisplayDialog("Владыка Тьмы Вергилий", "Или ты хочешь занять место, которое я так долго удерживал? Стать новым повелителем мрака, который властвует над всеми?");
            Screen.DisplayDialog("Владыка Тьмы Вергилий", "Сделай свой выбор, смертный, и помни, что тьма всегда найдет путь в твое сердце.");

            // Получаем выбор игрока
            Screen.DisplayText("\nВыберите вариант завершения игры:");
            Thread.Sleep(1500);
            Screen.DisplayText("1. Убить Владыку Тьмы и освободить мир.");
            Thread.Sleep(1500);
            Screen.DisplayText("2. Занять место Владыки Тьмы и захватить этот мир.");
            Thread.Sleep(1500);

            // Получаем выбор игрока
            int choice;
            Console.Write("Ваш выбор: ");

            // Проверка наличия ошибок ввода и ввода букв
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                // Выводим сообщение об ошибке и просим ввести ответ заново
                Screen.DisplayDialog("Рассказчик", "Ой, кажется, вы что-то нажали не так. Выберите 1 или 2, пожалуйста.");
                Console.Write("\nВаш выбор: ");
            }

            // В зависимости от выбора игрока выполняем соответствующее действие
            switch (choice)
            {
                case 1:
                    GoodEnding(ref character);
                    break;
                case 2:
                    BadEnding(ref character);
                    break;
                default:
                    break;
            }
        }

        // Функция для "хорошей" концовки
        public static void GoodEnding(ref Character character)
        {
            Screen.DisplayDialog("Рассказчик", $"Свет побеждает тьму! С мощным мечом {character.GetName()} сразил Владыку Тьмы, освободив мир от его власти.");
            Thread.Sleep(500);

            Screen.DisplayDialog("Рассказчик", $"Мрак разгоняется, и природа начинает пробуждаться. Люди вновь увидели светлое будущее благодаря герою {character.GetName()}.");
            Thread.Sleep(500);

            Screen.DisplayDialog("Рассказчик", $"{character.GetName()} становится легендой, о которой рассказывают вокруг костра. Его подвиги войдут в историю как символ надежды и силы.");
            Thread.Sleep(500);

            Screen.DisplayDialog("Рассказчик", $"Герой принимает благодарность народа и отправляется в новые приключения, но его имя останется в сердцах тех, кого он спас.");
            Thread.Sleep(500);
        }

        // Функция для "плохой" концовки
        public static void BadEnding(ref Character character)
        {
            Screen.DisplayDialog("Рассказчик", $"В поисках силы, {character.GetName()} решает воспользоваться темной магией Владыки Тьмы.");
            Thread.Sleep(500);

            Screen.DisplayDialog("Рассказчик", $"Мощь тьмы охватывает {character.GetName()}. Он становится новым Владыкой Тьмы, господствуя над миром.");
            Thread.Sleep(500);

            Screen.DisplayDialog("Рассказчик", $"Мир погружается во мрак, и тьма охватывает все вокруг. Надежда угасает, а страх преобразуется в подчинение.");
            Thread.Sleep(500);

            Screen.DisplayDialog("Рассказчик", $"Герой {character.GetName()} становится тем, от чего он стремился защитить мир. Новый Владыка Тьмы правит адским королевством.");
            Thread.Sleep(500);

            Screen.DisplayDialog("Рассказчик", "И закончилась история, но не так, как надеялись жители этого мира. Вечная ночь поглотила свет и надежду.");
            Thread.Sleep(500);
        }

        // Финальные титры
        public static void DisplayFinalCredits()
        {
            GameTitle();

            Screen.DisplayText("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Thread.Sleep(500);
            Screen.DisplayText("                                       END OF GAME\n");
            Thread.Sleep(500);
            Screen.DisplayText("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            Thread.Sleep(1500);

            Screen.DisplayDialog("Рассказчик", "И вот мы подошли к завершению нашего захватывающего приключения.\n            Спасибо, что были с нами и принимали участие в этой увлекательной истории.\n            Надеемся, что вам понравилось путешествие по миру фантазии и приключений.");

            Console.Write("\n\n");

            Screen.DisplayDialog("Рассказчик", "Игрок, вы проявили смелость, мудрость и силу в этом мире.\n            Ваши решения оставили свой след, и ваша история стала частью легенды.\n            Благодарим вас за участие в этом увлекательном путешествии!");

            Console.Write("\n\n");

            Screen.DisplayDialog("Рассказчик", "Пока мы прощаемся, помните: в мире фантазии всегда ждут новые приключения.\n            До новых встреч, герой! Пусть судьба вас сопровождает!");

            Screen.DisplayText("\n\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            // Ожидаем нажатия клавиши перед продолжением
            Screen.DisplayText("\nНажмите Enter, чтобы продолжить...");
            Console.ReadLine();
        }
    }
}
