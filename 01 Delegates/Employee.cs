using System;
using System.Collections.Generic;
using System.Text;


namespace _01_Delegates
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Task { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void Augmentation(List<Employee> employees, siAugmentDelegate siAugment)
        {
            foreach (var employe in employees)
            {
                if (siAugment.Invoke(employe))
                {
                    Console.WriteLine($"Bonjour {employe.Name} vous avez une augmentation de 1000 dh : {employe.Salary+1000}");
                }
            }
        }
    }
}
