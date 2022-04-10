using System;
using System.Collections.Generic;


namespace _01_Delegates
{

    public delegate bool siAugmentDelegate(Employee employee);
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Employee> myEmployees = new List<Employee>()
            {
                new Employee{Id =1, Name="Badah", Task=100 , Salary= 30000 , Experience = 3},
                new Employee{Id =2, Name="Badah 2", Task=300 , Salary= 10000 , Experience = 2},
                new Employee{Id =3, Name="Badah 3", Task=150 , Salary= 5000 , Experience = 4},
                new Employee{Id =4, Name="Badah 4", Task=200 , Salary= 40000 , Experience = 1},
                new Employee{Id =5, Name="Badah 5", Task=1000 , Salary= 100000 , Experience = 10}
            };
            Console.WriteLine("Experience");
            
            siAugmentDelegate siAugmentExperience = new siAugmentDelegate(DelegeteMethods.AugmentByExperience);
            Employee.Augmentation(myEmployees, siAugmentExperience);
            
            Console.WriteLine("=====================================");
            
            Console.WriteLine("Task");
            
            siAugmentDelegate siAugmentTask = new siAugmentDelegate(DelegeteMethods.AugmentByTask);
            Employee.Augmentation(myEmployees, siAugmentTask);

            Console.ReadKey();
        }
    }

}
