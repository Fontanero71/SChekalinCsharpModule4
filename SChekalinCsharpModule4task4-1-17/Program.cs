using System;

namespace SChekalinCsharpModule4task4_1_17
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Напишите свой любимый текст с маленькой буквы");
			for (int i = 1; i < 5; i++)
			{
				Console.WriteLine($"Iteration {i}");

				switch (Console.ReadLine())
				{
					case "red":
						Console.BackgroundColor = ConsoleColor.Red;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is red!");
						break;

					case "green":
						Console.BackgroundColor = ConsoleColor.Green;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is green!");
						break;
					case "cyan":
						Console.BackgroundColor = ConsoleColor.Cyan;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is cyan!");
						break;

					default:
						Console.BackgroundColor = ConsoleColor.Yellow;
						Console.ForegroundColor = ConsoleColor.Red;

						Console.WriteLine("Your color is yellow!");
						break;
				}
			}
		}
	}
}
