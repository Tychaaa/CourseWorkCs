using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    /*
    *   ВЕДЬМА (WITCH)
    */
    public class Witch : Character
    {
        public Witch() : base() { }

        public Witch(string name, int health, int stamina, int mana)
            : base(name, health, stamina, mana, null, null, "")
        {
            experience = 80;
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

            if (choice <= 30)
            {
                DarkCurse(target);
            }
            else if (choice > 30 && choice <= 50)
            {
                HexingBlast(target);
            }
            else if (choice > 50 && choice <= 70)
            {
                SummonMinions(target);
            }
            else if (choice > 70 && choice <= 90)
            {
                PoisonousBrew(target);
            }
            else
            {
                MysticalShield(target);
            }
        }

        public void DarkCurse(Character target)
        {
            int manaCost = 70;

            if (mana >= manaCost)
            {
                int damage = 50 + new Random().Next(0, 31);
                Screen.DisplayCharacterByCharacter(name + " накладывает темное проклятие на " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурена для наложения темного проклятия.\n");
            }
        }

        public void HexingBlast(Character target)
        {
            int staminaCost = 80;

            if (stamina >= staminaCost)
            {
                int damage = 50 + new Random().Next(0, 31);
                Screen.DisplayCharacterByCharacter(name + " выпускает волшебный сгусток энергии по " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устала для магического взрыва.\n");
            }
        }

        public void SummonMinions(Character target)
        {
            int manaCost = 50;

            if (mana >= manaCost)
            {
                int damage = 50 + new Random().Next(0, 31);
                Screen.DisplayCharacterByCharacter(name + " призывает миньонов для атаки " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурена для призыва миньонов.\n");
            }
        }

        public void PoisonousBrew(Character target)
        {
            int staminaCost = 55;

            if (stamina >= staminaCost)
            {
                int damage = 50 + new Random().Next(0, 31);
                Screen.DisplayCharacterByCharacter(name + " бросает ядовитое зелье в сторону " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устала для броска ядовитого зелья.\n");
            }
        }

        public void MysticalShield(Character target)
        {
            int manaCost = 70;

            if (mana >= manaCost)
            {
                int shieldAmount = 40 + new Random().Next(0, 31);
                Screen.DisplayCharacterByCharacter(name + " создает мистический щит (+" + shieldAmount + " hp), защищаясь от атак " + target.GetName() + "!\n");
                health += shieldAmount;
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурена для создания мистического щита.\n");
            }
        }
    }

}
