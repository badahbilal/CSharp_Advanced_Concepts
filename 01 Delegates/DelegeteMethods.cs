using System;
using System.Collections.Generic;
using System.Text;


namespace _01_Delegates
{
    public static class DelegeteMethods
    {

        public static bool AugmentByTask(Employee employee)
        {
            return employee.Task >= 300 ? true : false;
        }


        public static bool AugmentByExperience(Employee employee)
        {
            return employee.Experience >= 3 ? true : false;
        }
    }
}
