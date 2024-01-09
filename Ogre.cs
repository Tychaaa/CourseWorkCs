using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    /*
    *   ОГР (OGRE)
    */

    public class Ogre : Character
    {
        public Ogre() : base() { }

        public Ogre(string name, int health, int stamina, int mana)
            : base(name, health, stamina, mana, null, null, "")
        {
            experience = 35;
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

        public void Smash(Character target)
        {
            int staminaCost = 30; // Стоимость выносливости для удара

            if (stamina >= staminaCost)
            {
                int damage = 25;
                Screen.DisplayCharacterByCharacter(name + " размахивает кулаками и наносит сокрушительный удар по " + target.GetName() + ".");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " чувствует усталость и не может совершить удар с полной силой.");
            }
        }

        public void GroundPound(Character target)
        {
            int staminaCost = 50; // Стоимость выносливости для удара

            if (stamina >= staminaCost)
            {
                int damage = 30;
                Screen.DisplayCharacterByCharacter(name + " наносит мощный удар о землю, поднимается волна, ударяя " + target.GetName() + ".");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для такого мощного удара. Ему не хватает выносливости.");
            }
        }

        public void FistAttack(Character target)
        {
            int staminaCost = 15; // Стоимость выносливости для удара

            if (stamina >= staminaCost)
            {
                int damage = 15;
                Screen.DisplayCharacterByCharacter(name + " наносит удар кулаком по " + target.GetName() + ".");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для удара кулаком и начинает отступать.");
            }
        }

        public override void Attack(Character target)
        {
            Random random = new Random();
            int choice = random.Next(1, 101);

            if (choice <= 40)
            {
                FistAttack(target);
            }
            else if (choice > 40 && choice <= 80)
            {
                GroundPound(target);
            }
            else if (choice > 80 && choice <= 90)
            {
                Smash(target);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " промахивается и не попадает по " + target.GetName() + ".");
            }
        }
    }
}
