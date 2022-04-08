using System;

namespace SChekalinCsharpModule4task4_1_17
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите свое имя:");
			string name = Console.ReadLine();
			for (int i = name.Length - 1; i >=0; i--)
				Console.Write($"{name[i]} ");
		}
	}
}
