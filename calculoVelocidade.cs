/*
 * Criado por SharpDevelop.
 * Usuário: matheus
 * Data: 07/04/2021
 * Hora: 19:54
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace velocidade
{
	class Program
	{
		public static void Main(string[] args)
		{
			float d, v;
			int t;
			
			//Introdução
			Console.WriteLine("Bem vindo a calculadora de velocidade!");
			
			//Obtenção de dados (d)
			Console.WriteLine("\n\nDigite a distância: ");
			d=float.Parse(Console.ReadLine());
			
			//Obtenção de dados (t)
			Console.WriteLine("\n\nDigite o tempo: ");
			t=int.Parse(Console.ReadLine());
			
			//Cálculos
			v = d/t;
			
			//Saída
			Console.WriteLine("\nA velocidade é de: " +v);
			
			Console.Write("Pressione qualquer tecla para continue . . . ");
			Console.ReadKey(true);
		}
	}
}
