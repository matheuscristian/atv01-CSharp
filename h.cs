/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 09:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace h
{
	class Program
	{
		public static void Main(string[] args)
		{
			double price, discount;
			
			Console.Write("Digite o preço: ");
			price = double.Parse(Console.ReadLine());
			
			Console.Write("Digite o desconto: ");
			discount = double.Parse(Console.ReadLine());
			
			Console.WriteLine("O preço final é: {0}", price - (price * (discount / 100)));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}