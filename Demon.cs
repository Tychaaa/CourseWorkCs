using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    public class Demon : Character
    {
        public Demon() : base() { }

        public Demon(string name, int health, int stamina, int mana)
            : base(name, health, stamina, mana, null, null, "")
        {
            experience = 70;
        }

        public override int RegenerateStamina()
        {
            int staminaRegenerationAmount = 15;

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

        public override int RegenerateMana()
        {
            int manaRegenerationAmount = 15;

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

        public void HellishLash(Character target)
        {
            int staminaCost = 40;
            int manaCost = 40;

            if (stamina >= staminaCost && mana >= manaCost)
            {
                int damage = 60 + new Random().Next(0, 26);
                Screen.DisplayCharacterByCharacter(name + " с демоническим ревом вызывает пламенный кнут из бездны, который охватывает " + target.GetName() + " огненным ударом.\n");
                target.TakeDamage(damage);
                Screen.DisplayCharacterByCharacter("Пламя оставляет горящий след на земле, испуская дурманящий дым.\n");

                DecreaseStamina(staminaCost);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для вызова пламенного кнута.\n");
            }
        }

        public void CursedOath(Character target)
        {
            int staminaCost = 30;
            int manaCost = 25;

            if (stamina >= staminaCost && mana >= manaCost)
            {
                int damage = 50 + new Random().Next(0, 16);
                int staminaDamage = 10;
                Screen.DisplayCharacterByCharacter("Демон-стражник произносит древние мистические слова, наложенные на оружие, и наносит проклятый удар по " + target.GetName() + ".\n");
                target.TakeDamage(damage);
                Screen.DisplayCharacterByCharacter("Удар оставляет темное пятно на доспехах " + target.GetName() + ", вызывая временную слабость.\n");
                target.SetStamina(target.GetStamina() - staminaDamage);

                DecreaseStamina(staminaCost);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для проклятого обета.\n");
            }
        }

        public void InfernalCurse(Character target)
        {
            int manaCost = 40;

            if (mana >= manaCost)
            {
                int staminaDamage = 60;
                Screen.DisplayCharacterByCharacter("Демон-стражник бросает адское проклятие на " + target.GetName() + ", погружая его в мир адской муки.\n");
                Screen.DisplayCharacterByCharacter("Проклятие оставляет " + target.GetName() + " в изнурительных страданиях, ослабляя его силы.\n");
                target.SetStamina(target.GetStamina() - staminaDamage);

                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком истощен для проклятия.\n");
            }
        }

        public void InfernalBlade(Character target)
        {
            int staminaCost = 60;
            int manaCost = 60;

            if (stamina >= staminaCost && mana >= manaCost)
            {
                int damage = 70 + new Random().Next(0, 16);
                Screen.DisplayCharacterByCharacter("Демон-стражник создает клинок из тьмы и огня, направляя его в сторону " + target.GetName() + ".\n");
                target.TakeDamage(damage);

                DecreaseStamina(staminaCost);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для создания клинка.\n");
            }
        }

        public override void Attack(Character target)
        {
            Random random = new Random();
            int choice = random.Next(1, 101);

            if (choice <= 25)
            {
                HellishLash(target);
            }
            else if (choice > 25 && choice <= 50)
            {
                CursedOath(target);
            }
            else if (choice > 50 && choice <= 75)
            {
                InfernalCurse(target);
            }
            else if (choice > 75 && choice <= 100)
            {
                InfernalBlade(target);
            }
        }
    }

}
