/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 09:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace g
{
	class Program
	{
		public static void Main(string[] args)
		{
			string name;
			int age;
			
			Console.Write("Qual o seu nome: ");
			name = Console.ReadLine();
			
			Console.Write("Qual sua idade: ");
			age = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Seu nome é {0}, sua idade é {1}.", name, age);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}