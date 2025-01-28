/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace isis
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um inteiro: ");
			int n = int.Parse(Console.ReadLine());
			
			Console.WriteLine(n);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}