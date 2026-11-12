using System;

public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public Player(string name, int maxHealth, int gold, int level, int experience)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
        Level = level;
        Experience = experience;
    }

    public void TakeDamage(int damage)
    {
        if (!IsAlive())
        {
            Console.WriteLine("You already killed bro leave him be");
        }
        else
        {
            Health -= damage;

            if (damage > 0)
            {
                Console.WriteLine("Enemy dealt " + damage + " damage");
            }
            else if (damage == 0)
            {
                Console.WriteLine("The enemy missed like an idiot");
            }
            else
            {
                Console.WriteLine("The enemy healed you for some reason");
            }

            if (Health < 0)
            {
                Health = 0;
            }
        }

    }

    public void Heal(int amount)
    {
        if (!IsAlive()) 
        {
            Console.WriteLine("Dead people don't get to heal");
        }
        else
        {
            Health += amount;

            if (amount == 0)
            {
                Console.WriteLine("Healing failed!!!");
            }

            if (amount < 0)
            {
                Console.WriteLine("You fool! You hurt yourself instead!");
            }

            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void GainExp(int experience)
    {
        if (Experience + experience >= 10 * Level)
        {
            Level += 1;
            MaxHealth += 10;
            Health = MaxHealth;
        }

        Experience += experience;
    }
}
