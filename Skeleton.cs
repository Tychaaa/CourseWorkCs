using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseWorkCs
{
    /*
    *   СКЕЛЕТ (SKELETON)
    */
    public class Skeleton : Character
    {
        public Skeleton() : base() { }

        public Skeleton(string name, int health, int stamina, int mana)
            : base(name, health, stamina, mana, null, null, "")
        {
            experience = 30;
        }

        public override int RegenerateStamina()
        {
            int staminaRegenerationAmount = 10;

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

        public void BoneStrike(Character target)
        {
            int staminaCost = 20;

            if (stamina >= staminaCost)
            {
                int damage = 25;
                Screen.DisplayCharacterByCharacter(name + " размахивает костями и ударяет " + target.GetName() + ".\n");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для удара костями.\n");
            }
        }

        public void ThrowBone(Character target)
        {
            int staminaCost = 15;

            if (stamina >= staminaCost)
            {
                int damage = 15;
                Screen.DisplayCharacterByCharacter(name + " бросает кость в " + target.GetName() + ".\n");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал, чтобы бросить кость.\n");
            }
        }

        public override void Attack(Character target)
        {
            Random random = new Random();
            int choice = random.Next(1, 101);

            if (choice <= 40)
            {
                BoneStrike(target);
            }
            else if (choice > 40 && choice <= 80)
            {
                ThrowBone(target);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " промахивается и не попадает по " + target.GetName() + ".\n");
            }
        }
    }
}
