using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs325_coreproject
{
    class Business : Person
    {
        private string name;
        private string ein;
        private string address;
        private string email;
        private string phone;


        public Business(string ein, string name, string address, string email, string phone)
        {
            setEin(ein);
            setName(name);
            setAddress(address);
            setEmail(email);
            setPhone(phone);
        }

        public string getName(){ return name;}
        public void setName(string name){ this.name = name;}
        public string getEin(){ return ein;}
        public void setEin(string ein){ this.ein = ein;}

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getPhone()
        {
            return phone;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }
    }
}
