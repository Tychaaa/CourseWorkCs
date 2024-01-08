using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    public class Weapon : Arsenal
    {
        // Конструктор по умолчанию
        public Weapon() : base()
        {
            // Вызов конструктора базового класса Arsenal
        }

        // Конструктор с параметрами
        public Weapon(string n, int dmg, int cst) : base(n, dmg, cst)
        {
            // Вызов конструктора базового класса Arsenal с параметрами
        }
    }
}