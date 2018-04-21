using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Bus;
using SmartClinic.DataObject;

namespace SmartClinic.Data
{
    public class PatientDB
    {

        //insert new appointment into db
        //public static void CreateAppointment(Appointment appointment)
        //{

        //}

        //public void CancelAppointment(Appointment appointment)
        //{

        //}

        public static DataObject.Patient GetPatientById(int id)
        {
            using (var db = new ProjectContext())
            {
                return db.Patient.Find(id);
            }
        }

        //change to get person
        public static DataObject.Patient GetPatientByEmail(string email)
        {
            using (var db = new ProjectContext())
            {
                return db.Patient.Where(a => a.Email == email).FirstOrDefault();
            }

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