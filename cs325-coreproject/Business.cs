using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs325_coreproject
{
    class Business : Client
    {
          private string name;
          private string ein;

        public string getName(){ return name;}
        public void setName(string name){ this.name = name;}
        public string getEin(){ return ein;}
        public void setEin(string ein){ this.ein = ein;}
    }
}
