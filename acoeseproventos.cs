/*
 * Criado por SharpDevelop.
 * Usuário: matheus
 * Data: 05/04/2021
 * Hora: 19:35
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace acoesMatheus
{
	class Program
	{
		public static void Main(string[] args)
		{	
			//Introdução
			Console.ForegroundColor=ConsoleColor.Green;	//Muda cor da fonte
			Console.WriteLine("◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►");
			Console.ForegroundColor=ConsoleColor.White;
			Console.WriteLine("◄►	Bem vindo a calculadora de proventos! ◄►");
			Console.ForegroundColor=ConsoleColor.Green;	
			Console.WriteLine("◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►◄►");
			Console.ForegroundColor=ConsoleColor.White;

			//Variáveis float, por conta de serem decimais.
			float precoAcao, dividendo, quantiAcoes, dividendYield, totalProventos;
			
			//Inserção de dados
			Console.WriteLine("\nDigite o preço da ação:");
			Console.ForegroundColor=ConsoleColor.Red;
			precoAcao=float.Parse(Console.ReadLine());
			Console.ForegroundColor=ConsoleColor.White;
			
			Console.WriteLine("\nDigite o dividendo:");
			Console.ForegroundColor=ConsoleColor.Red;
			dividendo=float.Parse(Console.ReadLine());
			Console.ForegroundColor=ConsoleColor.White;
			
			Console.WriteLine("\nDigite a quantidade de ações:");
			Console.ForegroundColor=ConsoleColor.Red;
			quantiAcoes=float.Parse(Console.ReadLine());
			Console.ForegroundColor=ConsoleColor.White;
				
			//Confirmação dos dados
			Console.WriteLine("\n\nOs dados inseridos foram:");
			
			Console.ForegroundColor=ConsoleColor.Red;
			Console.WriteLine("Preço da ação: " +precoAcao);
			Console.WriteLine("Dividendo: " +dividendo);
			Console.WriteLine("Quantia de ações: " +quantiAcoes);
			Console.ForegroundColor=ConsoleColor.White;
			
			//Cálculos
			
			/* "paga dividendo a cada 4 meses"
			 * 4 meses = 1/3 ano 
			 */
			
			dividendYield = ((3*dividendo)/precoAcao)*100;
			
			totalProventos = 3*dividendo*quantiAcoes;
			
			//Conclusão
			Console.ForegroundColor=ConsoleColor.Blue;
			Console.WriteLine("\nO Dividend Yield é: " +dividendYield.ToString("N2")+"%");
			Console.WriteLine("E o Total de Proventos é de: " +totalProventos);
			Console.ForegroundColor=ConsoleColor.White;
			
			
			Console.Write("\n\nPressione qualquer tecla...");
			Console.ReadKey(true);
		}
	}
}