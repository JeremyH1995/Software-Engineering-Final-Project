using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs325_coreproject
{
    abstract class Employee : Person
    {
        private string eid;

        public string getEid(){ return eid;}
        public void setEid(string eid){ this.eid = eid;}
           
        
    }
}
