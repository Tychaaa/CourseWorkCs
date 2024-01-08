namespace CourseWorkCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем локацию
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
            townSquare.OnEnter();
        }
    }
}
