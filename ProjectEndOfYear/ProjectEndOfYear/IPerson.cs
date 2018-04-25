using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEndOfYear
{
    interface IPerson
    {
         string ID { get; set; }
         string Name { get; set; }   
         DateTime DOB { get; set; }
         string Type { get; set; }
         string Department { get; set; }
         string Address { get; set; } 
    }
}
