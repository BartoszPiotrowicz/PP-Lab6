//using System;
//using System.Collections.Generic;

//class program
//{
//    static void Main()
//    {
//        Player player = new Player("Maciuś", 100, 25, 1, 0);
//        Enemy goblin = new Enemy("Goblin", 30, 8);

//        Console.WriteLine($"{player.Name} spotyka {goblin.Name}.");

//        for (int i = 0; i < 10; i++)
//        {
//            player.GainExp(i);
//            Console.WriteLine("Exp: " + player.Experience);
//            Console.WriteLine("Level: " + player.Level);
//        }

//        goblin.TakeDamage(12);
//        Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

//        if (goblin.IsAlive())
//        {
//            player.TakeDamage(goblin.Damage);
//            Console.WriteLine($"{player.Name} ma {player.Health} HP.");
//        }
//        else
//        {
//            Console.WriteLine("Przeciwnik został pokonany.");
//        }

//        List<Enemy> enemies = new List<Enemy>
//        {
//            new Enemy("Goblin", 30, 8),
//            new Enemy("Nietoperz", 20, 5),
//            new Enemy("Ork", 70, 15)
//        };

//        foreach (Enemy enemy in enemies)
//        {
//            Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
//        }

//    }
//}