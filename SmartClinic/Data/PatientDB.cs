using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Bus;
using SmartClinic.DataObject;
using System.Net.Mail;
using System.Text;
using System.Net;

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

        //insert new patient into db
        public static void Register(DataObject.Patient patient)
        {
            using (var db = new ProjectContext())
            {
            
                db.Patient.Add(patient);
                db.SaveChanges();
            }

        }
        /// <summary>
        /// make appointment,add to list and update db
        /// </summary>
        /// <param name="appointment">object of appointment</param>

        //pass object appointment
        //process create new appointment 
        public void CreateAppointment(DataObject.Appointment appointment)
        {
            //AppointmentCollection.AddAppointmentToList(appointment);
            using (var db = new ProjectContext())
            {
                db.Appointment.Add(appointment);
                db.SaveChanges();
            }

        }

        //pass object appoinment
        //remove appointment from list 
        public void CancelAppointment(DataObject.Appointment appointment)
        {
            //AppointmentCollection.RemoveAppointmentToList(appointment);
            using (var db = new ProjectContext())
            {
                db.Appointment.Remove(appointment);
                db.SaveChanges();
            }
        }

        //send appointment via email

        //public static void SendAppointmentReminder(DataObject.Appointment appointment)
        //{
        //    //email
        //    //string email = this.email;


        //    var fromAddress = new MailAddress("wn0858@gmail.com", "Smart Clinic");
        //    var toAddress = new MailAddress(appointment.Patient.Email, appointment.Patient.FirstName);
        //    const string fromPassword = "password";
        //    const string subject = "New Appointment Created";
        //    string body = "Date: "+appointment.Date+"\n";
        //    body += "Time: " + appointment.Time+"\n";
        //    body += "Patient Name" + appointment.Patient.FirstName + "," + appointment.Patient.LastName + "\n";
        //    body += "Doctor: " + appointment.Doctor.Name;
               
        //    var smtp = new SmtpClient
        //    {
        //        Host = "smtp.gmail.com",
        //        Port = 587,
        //        EnableSsl = true,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        //    };
        //    using (var message = new MailMessage(fromAddress, toAddress)
        //    {
        //        Subject = subject,
        //        Body = body
        //    })
        //    {
        //        smtp.Send(message);
        //    }

        //}


    }
}