using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEndOfYear
{

    public class MyStaff : Person
    {
        public decimal Salary { get; set; }
        public int Year { get; set; }

        public MyStaff(string iD, string name, DateTime dOB, string type, string department, string address,decimal salary, int year) : base(iD,name,dOB,type,department,address)
        {
            Salary = salary;
            Year = year;
        }

        public MyStaff(string iD, string name, DateTime dOB, string type, string department, string address) : base(iD, name, dOB, type, department, address)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public partial class Staff
    {
        public override string ToString()
        {
            return String.Format("ID : " + ID + "\nName : " + Name + "\nDOB : " + DOB + "\nStudent Type : " + Type);
        }
    }
}
