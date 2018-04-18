using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Bus;

namespace SmartClinic.Data
{
    public class AppointmentDB
    {
        public static List<Appointment> GetAppointmentByPatients(int id)
        {
            List<Appointment> appointmentList = new List<Appointment>();

            return appointmentList;
        }

        public static List<Appointment> GetAppointmentByDoctors(int id)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            return appointmentList;
        }

        public static List<Appointment> GetAppointmentByDepartment(string dept)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            return appointmentList;
        }
        //create new appointment into db
        public static void AddAppointmentToList(Appointment appointment)
        {

        }

        public static void RemoveAppointmentToList(Appointment appointment)
        {

        }

    }
}