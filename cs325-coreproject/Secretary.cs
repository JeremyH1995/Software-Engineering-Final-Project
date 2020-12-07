using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs325_coreproject
{
    class Secretary : Employee
    {
        private static int count = 0;
        public Secretary(string eid, string first, string last)
        {
            setEid(eid);
            setFirstName(first);
            setLastName(last);
            count++;
        }

        public static int getCount()
        {
            return count;
        }
    }
}
