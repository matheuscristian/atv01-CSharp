/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 09:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace f
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um número real: ");
			double n = double.Parse(Console.ReadLine());
			
			Console.WriteLine(n.ToString("0.00"));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}