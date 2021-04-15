/*
 * Criado por SharpDevelop.
 * Usuário: matheus
 * Data: 13/04/2021
 * Hora: 13:41
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace retangulo
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Variáveis
			float area, ladoMenor, ladoMaior, perimetro;
			
			//Introdução
			Console.ForegroundColor=ConsoleColor.Red;	//Muda cor da fonte
			Console.WriteLine("Bem vindo a calculadora de perímetro e área de um retângulo!");
			Console.ForegroundColor=ConsoleColor.White;	//Muda cor da fonte
			
			//Obtenção de dados para (ladoMenor)
			Console.WriteLine("\n\nDigite o valor do lado menor: ");
			ladoMenor=float.Parse(Console.ReadLine());

			//Obtenção de dados para (ladoMaior)
			Console.WriteLine("\n\nDigite o valor do lado maior: ");
			ladoMaior=float.Parse(Console.ReadLine());

			//Cálculos
			area= ladoMenor*ladoMaior;
			perimetro = ladoMenor*2+ladoMaior*2;
			
			//Saída
			Console.ForegroundColor=ConsoleColor.Green;	//Muda cor da fonte
			Console.WriteLine("\n\nA área é de: " +area);
			Console.WriteLine("\nO perímetro é de: " +perimetro);
			Console.ForegroundColor=ConsoleColor.White;	//Muda cor da fonte
			
			Console.Write("\nPressione qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}