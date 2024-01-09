using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    public class CombatSystem
    {
        private bool isTraining;
        private bool playerGetBonus = false;
        private int prevMaxPlayerHealth;
        private int prevMaxPlayerStamina;
        private int prevMaxPlayerMana;

        // Инструкция к бою
        public void DisplayTrainingInstructions()
        {
            Console.WriteLine("Добро пожаловать в тренировочный бой!\n");
            Thread.Sleep(1000);

            Console.WriteLine("Инструкции по боевой системе:");
            Thread.Sleep(1000);

            Console.WriteLine("- Бой происходит поочередно: сначала ваш ход, затем ход противника.");
            Thread.Sleep(1000);

            Console.WriteLine("- Выберите номер действия:");
            Thread.Sleep(1000);

            Console.WriteLine("   - Введите '1', чтобы использовать оружие.");
            Thread.Sleep(1000);

            Console.WriteLine("   - Введите '2', чтобы использовать магию.");
            Thread.Sleep(1000);

            Console.WriteLine("   - Введите '3', чтобы пропустить ход.");
            Thread.Sleep(1000);

            Console.WriteLine("   - Любая другая цифра - означает промах.\n");
            Thread.Sleep(1000);

            Console.WriteLine("Карточки характеристик:");
            Thread.Sleep(1000);

            Console.WriteLine("   - Здоровье: текущий уровень жизненных сил персонажа.");
            Thread.Sleep(1000);

            Console.WriteLine("   - Выносливость: показатель, влияющий на атаки и защиту (+восстановление).");
            Thread.Sleep(1000);

            Console.WriteLine("   - Мана: ресурс, необходимый для магических атак (+восстановление).");
            Thread.Sleep(1000);

            Console.WriteLine("   - После каждого хода будут отображены характеристики игрока и врага.");
            Thread.Sleep(1000);

            Console.WriteLine("   - Ваши характеристики слева, характеристики противника - справа.");
            Thread.Sleep(1000);

            Console.WriteLine("   - Восстановление выносливости и маны: ресурсы восстанавливаются после каждого хода.");
            Thread.Sleep(1000);

            Console.WriteLine("Желаем удачи в тренировке!\n");
            Thread.Sleep(1000);

            Console.WriteLine("Нажмите Enter, чтобы продолжить...");
            Console.ReadLine();
        }

        // Запуск игры: сохраняются начальные характеристики игрока и противника, затем инициируется бой
        public void StartGame(Character player, Character enemy)
        {
            isTraining = false;
            // Сохранение начальных характеристик игрока
            prevMaxPlayerHealth = player.GetMaxHealth();
            prevMaxPlayerStamina = player.GetMaxStamina();
            prevMaxPlayerMana = player.GetMaxMana();

            //Запуск боя
            InitiateCombat(player, enemy);
        }

        // Запуск тренировочного боя
        public void StartGameTraining(Character player, Character enemy)
        {
            isTraining = true;
            // Сохранение начальных характеристик игрока
            prevMaxPlayerHealth = player.GetMaxHealth();
            prevMaxPlayerStamina = player.GetMaxStamina();
            prevMaxPlayerMana = player.GetMaxMana();

            DisplayTrainingInstructions();
            //Запуск боя
            InitiateCombat(player, enemy);
        }

        // Начало боя: вывод информации, управление ходами игрока и противника
        public void InitiateCombat(Character player, Character enemy)
        {
            Console.WriteLine("\n\t\tБой начинается!");
            Thread.Sleep(1000);

            DisplayCharacterInfo(player, enemy);

            // После вывода информации нужно вызвать методы для ходов игрока и противника
            while (!CheckVictory(player, enemy))
            {
                PlayerTurn(player, enemy);

                if (CheckVictory(player, enemy))
                    break;

                Console.WriteLine();

                EnemyTurn(player, enemy);

                DisplayCharacterInfo(player, enemy);
            }
        }

        // Ход игрока: вывод опций, чтение выбора, выполнение соответствующего действия
        public void PlayerTurn(Character player, Character enemy)
        {
            while (true)
            {
                Console.WriteLine("\nВыберите действие для героя:");
                Thread.Sleep(100);
                Console.WriteLine($"1. Атаковать с помощью {player.GetWeapon().GetName()} (dmg: {player.GetWeapon().GetDamage()}  stm : -{player.GetWeapon().GetCost()})");
                Thread.Sleep(100);
                Console.WriteLine($"2. Использовать магию {player.GetMagic().GetName()} (dmg: {player.GetMagic().GetDamage()}  mana: -{player.GetMagic().GetCost()})");
                Thread.Sleep(100);
                Console.WriteLine("3. Пропустить ход\n");
                Thread.Sleep(100);

                Console.Write("Ваше действие: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\nНеверный ввод! Попробуйте снова.");
                    continue;
                }

                Console.WriteLine();

                if (choice == 1)
                {
                    if (player.GetStamina() < player.GetWeapon().GetCost())
                    {
                        Screen.DisplayCharacterByCharacter($"Вы слишком изнурены для использования {player.GetWeapon().GetName()}.\n");
                        continue;
                    }

                    player.AttackWeapon(enemy);
                    break;
                }
                else if (choice == 2)
                {
                    if (player.GetMana() < player.GetMagic().GetCost())
                    {
                        Screen.DisplayCharacterByCharacter($"Вы слишком изнурены для использования {player.GetMagic().GetName()}.\n");
                        continue;
                    }

                    player.CastSpell(enemy);
                    break;
                }
                else if (choice == 3)
                {
                    Screen.DisplayCharacterByCharacter($"{player.GetName()} начинает отступать.\n");
                    break;
                }
                else
                {
                    Screen.DisplayCharacterByCharacter("Промах!\n");
                    break;
                }
            }
        }

        // Ход противника
        public void EnemyTurn(Character player, Character enemy)
        {
            enemy.Attack(player);
        }

        // Проверка на победу: проверка условий победы или поражения игрока и противника
        public bool CheckVictory(Character player, Character enemy)
        {
            if (player.GetHealth() <= 0)
            {
                if (isTraining)
                {
                    Console.WriteLine("\nСмерть... горькая тишина опустилась на битву. Тело героя лежит бездыханное, но что-то внутри него еще борется...");
                    Thread.Sleep(1000);
                    Console.WriteLine("\nОкончание тренировочного боя.\n");
                    Thread.Sleep(1000);

                    // Восстановление значений здоровья, выносливости и маны игрока
                    RestoreCharacterStats(player);

                    //Рализация без воскрешщения
                    return true;
                }
                Console.WriteLine("\nСмерть... горькая тишина опустилась на битву. Тело героя лежит бездыханное, но что-то внутри него еще борется...");
                Thread.Sleep(1000);
                Console.WriteLine("Слабый пульс начинает пульсировать вновь. Глаза героя открываются, словно он получил новую жизнь.");
                Thread.Sleep(1000);
                Console.WriteLine("Герой, смутно помня предыдущие события, чувствует, что его сила возросла. Он стал сильнее, быстрее, живучее...\n");
                Thread.Sleep(1000);

                // Восстановление значений здоровья, выносливости и маны игрока
                player.SetMaxHealth((int)(player.GetMaxHealth() * 1.2)); // Увеличиваем максимальное здоровье в 1.2
                player.SetMaxStamina((int)(player.GetMaxStamina() * 1.2)); // Увеличиваем максимальную выносливость в 1.2
                player.SetMaxMana((int)(player.GetMaxMana() * 1.2)); // Увеличиваем максимальную выносливость в 1.2
                playerGetBonus = true;

                // Восстановление значений здоровья, выносливости и маны игрока и противника
                RestoreCharacterStats(player);
                RestoreCharacterStats(enemy);

                // Перезапуск боя с сохраненными значениями
                InitiateCombat(player, enemy);

                return true; // Возвращаем true, чтобы бой перезапустился
            }
            else if (enemy.GetHealth() <= 0)
            {
                Console.WriteLine("\nБой закончен! Герой победил, но его дыхание тяжелое. Он устал, но чувствует чувство облегчения.");
                Thread.Sleep(1000);
                if (playerGetBonus)
                {
                    Console.WriteLine("Теперь, в свете победы, он чувствует, что этот особый дар, который он получил, исчезает.");
                    Thread.Sleep(1000);
                    player.SetMaxHealth(prevMaxPlayerHealth);
                    player.SetMaxStamina(prevMaxPlayerStamina);
                    player.SetMaxMana(prevMaxPlayerMana);
                }

                // Восстановление значений здоровья, выносливости и маны игрока
                RestoreCharacterStats(player);

                Console.WriteLine("Победа приносит новый опыт. Ощущение победы наполняет его душу, его путь становится яснее.");
                Thread.Sleep(1000);
                Console.WriteLine($"Опыт: {player.GetExperience()} (+{enemy.GetExperience()})");
                Thread.Sleep(1000);
                
                player.SetExperience(player.GetExperience() + enemy.GetExperience());

                return true;
            }
            return false;
        }

        // Восстановление значений здоровья, выносливости и маны игрока
        public void RestoreCharacterStats(Character character)
        {
            character.SetHealth(character.GetMaxHealth());
            character.SetStamina(character.GetMaxStamina());
            character.SetMana(character.GetMaxMana());
        }

        // Вывод информации о персонажах на экран
        public void DisplayCharacterInfo(Character player, Character enemy)
        {
            int playerRegenarateStamainaAmount = player.RegenerateStamina();
            int playerRegenarateManaAmount = player.RegenerateMana();
            int enemyRegenarateStamainaAmount = enemy.RegenerateStamina();
            int enemyRegenarateManaAmount = enemy.RegenerateMana();

            Console.WriteLine("\n+-------------------------+-------------------------+");
            Thread.Sleep(100);
            Console.WriteLine("| Информация о Герое:     | Информация о Враге:     |");
            Thread.Sleep(100);
            Console.WriteLine("+-------------------------+-------------------------+");
            Thread.Sleep(100);
            Console.WriteLine($"| Здоровье: {player.GetHealth(),-14}| Здоровье: {enemy.GetHealth(),-14}|");
            Thread.Sleep(100);
            Console.WriteLine($"| Выносливость: {player.GetStamina(),-4}(+{playerRegenarateStamainaAmount}) | Выносливость: {enemy.GetStamina(),-4}(+{enemyRegenarateStamainaAmount}) |");
            Thread.Sleep(100);
            Console.WriteLine($"| Мана: {player.GetMana(),-12}(+{playerRegenarateManaAmount}) | Мана: {enemy.GetMana(),-12}(+{enemyRegenarateManaAmount}) |");
            Thread.Sleep(100);
            Console.WriteLine("+-------------------------+-------------------------+");
        }
    }
}