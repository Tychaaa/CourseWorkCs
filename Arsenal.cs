using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    public class Arsenal
    {
        protected string name;
        protected int damage;
        protected int cost; // Общий атрибут для затрат

        // Конструктор по умолчанию
        public Arsenal()
        {
            name = "";
            damage = 0;
            cost = 0;
        }

        // Конструктор с параметрами
        public Arsenal(string n, int dmg, int cst)
        {
            name = n;
            damage = dmg;
            cost = cst;
        }

        // Геттеры
        public string GetName()
        {
            return name;
        }

        public int GetDamage()
        {
            return damage;
        }

        public int GetCost()
        {
            return cost;
        }

        // Сеттеры
        public void SetName(string n)
        {
            name = n;
        }

        public void SetDamage(int dmg)
        {
            damage = dmg;
        }

        public void SetCost(int cst)
        {
            cost = cst;
        }
    }
}
