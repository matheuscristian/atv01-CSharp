/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 09:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace d
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool validation;
			string input;
			
			Console.Write("Digite sim ou não: ");
			input = Console.ReadLine().Trim().ToLower();
			
			if (input == "sim") {
				validation = true;
			} else {
				validation = false;
			}
			
			Console.WriteLine(validation);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}