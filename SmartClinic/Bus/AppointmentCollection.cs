using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Data;

namespace SmartClinic.Bus
{
    public class AppointmentCollection
    {
        public static List<Appointment> appointmentList { get; set; }

        //pass patient id from html to data layer
        //return appointment list
        public static List<Appointment> GetAppointmentByPatients(int id)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            appointmentList = AppointmentDB.GetAppointmentByPatients(id);
            return appointmentList;
        }

        //pass doctor id from html to data layer
        // return appointment list
        public static List<Appointment> GetAppointmentByDoctors(int id)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            appointmentList = AppointmentDB.GetAppointmentByDoctors(id);
            return appointmentList;
        }

        //pass department name from html to data layer
        // return appointment list
        public static List<Appointment> GetAppointmentByDepartment(string dept)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            appointmentList = AppointmentDB.GetAppointmentByDepartment(dept);
            return appointmentList;
        }

        //pass appointment info from html as object to data layer, and process/insert into db
        public static void AddAppointmentToList(Appointment appointment)
        {
            appointmentList.Add(appointment);
            AppointmentDB.AddAppointmentToList(appointment);

        }

        public static void RemoveAppointmentToList(Appointment appointment)
        {
            appointmentList.Remove(appointment);
            AppointmentDB.RemoveAppointmentToList(appointment);
        }
    }
}