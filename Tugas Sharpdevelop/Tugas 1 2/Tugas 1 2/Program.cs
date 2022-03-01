/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 01/03/2022
 * Time: 12:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tugas_1_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Nama kamu siapa ? ");
			
			string nama = Console.ReadLine();
			Console.WriteLine("Nama kamu " +nama);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}