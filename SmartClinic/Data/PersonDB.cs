using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Bus;
namespace SmartClinic.Data
{
    public class PersonDB
    {
        public static Person GetPersonById(int id)
        {
            Person person = new Person();
            return person;
        }

        public static int GetPersonIdByEmail(string email)
        {
            int id=0;
            
            return id;

        }


        public static bool IsValidCredential(string email, string password)
        {
            //default is not valid
            bool isValid = false;



            return isValid;
        }

        public static bool ExistEmail(string email)
        {

            bool exist = false;
            return exist;
        }

        //public void Logout(Person person)
        //{

        //}

        //update password with new password in db
        public static void ChangePassword(string newPassword)
        {

        }

        //insert new person into db
        public static void Register(Person person)
        {

        }
    }
}