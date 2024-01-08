using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    public class Magic : Arsenal
    {
        // Конструктор по умолчанию
        public Magic() : base()
        {
            // Вызов конструктора базового класса Arsenal
        }

        // Конструктор с параметрами
        public Magic(string n, int dmg, int cst) : base(n, dmg, cst)
        {
            // Вызов конструктора базового класса Arsenal с параметрами
        }
    }
}
