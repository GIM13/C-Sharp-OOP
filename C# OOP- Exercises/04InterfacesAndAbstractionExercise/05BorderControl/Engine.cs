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
                    string id = command[2];

                    subjects.Add(new Citizen(name, age, id));
                }
                else if (command.Count() == 2)
                {
                    string model = command[0];
                    string id = command[1];

                    subjects.Add(new Robot(model, id));
                }

                command = Console.ReadLine().Split();
            }

            string fakeIds = Console.ReadLine();

            foreach (var subject in subjects)
            {
                if (subject.Id.EndsWith(fakeIds))
                {
                    Console.WriteLine(subject.Id);
                }
            }
        }
    }
}
