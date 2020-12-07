using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs325_coreproject
{
    class Manager : Employee
    {
        public Manager(string eid, string first, string last)
        {
            setEid(eid);
            setFirstName(first);
            setLastName(last);
        }
    }
}
