using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartClinic.Bus
{
    public class Person
    {
        public Person(int id, string firstName, string lastName, string email, string password, EnumType.type type)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            this.email = email;
            this.password = password;
            this.type = type;
        }

        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        //type 0: patient 
        //type 1: receptionist
        public EnumType.type type { get; set; }

        public void Login(string email,string password)
        {

        }

        public void Logout(Person person)
        {

        }

        public void ChangePassword()
        {

        }

        


    }
}