/*
 * Created by SharpDevelop.
 * User: contr
 * Date: 26/04/2021
 * Time: 22:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace forca
{
	class Program
	{
		public static void Main(string[] args)
		{
			float f, m, a;

			Console.WriteLine("Digite a massa: ");
				m = float.Parse(Console.ReadLine());

			Console.WriteLine("\nDigite a aceleração: ");
				a = float.Parse(Console.ReadLine());
			
			f = m * a;

			Console.WriteLine("\n\nA Força é de: " +f.ToString("N2"));

			Console.ForegroundColor=ConsoleColor.Green;
			Console.Write("Pressione qualquer tecla...");
			Console.ReadKey(true);
			Console.ForegroundColor=ConsoleColor.White;
		}
	}
}
