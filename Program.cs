namespace CourseWorkCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Главное меню
                Function.MainMenu();

                // Создаем объект персонажа
                Character mainCharacter = new Character();

                // Глава "Вступление"
                Function.Introduction(ref mainCharacter);

                // Глава "Пролог"
                Function.Prologue(ref mainCharacter);

                // Посещение Эмердейла
                Function.EnterEmerdaleLocation(ref mainCharacter);

                // Запуск обучающего боя
                Function.CombatTraining(ref mainCharacter);

                // Глава 1
                Function.ChapterOne(ref mainCharacter);

                // Глава 2
                Function.ChapterTwo(ref mainCharacter);

                // Глава "Финал"
                Function.ChapterFinal(ref mainCharacter);

                // Финальные титры
                Function.DisplayFinalCredits();
            }
        }
    }
}
