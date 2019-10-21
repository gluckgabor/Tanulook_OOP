using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        private string name;
        private int classs;
        private bool graduated = false;

        public string GetDescription()
        {
            return name + " => " + classs + "" + (graduated ? "Érettségizett" : "Iskolás");
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetClasss(int classs)
        {
            this.classs = classs;
        }


    }
}
