using System;

namespace ке
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			EmptyClass cl = new EmptyClass();
			cl.slovo = Console.ReadLine();
			cl.Proverka();
			cl.PSevra();
			cl.Gamma();
			cl.Res();
			Console.ReadKey();

		}
	}
}
