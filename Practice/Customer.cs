using System;
namespace Practice
{
	public class Customer

	{
        static int instances = 0;


        public Customer()
        {
            instances++;
        }

        public static void GetInstances()
        {
            Console.WriteLine(instances);
        }
    }

	
}

