﻿using System;
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
        public static void Introduction(Character character)
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
        public static void Prologue(Character character)
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
                    Screen.DisplayText("\n");

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
        public static void EnterEmerdaleLocation(Character character)
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
    }
}
