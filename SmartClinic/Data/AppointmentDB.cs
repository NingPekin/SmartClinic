using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Bus;
using SmartClinic.DataObject;

namespace SmartClinic.Data
{
    public class AppointmentDB
    {
        public static List<DataObject.Appointment> GetAppointmentByPatients(int id)
        {
            using (var db = new ProjectContext())
            {
                var appointmentList = db.Appointment.Include("Doctor").Include("Patient").Where(a=>a.Patient.Id==id).ToList();
                
                db.SaveChanges();
                return appointmentList;
            }

            
        }

        public static List<DataObject.Appointment> GetAppointmentByDoctors(int id)
        {
            using (var db = new ProjectContext())
            {
                var appointmentList = db.Appointment.Include("Doctor").Include("Patient").Where(a =>a.Doctor.Id == id).ToList();


              
                return appointmentList;
            }
        }

        public static List<DataObject.Appointment> GetAppointmentByDepartment(string dept)
        {
            using (var db = new ProjectContext())
            {
                var appointmentList = db.Appointment.Include("Doctor").Include("Patient").Where(a => a.Doctor.Department == dept).ToList();

                db.SaveChanges();
                return appointmentList;
            }
        }


    }
}