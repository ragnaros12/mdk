using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//начало на 3
			double first = Convert.ToDouble(Console.ReadLine()),
			second = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine($"{first} + {second} = {first + second}");
			Console.WriteLine($"{first} - {second} = {first - second}");
			Console.WriteLine($"{first} * {second} = {first * second}");
			Console.WriteLine($"{first} / {second} = {first / second}");
			Console.ReadKey();
			//конец на 3

			//начало на 4
			double price = Convert.ToDouble(Console.ReadLine());
			int count = Convert.ToInt32(Console.ReadLine()),
				sell = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"price = {price / 100 * (100 - sell) * count}");
			Console.ReadKey();
			//конец на 4

			//начало на 5
			Random rnd = new Random();
			int x1 = rnd.Next(20), x2 = rnd.Next(20), y1 = rnd.Next(20), y2 = rnd.Next(20);
			Console.WriteLine($"x1 = {x1}; x2 = {x2}; y1 = {y1}; y2 = {y2}");
			Console.WriteLine($"Distance: {Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))}");
			Console.ReadKey();
			//конец на 5

		}
	}
}
