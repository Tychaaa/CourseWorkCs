using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCs
{
    /*
    *   ВЛАДЫКА ТЬМЫ (DARK LORD)
    */
    public class DarkLord : Character
    {
        public DarkLord() : base() { }

        public DarkLord(string name, int health, int stamina, int mana)
            : base(name, health, stamina, mana, null, null, "")
        {
            experience = 200;
        }

        public override int RegenerateStamina()
        {
            int staminaRegenerationAmount = 40;

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
            int manaRegenerationAmount = 40;

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

        public void BlackFlash(Character target)
        {
            int staminaCost = 70;
            int manaCost = 70;

            if (stamina >= staminaCost && mana >= manaCost)
            {
                int damage = 40 + new Random().Next(0, 21);
                Screen.DisplayCharacterByCharacter(name + " создает мрак, окутывающий поле битвы... Темнота пожирает свет!\n");

                Screen.DisplayCharacterByCharacter(name + " с кинжалом в руке проносится сквозь мрак, оставляя лишь мерцающие следы...\n");
                target.TakeDamage(damage);

                Screen.DisplayCharacterByCharacter(name + " с криком зверя вцепился когтями, рассекая воздух...\n");
                target.TakeDamage(damage);

                Screen.DisplayCharacterByCharacter(name + " словно зверь, бросается в атаку, нанося свирепые раны...\n");
                target.TakeDamage(damage);

                Screen.DisplayCharacterByCharacter("Мрак медленно рассеивается, возвращая видимость на поле битвы.\n");

                DecreaseStamina(staminaCost);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для создания мрака.\n");
            }
        }

        public void ShadowStrike(Character target)
        {
            int staminaCost = 50;
            int manaCost = 40;

            if (stamina >= staminaCost && mana >= manaCost)
            {
                int damage = 70 + new Random().Next(0, 16);
                Screen.DisplayCharacterByCharacter(name + " направляет мощный клинок из тьмы на " + target.GetName() + ".\n");
                Screen.DisplayCharacterByCharacter(name + " с неистовством задевает своих прислужников, разрушая своё собственное княжество.\n");
                target.TakeDamage(damage);

                DecreaseStamina(staminaCost);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для теневого удара.\n");
            }
        }

        public void SummonMinions(Character target)
        {
            int manaCost = 65;

            if (mana >= manaCost)
            {
                int damage = 50 + new Random().Next(0, 26);
                Screen.DisplayCharacterByCharacter(name + " призывает теневых существ, нападающих на " + target.GetName() + ".\n");

                Screen.DisplayCharacterByCharacter("Существо материализуется перед " + target.GetName() + ", его зловещий взгляд поражает цель.\n");
                target.TakeDamage(damage);

                Screen.DisplayCharacterByCharacter("Существо нападает с мрачной яростью, его удары поражают " + target.GetName() + "!\n");
                target.TakeDamage(damage);

                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для призыва прислужников.\n");
            }
        }

        public void EnergyAbsorption(Character target)
        {
            int manaCost = 70;

            if (mana >= manaCost)
            {
                int healAmount = 40 + new Random().Next(0, 21);
                Screen.DisplayCharacterByCharacter(name + " поглощает энергию из окружающей тьмы, восстанавливая своё здоровье.\n");
                health += healAmount;
                Screen.DisplayCharacterByCharacter(name + " обретает новую силу, восстановив " + healAmount + " единиц здоровья.\n");

                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком истощен, чтобы поглотить энергию вокруг себя.\n");
            }
        }

        public void WorldHeartDestruction(Character target)
        {
            int staminaCost = 70;
            int manaCost = 50;

            if (stamina >= staminaCost && mana >= manaCost)
            {
                int damage = 90 + new Random().Next(0, 16);
                Screen.DisplayCharacterByCharacter(name + " направляет разрушительную атаку на фундамент мира, нанося урон " + target.GetName() + ".\n");
                target.TakeDamage(damage);

                DecreaseStamina(staminaCost);
                DecreaseMana(manaCost);
            }
            else
            {
                Screen.DisplayCharacterByCharacter(name + " слишком устал для атаки по фундаменту мира.\n");
            }
        }

        public void ManaDrain(Character target)
        {
            int manaDamage = 30 + new Random().Next(0, 16);

            Screen.DisplayCharacterByCharacter(name + " воплощает тьму в атаке, высасывая энергию из " + target.GetName() + ", истощая его ману.\n");
            target.SetMana(GetMana() - manaDamage);
            mana += manaDamage;
        }

        public override void Attack(Character target)
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 101);

            if (choice <= 20)
            {
                BlackFlash(target);
            }
            else if (choice > 20 && choice <= 40)
            {
                ShadowStrike(target);
            }
            else if (choice > 40 && choice <= 60)
            {
                SummonMinions(target);
            }
            else if (choice > 60 && choice <= 80)
            {
                EnergyAbsorption(target);
            }
            else if (choice > 80 && choice <= 90)
            {
                WorldHeartDestruction(target);
            }
            else
            {
                ManaDrain(target);
            }
        }
    }

}
