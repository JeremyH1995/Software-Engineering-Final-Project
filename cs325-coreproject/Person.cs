using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs325_coreproject
{
    abstract class Person
    {
        private string firstName;
        private string lastName;
        private string password;


        public string getFirstName() {
            return firstName;        
        }
        
        public string getLastName() {
            return lastName;
        }

        public string getFullName() {
            return string.Format("{0} {1}", this.firstName, this.lastName);
        }


        public void setFirstName(string name) {
            this.firstName = name;
        }

        public void setLastName(string name) {
            this.lastName = name;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string p)
        {
            password = p;
        }

    }


    



}
