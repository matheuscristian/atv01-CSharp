/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 09:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace j
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite seu endereço na ordem rua, número/complemento, bairro, cidade, estado:");
			
			string rua = Console.ReadLine();
			string num = Console.ReadLine();
			string bai = Console.ReadLine();
			string cid = Console.ReadLine();
			string est = Console.ReadLine();
	
			Console.WriteLine("Seu endereço é: {0}, {1}, {2}, {3}, {4}", rua, num, bai, cid, est);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}