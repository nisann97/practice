using System;
namespace Practice
{
	public class Person
	{
		public static int Age { get; set; }

		public static void Showtext()
		{
			Console.WriteLine("Text");
		}

		public static void Test()
		{
			Console.WriteLine("Salam");
		}


		static Person()
		{
			Console.WriteLine("Welcome");
		}

		public Person()
		{
			Console.WriteLine("Welcome");
		}
	}
}

