using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Department : IComparable<Department>
    {
        public Department(string name)
        {
            Name = name;
            Rooms = new Dictionary<int, Room>();
            Patients = new List<string>();
        }

        public string Name { get; set; }

        public Dictionary<int,Room> Rooms { get; set; }

        public List<string> Patients { get; set; }

        public void AddPatient(Patient patient)
        {
            if (!Rooms.Any())
            {
                Rooms.Add(Rooms.Count + 1, new Room());
            }

            if (Patients.Count < 60)
            {
                if (Rooms[Rooms.Count].BedsBisy.Count == 3
                  && Rooms.Count < 20)
                {
                    Rooms.Add(Rooms.Count + 1, new Room());
                }

                Rooms[Rooms.Count].BedsBisy.Add(patient.Name);

                Patients.Add(patient.Name);
            }
        }

        public int CompareTo(Department other)
        {
           return Name.CompareTo(other.Name);
        }
    }
}
