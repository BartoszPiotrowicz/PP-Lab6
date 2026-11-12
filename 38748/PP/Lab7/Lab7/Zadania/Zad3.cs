//using System;
//using System.Collections.Generic;

//class program
//{
//    static void Main()
//    {
//        Player player_one = new Player("Maciuś", 100, 25, 1, 0);
//        Player player_two = new Player("Vox", 2137, 99999, 100, 99999999);
//        Enemy goblin = new Enemy("Goblin", 30, 8);
//        Enemy orc = new Enemy("Orc", 50, 12);

//        Console.WriteLine("ROUND 1");

//        Console.WriteLine($"{player_one.Name} spotyka {goblin.Name}.");
//        Console.WriteLine($"{player_one.Name} ma {player_one.Health} HP.");
//        Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

//        for (int i = 0; i < 10; i++)
//        {
//            if (goblin.IsAlive())
//            {
//                player_one.TakeDamage(i);
//            }
//            if (player_one.IsAlive())
//            {
//                goblin.TakeDamage(i);
//            }

//            Console.WriteLine($"{player_one.Name} ma {player_one.Health} HP.");
//            Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

//            Console.WriteLine($"{player_two.Name} ma {player_two.Health} HP.");
//            Console.WriteLine($"{orc.Name} ma {orc.Health} HP.");
//        }

//        Console.WriteLine("\nROUND 2");
//        Console.WriteLine($"{player_two.Name} spotyka {orc.Name}.");

//        for (int i = 0; i < 3; i++)
//        {
//            if (orc.IsAlive())
//            {
//                player_two.TakeDamage(i);
//            }
//            if (player_two.IsAlive())
//            {
//                orc.TakeDamage(i + 25);
//            }

//            Console.WriteLine($"{player_one.Name} ma {player_one.Health} HP.");
//            Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");

//            Console.WriteLine($"{player_two.Name} ma {player_two.Health} HP.");
//            Console.WriteLine($"{orc.Name} ma {orc.Health} HP.");
//        }
//    }
//}