/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 09:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace i
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um texto: ");
			string n = Console.ReadLine();
			
			Console.WriteLine("O tamanho do texto é: {0}", n.Length);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}