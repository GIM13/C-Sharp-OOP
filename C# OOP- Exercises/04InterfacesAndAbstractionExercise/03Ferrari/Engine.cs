using System;

namespace _03Ferrari
{
    public class Engine
    {
        public static void Start()
        {
            string nameDriver = Console.ReadLine();

            var ferrari = new Ferrari(nameDriver);

            Console.WriteLine(ferrari);
        }
    }
}
