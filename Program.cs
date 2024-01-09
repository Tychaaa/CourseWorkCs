namespace CourseWorkCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// Создаем локацию
            Location townSquare = new Location("Городская площадь", "Центр города с оживленной атмосферой.");

            // Создаем несколько NPC
            NPC npc1 = new NPC("Местный житель", "Простой горожанин, занятый своими делами.");
            NPC npc2 = new NPC("Торговец", "Продающий различные товары для путешественников.");
            NPC npc3 = new NPC("Стражник", "Охранник города, внимательно следящий за порядком.");

            // Добавляем NPC в локацию
            townSquare.AddInteractiveObject(npc1);
            townSquare.AddInteractiveObject(npc2);
            townSquare.AddInteractiveObject(npc3);

            // Входим в локацию
            townSquare.OnEnter();*/

            //Function.MainMenu();

            //Character mainCharacter = Function.CreateMainCharacter();

            //Function.Introduction(ref mainCharacter);

            //Function.Prologue(mainCharacter);

            //Function.EnterEmerdaleLocation(mainCharacter);

            //Function.GoodEnding(mainCharacter);
            //Function.BadEnding(mainCharacter);

            CombatSystem fight = new CombatSystem();
            Wolf wolf = new Wolf("Волк", 100, 50, 50);

            Weapon sword = new Weapon("Меч", 30, 25);
            Magic fireball = new Magic("Огенный шар", 35, 25);
            Character mainCharacter = new Character("SHICHI", 100, 30, 35, sword, fireball, "Воин");

            fight.StartGame(mainCharacter, wolf);
        }
    }
}
