/*
 * Created by SharpDevelop.
 * User: contr
 * Date: 26/04/2021
 * Time: 21:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace media
{
	class Program
	{
		public static void Main(string[] args)
		{
			float num1, num2, num3, num4, num5, media;

			Console.WriteLine("Calculadora de Média!\n\nDigite os 5 números para saber sua média!");

			Console.WriteLine("\n\nNúmero 1: ");
				num1 = float.Parse(Console.ReadLine());

			Console.WriteLine("\n\nNúmero 2: ");
				num2 = float.Parse(Console.ReadLine());

			Console.WriteLine("\n\nNúmero 3: ");
				num3 = float.Parse(Console.ReadLine());

			Console.WriteLine("\n\nNúmero 4: ");
				num4 = float.Parse(Console.ReadLine());

			Console.WriteLine("\n\nNúmero 5: ");
				num5 = float.Parse(Console.ReadLine());

				media = (num1+num2+num3+num4+num5)/5;

			Console.WriteLine("A média é de: " +media.ToString("N2"));

			Console.ForegroundColor=ConsoleColor.Red;
			Console.Write("Pressione qualquer tecla...");
			Console.ReadKey(true);
			Console.ForegroundColor=ConsoleColor.White;
		}
	}
}