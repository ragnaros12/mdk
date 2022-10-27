using System;

namespace projects
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int max = 0;
            string login, password;
            const string loginConst = "логин", passwordConst = "пароль";
            do
            {
                Console.WriteLine("ввод логина");
                login = Console.ReadLine();
                Console.WriteLine("ввод пароля");
                password = Console.ReadLine();
                max++;
                if (max == 3)
                    return;
            } while(login != loginConst || password != passwordConst);


            Console.WriteLine("вход успешен");
            double health = rnd.Next(20,100), health1 = rnd.Next(20,100);
            int armor = rnd.Next(100), armor1 = rnd.Next(100);
            Console.WriteLine($"здоровье 1 - {health}, здоровье 2 - {health1}, армор 1 - {armor}, армор 2 - {armor1}");

            while (health > 0 || health1 > 0)
            {
                double damage = rnd.Next(20), damage1 = rnd.Next(20);
                damage -= damage / 100 * armor1;
                damage1 -= damage1 / 100 * armor;
                Console.WriteLine($"урон 1 - {damage}, урон 2 - {damage1}");
                health -= damage1;
                health1 -= damage;
                Console.WriteLine($"остаток hp 1 - {health}, отстаток 2 - {health1}");
            }

            if (health < 0)
                Console.WriteLine("победа 1");
            else
                Console.WriteLine("победа 2");
        }
    }
}