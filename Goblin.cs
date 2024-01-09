using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseWorkCs
{
    /*
    *   ГОБЛИН (GOBLIN)
    */
    public class Goblin : Character
    {
        public Goblin() : base() { }

        public Goblin(string name, int health, int stamina, int mana)
            : base(name, health, stamina, mana, null, null, "")
        {
            experience = 20;
        }

        public override int RegenerateStamina()
        {
            int staminaRegenerationAmount = 15;

            if (stamina < maxStamina)
            {
                stamina += staminaRegenerationAmount;
                if (stamina > maxStamina)
                {
                    stamina = maxStamina; // Устанавливаем значение стамины в максимум, если превысили
                }
            }
            return staminaRegenerationAmount;
        }

        public void SneakAttack(Character target)
        {
            int staminaCost = 20;

            if (stamina >= staminaCost)
            {
                int damage = 20;
                Screen.DisplayCharacterByCharacter(name + " прикрывается и наносит удар из тени по " + target.GetName() + ".\n");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для скрытного нападения.\n");
            }
        }

        public void ThrowRock(Character target)
        {
            int staminaCost = 15;

            if (stamina >= staminaCost)
            {
                int damage = 15;
                Screen.DisplayCharacterByCharacter(name + " метает камень в " + target.GetName() + ".\n");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для метания камня.\n");
            }
        }

        public override void Attack(Character target)
        {
            Random random = new Random();
            int choice = random.Next(1, 101);

            if (choice <= 40)
            {
                SneakAttack(target);
            }
            else if (choice > 40 && choice <= 80)
            {
                ThrowRock(target);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " промахивается и не попадает по " + target.GetName() + ".\n");
            }
        }
    }
}
