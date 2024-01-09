using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseWorkCs
{
    public class DarkElf : Character
    {
        public DarkElf() : base() { }

        public DarkElf(string name, int health, int stamina, int mana)
            : base(name, health, stamina, mana, null, null, "")
        {
            experience = 100;
        }

        public override int RegenerateStamina()
        {
            int staminaRegenerationAmount = 25;

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
            int manaRegenerationAmount = 20;

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
            Random rnd = new Random();
            int choice = rnd.Next(1, 101);

            if (choice <= 20)
            {
                ShadowStrike(target);
            }
            else if (choice > 20 && choice <= 40)
            {
                DarkArrow(target);
            }
            else if (choice > 40 && choice <= 60)
            {
                VenomousArrow(target);
            }
            else if (choice > 60 && choice <= 80)
            {
                ShadowStep(target);
            }
            else
            {
                BloodRitual(target);
            }
        }

        public void ShadowStrike(Character target)
        {
            int manaCost = 60;

            if (mana >= manaCost)
            {
                int damage = 80 + new Random().Next(0, 21);
                Screen.DisplayCharacterByCharacter(name + " выползает из тени и наносит скрытный удар " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурен для скрытного удара.\n");
            }
        }

        public void DarkArrow(Character target)
        {
            int staminaCost = 50;

            if (stamina >= staminaCost)
            {
                int damage = 90 + new Random().Next(0, 11);
                Screen.DisplayCharacterByCharacter(name + " выстреливает тёмной стрелой в " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для выстрела тёмной стрелой.\n");
            }
        }

        public void VenomousArrow(Character target)
        {
            int manaCost = 65;

            if (mana >= manaCost)
            {
                int damage = 90 + new Random().Next(0, 11);
                Screen.DisplayCharacterByCharacter(name + " выпускает стрелу, покрытую ядом, в сторону " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурен для стрельбы ядовитой стрелой.\n");
            }
        }

        public void ShadowStep(Character target)
        {
            int manaCost = 80;

            if (mana >= manaCost)
            {
                int damage = 95 + new Random().Next(0, 6);
                Screen.DisplayCharacterByCharacter(name + " мгновенно перемещается в тень и атакует " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурен для мгновенного перемещения.\n");
            }
        }

        public void BloodRitual(Character target)
        {
            int manaCost = 50;

            if (mana >= manaCost)
            {
                int damage = 95 + new Random().Next(0, 6);
                int healing = damage / 2;

                Screen.DisplayCharacterByCharacter(name + " проводит кровавый обряд, направляя древние силы против " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                Screen.DisplayCharacterByCharacter(name + " восстанавливает +" + healing + " здоровья от кровавого обряда.\n");
                health += healing;

                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурен для проведения кровавого обряда.\n");
            }
        }
    }
}
