using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Data;
namespace SmartClinic.Bus
{
    public class Patient : Person
    {
        public Patient(int id, string firstName, string lastName, string email, string password, EnumType.type type, DateTime birthOfDate, long phoneNumber, EnumType.gender gender, List<int> allergyList, List<int> habitList, List<string> surgeryList) : base(id, firstName, lastName, email, password, type)
        {
            this.birthOfDate = birthOfDate;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
            this.allergyList = allergyList;
            this.habitList = habitList;
            this.surgeryList = surgeryList;
        }

        public DateTime birthOfDate  { get; set; }
        public Int64 phoneNumber { get; set; }
        public EnumType.gender gender { get; set; }

        //could change to dictionary
        //list of allergies, 0 no, 1 yes
        public List<int> allergyList { get; set; }

        //list of habits, 0 no, 1 yes
        public List<int> habitList { get; set; }

        //if patient took any surgery before
        public List<String> surgeryList { get; set; }

        //pass object appointment
        //process create new appointment == add it to appointment list
        public void CreateAppointment(Appointment appointment)
        {
            AppointmentCollection.AddAppointmentToList(appointment);
        }

        //pass object appoinment
        //remove appointment from list 
        public void CancelAppointment(Appointment appointment)
        {
            AppointmentCollection.AddAppointmentToList(appointment);
        }

        //send appointment via email
        
        public void SendAppointmentReminder(Appointment appointment)
        {
            //email
            string email = this.email;

        }



    }
}