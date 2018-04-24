using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEndOfYear
{
    public partial class StaffTBL
    {
        public override string ToString()
        {
            return String.Format(ID + Name);
        }
    }

    public class MyStaff : StaffTBL
    {

    }
}
