using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEndOfYear
{
    class MyStudentClass1 : Person
    {
        public int Year { get; set; }
        public string StudentCourse { get; set; }

        public MyStudentClass1(string iD, string name, DateTime dOB, string type, string department, string address, int year, string studentCourse): base(iD, name, dOB, type, department, address)
        {
            Year = year;
            StudentCourse = studentCourse;
        }

        public MyStudentClass1(string iD, string name, DateTime dOB, string type, string department, string address) : base(iD, name, dOB, type, department, address)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
