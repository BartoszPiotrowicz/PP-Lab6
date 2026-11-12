//using System;
//using System.Collections;
//using System.Collections.Generic;

//class program
//{
//    static void Main()
//    {
//        void WriteAliveEnemies(List<Enemy> enemies_)
//        {
//            Console.WriteLine("Alive enemies: ");

//            foreach (Enemy enemy in enemies_)
//            {
//                if (enemy.Health > 0)
//                {
//                    Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
//                }
//            }
//        }

//        int TotalEnemyHP(List<Enemy> enemies_)
//        {
//            int sum = 0;

//            foreach (Enemy enemy in enemies_)
//            {
//                if (enemy.IsAlive())
//                {
//                    sum += enemy.Health;
//                }
//            }

//            return sum;
//        }

//        void FindMaxHPEnemy(List<Enemy> enemies_)
//        {
//            Enemy max_hp_enemy = new Enemy("", 0, 0);

//            foreach (Enemy enemy in enemies_)
//            {
//                if (enemy.Health > max_hp_enemy.Health)
//                {
//                    max_hp_enemy = enemy;
//                }
//            }

//            Console.WriteLine("Max HP enemy: " + max_hp_enemy.Name);
//        }

//        int CountDeadEnemies(List<Enemy> enemies_)
//        {
//            int dead_count = 0;

//            foreach (Enemy enemy in enemies_)
//            {
//                if (enemy.Health <= 0)
//                {
//                    dead_count++;
//                }
//            }

//            return dead_count;
//        }

//        Player player_one = new Player("Maciuś", 100, 25, 1, 0);
//        Player player_two = new Player("Vox", 2137, 99999, 100, 99999999);

//        List<Enemy> enemies = new List<Enemy>
//        {
//            new Enemy("Goblin", 30, 8),
//            new Enemy("Giant Bat", 20, 5),
//            new Enemy("Orc", 70, 15),
//            new Enemy("Jerzy", 10, 1),
//            new Enemy("Scary Larry", 250, 50)
//        };

//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine($"ROUND {i+1}: ");

//            foreach (Enemy enemy in enemies)
//            {
//                enemy.Health -= 15;
//            }

//            WriteAliveEnemies(enemies);

//            int total_enemy_hp = TotalEnemyHP(enemies);

//            Console.WriteLine("Enemy HP sum: " + total_enemy_hp);

//            FindMaxHPEnemy(enemies);

//            int dead_enemies_count = CountDeadEnemies(enemies);

//            Console.WriteLine("Dead enemies count: " + dead_enemies_count + "\n");
//        }
//    }
//}