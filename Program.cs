using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            double human_health_point = 400; // изначальное здоровье человека
            double human_damage = 128; // урон человека
            double human_armor = 260; // броня человека
         


            double monster_health_point = 200; // изначальное здоровье монстра
            double monster_damage = 130; // урон монстра
            double monster_armor = 64; // броня монстра

            double human_reduce_health_point = (monster_damage / human_armor); // отнимаемое здоровье человека
            double monster_reduce_health_point = (human_damage / monster_armor); // отнимаемое здоровье монстра


            Console.WriteLine("Бой начинается!");
            while (monster_health_point > 0 && human_health_point > 0)
            {
                Console.WriteLine("Монстр наносит удар");
                Console.WriteLine($"Здоровье человека: { human_health_point -= human_reduce_health_point}");
              
                Console.WriteLine("Человек наносит удар");
                Console.WriteLine($"Здоровье монстра: { monster_health_point -= monster_reduce_health_point}");
               
            }
            if(monster_health_point == 0)
            {
                Console.WriteLine("ПОБЕДА ЧЕЛОВЕКА!");
            }
            else if (human_health_point == 0)
            {
                Console.WriteLine("ПОБЕДА МОНСТРА!");
            }
           
            Console.ReadKey();

            
        }
    }
}
