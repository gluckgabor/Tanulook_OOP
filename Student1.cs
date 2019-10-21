using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        public static string name;
        private int askedPerformanceGrade;
        public static int performanceGrade;

        public static string GetDescription()
        {
            return name + " osztályzata " + performanceGrade;
        }

        public void SetName(string name)
        {
            name = name;  //this.
        }

        public void SetPerformanceGrade(int askedPerformanceGrade)
        {
            performanceGrade = askedPerformanceGrade;  //this.
        }
    }
}
