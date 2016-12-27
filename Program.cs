using System;

namespace Application
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string input = Convert.ToString(Console.ReadLine());

			char[] cha = input.ToCharArray();

			for (int i = input.Length -1; i >= 0; i--)
			{
				Console.Write(cha[i]);
			}
		}

	}
}
