using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Data;

namespace SmartClinic.Bus
{
    public class Person
    {
        public Person(int id, string firstName, string lastName, string email, string password, EnumType.UserType type)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            this.email = email;
            this.password = password;
            this.type = type;
        }

        public Person()
        {
        }

        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string email { get; set; }
        public string password { get; set; }

        //type 0: patient 
        //type 1: receptionist
        public EnumType.UserType type { get; set; }

        //pass id to data layer
        //return an object of person
        public Person GetPersonById(int id)
        {
            Person person =PersonDB.GetPersonById(id);
            return person;
           
        }

        //pass email to data layer
        //return person id
        public int GetPersonIdByEmail(string email)
        {
            int id=PersonDB.GetPersonIdByEmail(email);
            return id;
        }

        //pass email and password to check if they are match the ones in db, through the function in data layer
        //return true:valid credential 
        //return false:invalid credential 


        //pass email to data layer to check if email is existed in db
        //return true:email exist
        //return false:email not exist
        public bool ExistEmail(string email)
        {
            bool exist = false;
            if(PersonDB.ExistEmail(email))
            {
                exist = true;
            }

            return exist;

        }

        //public void Logout(Person person)
        //{

        //}

        //pass new password 
        public void ChangePassword(string newPassword)
        {
            PersonDB.ChangePassword(newPassword);
        }

        //pass person object to data layer
        public void Register(Person person)
        {
            PersonDB.Register(person);
        }



    }
}