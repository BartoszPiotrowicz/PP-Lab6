using System;

public class Enemy
{
    public string Name { get; }
    public int Health { get; set; }
    public int Damage { get; }

    public Enemy(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void TakeDamage(int damage)
    {
        if (!IsAlive())
        {
            Console.WriteLine("The enemy is already dead, what are you doing");
        }
        else
        {
            Health -= damage;

            if (damage > 0)
            {
                Console.WriteLine("Player dealt " + damage + " damage");
            }
            else if (damage == 0)
            {
                Console.WriteLine("You missed like an idiot");
            }
            else
            {
                Console.WriteLine("You healed the enemy for some reason");
            }

            if (Health < 0)
            {
                Health = 0;
            }
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
