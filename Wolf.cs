using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseWorkCs
{
    /*
    *   ВОЛК (WOLF)
    */
    public class Wolf : Character
    {
        public Wolf() : base() { }

        public Wolf(string name, int health, int stamina, int mana)
            : base(name, health, stamina, mana, null, null, "")
        {
            experience = 25;
        }

        public override int RegenerateStamina()
        {
            int staminaRegenerationAmount = 10;

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

        public void Bite(Character target)
        {
            int staminaCost = 15;

            if (stamina >= staminaCost)
            {
                int damage = 30;
                Screen.DisplayCharacterByCharacter(name + " с силой кусает " + target.GetName() + ".\n");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " внезапно выдохся и начинает отступать.\n");
            }
        }

        public void ClawAttack(Character target)
        {
            int staminaCost = 20;

            if (stamina >= staminaCost)
            {
                int damage = 10;
                Screen.DisplayCharacterByCharacter(name + " рычит и наносит жесткий удар когтями по " + target.GetName() + ".\n");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " выдохся и отступает, осознавая, что не в состоянии нанести удар когтями.\n");
            }
        }

        public override void Attack(Character target)
        {
            Random random = new Random();
            int choice = random.Next(1, 101);

            if (choice <= 30)
            {
                ClawAttack(target);
            }
            else if (choice > 30 && choice <= 90)
            {
                Bite(target);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " промахивается и не попадает по " + target.GetName() + ".\n");
            }
        }
    }
}
