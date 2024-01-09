using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    public class Enchantress : Character
    {
        public Enchantress() : base() { }

        public Enchantress(string name, int health, int stamina, int mana)
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

            if (choice <= 25)
            {
                MysticTouch(target);
            }
            else if (choice > 25 && choice <= 50)
            {
                EtherealDance(target);
            }
            else if (choice > 50 && choice <= 75)
            {
                MysticBlast(target);
            }
            else if (choice > 75 && choice <= 90)
            {
                WhirlwindOfEnchantment(target);
            }
            else
            {
                MirrorIllusion(target);
            }
        }

        public void MysticTouch(Character target)
        {
            int staminaCost = 40;
            int damage = 50 + new Random().Next(0, 11);

            if (stamina >= staminaCost)
            {
                Screen.DisplayCharacterByCharacter(name + " прикасается к " + target.GetName() + " мистическим прикосновением!\n");
                target.TakeDamage(damage);
                DecreaseStamina(staminaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устала для мистического прикосновения.\n");
            }
        }

        public void EtherealDance(Character target)
        {
            int manaCost = 50;
            int damage = 55 + new Random().Next(0, 11);

            if (mana >= manaCost)
            {
                Screen.DisplayCharacterByCharacter(name + " исполняет эфирный танец перед " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурена для эфирного танца.\n");
            }
        }

        public void MysticBlast(Character target)
        {
            int manaCost = 55;
            int damage = 55 + new Random().Next(0, 11);

            if (mana >= manaCost)
            {
                Screen.DisplayCharacterByCharacter(name + " выпускает мистический взрыв по " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурена для мистического взрыва.\n");
            }
        }

        public void WhirlwindOfEnchantment(Character target)
        {
            int manaCost = 70;
            int damage = 60 + new Random().Next(0, 11);

            if (mana >= manaCost)
            {
                Screen.DisplayCharacterByCharacter(name + " создает вихрь заклинаний вокруг " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурена для создания вихря заклинаний.\n");
            }
        }

        public void MirrorIllusion(Character target)
        {
            int manaCost = 60;
            int damage = 65 + new Random().Next(0, 11);

            if (mana >= manaCost)
            {
                Screen.DisplayCharacterByCharacter(name + " создает зеркальную иллюзию, которая атакует " + target.GetName() + "!\n");
                target.TakeDamage(damage);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком изнурена для создания зеркальной иллюзии.\n");
            }
        }
    }

}
