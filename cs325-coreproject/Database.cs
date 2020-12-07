using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs325_coreproject
{
    static class Database
    {
        private static Person loggedin = null;

        public static void login(Person p)
        {
            loggedin = p;
        }

        public static void logout()
        {
            loggedin = null;
        }

        private static List<Person> personList = new List<Person>();


        public static void addPerson(Person person)
        {
            personList.Add(person);
        }

        public static void removePerson(Person person)
        {
            personList.Remove(person);
        }

        public static List<Person> getPeopleList()
        {
            return personList;
        }

        public static List<Client> generateClientList()
        {
            List<Client> clients = new List<Client>();
            foreach (Person person in personList)
            {
                if (person.GetType() == typeof(Client))
                {
                    clients.Add((Client)person);
                }
            }
            return clients;
        }

        public static List<Employee> generateEmployeeList()
        {
            List<Employee> employees = new List<Employee>();
            foreach (Person person in personList)
            {
                if (person.GetType() == typeof(Employee))
                {
                    employees.Add((Employee)person);
                }
            }
            return employees;
        }

    }
}
