using SmartClinic.Bus;
using SmartClinic.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartClinic.Data
{
    public class Tools
    {
        /// <summary>
        /// Validate User Credentials
        /// </summary>
        /// <param name="email">user's email</param>
        /// <param name="password">user's password</param>
        /// <param name="type">type of person who is login</param>
        /// <returns>boolean variable</returns>
        public static bool IsValidCredential(string email, string password, EnumType.UserType type)
        {
            //default is not valid
            bool isValid = false;
            using (var db = new ProjectContext())
            {
                switch (type)
                {

                    case EnumType.UserType.Patient:
                        var patient_user = db.Patient.Where(a => a.Email == email && a.Password == password).FirstOrDefault();

                        isValid = (patient_user == null) ? false : true;

                        break;
                    case EnumType.UserType.Receptionist:
                        var receptionist_user = db.Receptionist.Where(a => a.Email == email && a.Password == password).FirstOrDefault();

                        isValid = (receptionist_user == null) ? false : true;
                        break;

                }
            }
            
            return isValid;
        }

        public static bool ExistEmail(string email, EnumType.UserType type)
        {

            bool exist = false;

            using (var db = new ProjectContext())
            {
                switch (type)
                {

                    case EnumType.UserType.Patient:
                        var patient_user = db.Patient.Where(a => a.Email == email).FirstOrDefault();

                        exist = (patient_user == null) ? false : true;

                        break;
                    case EnumType.UserType.Receptionist:
                        var receptionist_user = db.Receptionist.Where(a => a.Email == email).FirstOrDefault();

                        exist = (receptionist_user == null) ? false : true;
                        break;

                }
            }
            return exist;
        }

    }
}