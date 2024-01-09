using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseWorkCs
{
    public class Succubus : Character
    {
        public Succubus() : base() { }

        public Succubus(string name, int health, int stamina, int mana)
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

        public override void Attack(Character target)
        {
            Random random = new Random();
            int choice = random.Next(1, 101);

            if (choice <= 25)
            {
                SeductiveGlance(target);
            }
            else if (choice > 25 && choice <= 50)
            {
                DemonicEmbrace(target);
            }
            else if (choice > 50 && choice <= 75)
            {
                CharmingKiss(target);
            }
            else if (choice > 75 && choice <= 90)
            {
                SeductiveWhisper(target);
            }
            else
            {
                PassionateTrap(target);
            }
        }

        public void SeductiveGlance(Character target)
        {
            int staminaCost = 35;
            int damage = 40 + new Random().Next(0, 21);

            if (stamina >= staminaCost)
            {
                Screen.DisplayCharacterByCharacter(name + " очаровывает своим взглядом " + target.GetName() + "!");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устала для очарования взглядом.");
            }
        }

        public void DemonicEmbrace(Character target)
        {
            int staminaCost = 45;
            int damage = 60 + new Random().Next(0, 31);

            if (stamina >= staminaCost)
            {
                Screen.DisplayCharacterByCharacter(name + " обнимает " + target.GetName() + " в демоническом порыве!");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устала для демонического объятия.");
            }
        }

        public void CharmingKiss(Character target)
        {
            int manaCost = 50;
            int damage = 70 + new Random().Next(0, 31);

            if (mana >= manaCost)
            {
                Screen.DisplayCharacterByCharacter(name + " наносит очаровывающий поцелуй " + target.GetName() + "!");
                Screen.DisplayCharacterByCharacter(target.GetName() + " ослаблен от чар.");
                target.TakeDamage(damage);
                target.DecreaseStamina(manaCost / 2);

                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурена для очаровывающего поцелуя.");
            }
        }

        public void SeductiveWhisper(Character target)
        {
            int staminaCost = 40;
            int damage = 45 + new Random().Next(0, 16);

            if (stamina >= staminaCost)
            {
                Screen.DisplayCharacterByCharacter(name + " шепчет завораживающие слова " + target.GetName() + "!");
                target.TakeDamage(damage);
                Screen.DisplayCharacterByCharacter(name + " восстанавливает +" + (damage / 2) + " здоровья от мучений противника.");
                health += damage / 2;
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устала для завораживающего шепота.");
            }
        }

        public void PassionateTrap(Character target)
        {
            int manaCost = 70;
            int damage = 80 + new Random().Next(0, 21);

            if (mana >= manaCost)
            {
                Screen.DisplayCharacterByCharacter(name + " создает ловушку страсти вокруг " + target.GetName() + "!");
                Screen.DisplayCharacterByCharacter(target.GetName() + " погружается в вихрь страстных эмоций и получает урон.");
                target.TakeDamage(damage);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурена для создания ловушки страсти.");
            }
        }
    }
}
