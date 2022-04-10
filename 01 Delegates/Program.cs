using System;
using System.Collections.Generic;


namespace _01_Delegates
{

    delegate bool siAugmentDelegate(Employee employee);
    class Program
    {
        ////Delegate 
        /*
        En fait, un type delegate est un concept très simple : 
        c’est un type qui permet de référencer une méthode d’une classe.
        Grâce aux delegates, vous pouvez transmettre une méthode comme paramètre
        (c’est un peu l’équivalent des pointeurs de fonction en C / C++ par exemple).

        Un type délégué(delegate en anglais) est toujours associé à la signature d’une méthode.
       Seules les méthodes ayant la même signature pourront être utilisées avec ce délégué.

        delegate est aussi un mot clé du langage C# (csharp) qui permet de déclarer un delegate.
        



        //Create  methode
        public static void sum(int a, int b)
        {
            Console.WriteLine("Sum is : " + (a + b));
        }

        //Create Delegate
        public delegate void mySumDelegate(int a, int b);
        static void Main(string[] args)
        {
            // instantiate the delegate and assign the method to it
            mySumDelegate mySumDelegate = new mySumDelegate(sum);

            // call the delegate
            mySumDelegate(1, 3);
            Console.WriteLine("Hello World!");
        }

        */

        public static bool AugmentByExperience(Employee employee)
        {
            return employee.Experience >= 3 ? true : false;  
        }

        public static bool AugmentByTask(Employee employee)
        {
            return employee.Task >= 300 ? true : false;
        }

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
            siAugmentDelegate siAugmentExperience = new siAugmentDelegate(AugmentByExperience);
            Employee.Augmentation(myEmployees, siAugmentExperience);
            Console.WriteLine("=====================================");
            Console.WriteLine("Task");
            siAugmentDelegate siAugmentTask = new siAugmentDelegate(AugmentByTask);
            Employee.Augmentation(myEmployees, siAugmentTask);


            
            Console.ReadKey();
        }
    }

    
}
