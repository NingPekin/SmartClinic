using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartClinic.Bus
{
    public class Appointment
        
    {
        public Appointment(int id, Patient patient, Doctor docter, DateTime date, int time)
        {
            this.id = id;
            this.patient = patient;
            this.docter = docter;
            this.date = date;
            this.time = time;
        }

        private int id { get; set; }
        private Patient patient { get; set; }
        private Doctor docter { get; set; }

        private DateTime date { get; set; }
        private int time { get; set; }

        public List<Appointment> GetAppointmentByPatients()
        {
            List<Appointment> appointmentList = new List<Appointment>();
            return appointmentList;
        }

        public List<Appointment> GetAppointmentByDocters()
        {
            List<Appointment> appointmentList = new List<Appointment>();
            return appointmentList;
        }

        public List<Appointment> GetAppointmentByCategory()
        {
            List<Appointment> appointmentList = new List<Appointment>();
            return appointmentList;
        }

        public List<Appointment> AddAppointmentToList(Appointment appointment)
        {
            List<Appointment> appointmentList = new List<Appointment>();



            appointmentList.Add(appointment);
            return appointmentList;
        }



    }
}