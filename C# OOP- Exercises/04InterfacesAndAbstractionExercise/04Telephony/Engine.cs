using System;
using System.Linq;

namespace _04Telephony
{
    public class Engine
    {
        public static void Start()
        {
            string[] numbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in numbers)
            {
                if (number.Any(char.IsLetter))
                {
                    Console.WriteLine("Invalid number!");
                }
                else
                {
                    var smartPhone = new Smartphone(number);

                    Console.WriteLine(smartPhone.Call());
                }
            }

            string[] sites = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var site in sites)
            {
                if (site.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    var smartPhone = new Smartphone(site);

                    Console.WriteLine(smartPhone.Browse() +"!");
                }
            }
        }
    }
}
