using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEndOfYear
{
    public abstract class Person
    {
         public string ID { get; set; }
         public string Name { get; set; }
         public DateTime DOB { get; set; }
         public string Type { get; set; }
         public string Department { get; set; }
         public string Address { get; set; }

        public Person(string iD, string name, DateTime dOB, string type, string department, string address)
        {
            ID = iD;
            Name = name;
            DOB = dOB;
            Type = type;
            Department = department;
            Address = address;
        }

        public override string ToString()
        {
            return String.Format("ID : "+ID +"\nName : "+ Name+"\nDOB : "+ DOB +"\nStudent Type : "+ Type);
        }
    }
}
