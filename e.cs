/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 09:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace e
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um caractere: ");
			char n = Console.ReadKey().KeyChar;
			
			Console.WriteLine("\n" + n);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}