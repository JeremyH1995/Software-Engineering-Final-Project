using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs325_coreproject
{
    class Client : Person
    {
        private string address;
        private string email;
        private string phone;
        private string primaryContact;

        public Client(string first, string last, string email, string phone, string contact)
        {
            setFirstName(first);
            setLastName(last);
            setPhone(phone);
            setEmail(email);
            setContact(contact);
        }

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

        public string getContact()
        {
            return primaryContact;
        }

        public void setContact(string contact)
        {
            primaryContact = contact;
        }

    }
}
