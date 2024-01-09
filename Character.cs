using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    public class Character
    {
        protected string name;      // Имя
        protected int health;       // Здоровье
        protected int stamina;      // Выносливость
        protected int mana;         // Запас маны
        protected int maxHealth;
        protected int maxStamina;
        protected int maxMana;
        protected int level;        // Уровень игрока
        protected int experience;   // Опыт игрока
        protected string classType; // Класс игрока
        protected Weapon weapon;    // Оружие персонажа
        protected Magic magic;      // Магия персонажа

        public Character()
        {
            name = "";
            health = 0;
            stamina = 0;
            mana = 0;
            level = 0;
            experience = 0;
            classType = "";
            maxHealth = 0;
            maxStamina = 0;
            maxMana = 0;
        }

        public Character(string name, int health, int stamina, int mana, Weapon weapon, Magic magic, string classType)
        {
            this.name = name;
            this.health = health;
            this.stamina = stamina;
            this.mana = mana;
            this.weapon = weapon;
            this.magic = magic;
            this.classType = classType;
            maxHealth = health;
            maxStamina = stamina;
            maxMana = mana;
        }

        public Character(string name, int health, int stamina, int mana, Weapon weapon, Magic magic, int experience)
        {
            this.name = name;
            this.health = health;
            this.stamina = stamina;
            this.mana = mana;
            this.weapon = weapon;
            this.magic = magic;
            this.experience = experience;
            maxHealth = health;
            maxStamina = stamina;
            maxMana = mana;
        }

        // Геттеры и Сеттеры
        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public int GetHealth()
        {
            return health;
        }

        public void SetHealth(int newHealth)
        {
            health = newHealth;
        }

        public int GetStamina()
        {
            return stamina;
        }

        public void SetStamina(int newStamina)
        {
            stamina = newStamina;
        }

        public int GetMana()
        {
            return mana;
        }

        public void SetMana(int newMana)
        {
            mana = newMana;
        }

        public int GetMaxHealth()
        {
            return maxHealth;
        }

        public void SetMaxHealth(int value)
        {
            maxHealth = value;
        }

        public int GetMaxStamina()
        {
            return maxStamina;
        }

        public void SetMaxStamina(int value)
        {
            maxStamina = value;
        }

        public int GetMaxMana()
        {
            return maxMana;
        }

        public void SetMaxMana(int value)
        {
            maxMana = value;
        }

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel(int newLevel)
        {
            level = newLevel;
        }

        public int GetExperience()
        {
            return experience;
        }

        public void SetExperience(int newExp)
        {
            experience += newExp;
            while (experience >= 100)
            {
                LevelUp();
                experience -= 100;
            }
        }

        public string GetClassType()
        {
            return classType;
        }

        public void SetClassType(string newClass)
        {
            classType = newClass;
        }

        public Weapon GetWeapon()
        {
            return weapon;
        }

        public void SetWeapon(Weapon newWeapon)
        {
            weapon = newWeapon;
        }

        public Magic GetMagic()
        {
            return magic;
        }

        public void SetMagic(Magic newMagic)
        {
            magic = newMagic;
        }


        public virtual void Attack(Character target)
        {
            Random random = new Random();
            int choice = random.Next(1, 101);

            if (choice <= 45)
            {
                if (weapon == null)
                {
                    return;
                }
                AttackWeapon(target);
            }
            else if (choice > 45 && choice <= 90)
            {
                if (magic == null)
                {
                    return;
                }
                CastSpell(target);
            }
            else
            {
                Console.WriteLine(name + " промахивается и не попадает по " + target.GetName() + ".\n");
            }
        }

        public void AttackWeapon(Character target)
        {
            Console.WriteLine(name + " атакует " + target.GetName() + ", используя " + weapon.GetName() + ".\n");
            target.TakeDamage(weapon.GetDamage());
            DecreaseStamina(weapon.GetCost());
        }

        public void CastSpell(Character target)
        {
            Console.WriteLine(name + " кастует " + magic.GetName() + " на " + target.name + ".\n");
            target.TakeDamage(magic.GetDamage());
            DecreaseMana(magic.GetCost());
        }

        public void TakeDamage(int damage)
        {
            if (health < damage)
            {
                health = 0;
            }
            else
            {
                health -= damage;
            }

            Console.WriteLine(name + " получил " + damage + " урона.\n");
        }

        // Метод уменьшения запаса выносливости
        public void DecreaseStamina(int cost)
        {
            stamina -= cost;
        }

        // Метод уменьшения запаса маны
        public void DecreaseMana(int cost)
        {
            mana -= cost;
        }

        // Метод восстановления выносливости
        public virtual int RegenerateStamina()
        {
            int staminaRegenerationAmount = 10 + (int)(0.5 * level);
            if (stamina < maxStamina)
            {
                stamina += staminaRegenerationAmount;
                if (stamina > maxStamina)
                {
                    stamina = maxStamina;
                }
            }
            return staminaRegenerationAmount;
        }

        // Метод восстановления маны
        public virtual int RegenerateMana()
        {
            int manaRegenerationAmount = 10 + (int)(0.5 * level);
            if (mana < maxMana)
            {
                mana += manaRegenerationAmount;
                if (mana > maxMana)
                {
                    mana = maxMana;
                }
            }
            return manaRegenerationAmount;
        }

        // Метод повышения уровня персонажа
        public void LevelUp()
        {
            level++;

            // Увеличиваем параметры персонажа при достижении нового уровня
            maxHealth += 10;
            maxStamina += 5;
            maxMana += 8;
            health = maxHealth;
            stamina = maxStamina;
            mana = maxMana;

            // Выводим сообщение о повышении уровня персонажа
            Console.Write("\nУровень героя " + name + " повышен до ");
            Thread.Sleep(500);

            foreach (char c in level.ToString())
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
            Console.WriteLine("!");

            Console.Write("Здоровье увеличено до ");
            Thread.Sleep(500);
            foreach (char c in health.ToString())
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
            Console.WriteLine();

            Console.Write("Выносливость увеличена до ");
            Thread.Sleep(500);
            foreach (char c in stamina.ToString())
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
            Console.WriteLine();

            Console.Write("Мана увеличена до ");
            Thread.Sleep(500);
            foreach (char c in mana.ToString())
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }
    }
}
