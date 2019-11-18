using System;
using System.Linq;
using System.Collections.Generic;

namespace _05BorderControl
{
    public class Engine
    {
        public static void Start()
        {
            var command = Console.ReadLine().Split();

            var subjects = new List<ISubjects>();

            while (command[0] != "End")
            {
                if (command.Count() == 3)
                {
                    string name = command[0];
                    int age = int.Parse(command[1]);
                    long id  = long.Parse(command[2]);

                    subjects.Add(new Citizen(name,age,id));
                }
                else if (command.Count() == 2)
                {
                    string model = command[0];
                    long id = long.Parse(command[1]);

                    subjects.Add(new Robot(model, id));
                }

                command = Console.ReadLine().Split();
            }

            string fakeIds = Console.ReadLine();

            int count = fakeIds.Length;

            if (count > 0)
            {
                foreach (var subject in subjects)
                {
                    double last = subject.Id % Math.Pow(10, count);

                    if (last == long.Parse(fakeIds))
                    {
                        Console.WriteLine(subject.Id);
                    }
                }
            }
        }
    }
}
