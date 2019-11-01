using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Startup
    {
        public static void Main()
        {
            var departments = new List<Department>();

            var doctors = new List<Doctor>();

            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] info = command.Split();
                var departmentName = info[0];
                var nameDoctor = info[1];
                var surnameDoctor = info[2];
                var patient = info[3];

                var department = new Department(departmentName);

                AddDepartment(departments, department);

                if (department.Patients.Count < 60)
                {
                    AddsPatientToDepartment(departments, departmentName, patient);

                    var doctor = new Doctor(nameDoctor, surnameDoctor);

                    AddDoctor(doctors, doctor);

                    AddsPatientToDoctor(doctors, nameDoctor, surnameDoctor, patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] info = command.Split();

                PrintResult(departments, doctors, info);

                command = Console.ReadLine();
            }
        }

        private static void PrintResult(List<Department> departments, List<Doctor> doctors, string[] info)
        {
            if (info.Length == 1)
            {
                var department = departments
                    .Where(y => y.Name == info[0])
                    .FirstOrDefault();

                Console.WriteLine(string.Join(Environment.NewLine, department.Patients));
            }
            else if (info.Length == 2 && int.TryParse(info[1], out int room))
            {
                var patients = departments
                    .Where(y => y.Name == info[0])
                    .Select(x => x.Rooms[room])
                    .FirstOrDefault().BedsBisy;

                Console.WriteLine(string.Join(Environment.NewLine, patients.OrderBy(x => x)));
            }
            else
            {
                var doctor = doctors
                     .Where(x => x.Name == info[0])
                     .Where(y => y.Surname == info[1])
                     .FirstOrDefault();

                var result = doctor.Patients.OrderBy(x => x).ToArray();

                Console.WriteLine(string.Join(Environment.NewLine, result));
            }
        }

        private static void AddDepartment(List<Department> departments, Department department)
        {
            if (!departments.Contains(department))
            {
                departments.Add(department);
            }
        }

        private static void AddsPatientToDepartment(List<Department> departments, string departmentName, string patient)
        {
            foreach (var item in departments)
            {
                if (item.Name == departmentName)
                {
                    item.AddPatient(new Patient(patient));
                }
            }
        }

        private static void AddsPatientToDoctor(List<Doctor> doctors, string nameDoctor, string surnameDoctor, string patient)
        {
            foreach (var item in doctors)
            {
                if (item.Name == nameDoctor
                 && item.Surname == surnameDoctor)
                {
                    item.Patients.Add(patient);
                }
            }
        }

        private static void AddDoctor(List<Doctor> doctors, Doctor doctor)
        {
            if (!doctors.Contains(doctor))
            {
                doctors.Add(doctor);
            }
        }
    }
}
