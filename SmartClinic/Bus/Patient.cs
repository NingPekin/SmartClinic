using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartClinic.Bus
{
    public class Patient : Person
    {
        public Patient(int id, string firstName, string lastName, string email, string password, EnumType.type type, DateTime birthOfDate, long phoneNumber, List<int> allergyList, List<int> habitList, List<string> surgeryList) : base(id, firstName, lastName, email, password, type)
        {
            this.birthOfDate = birthOfDate;
            this.phoneNumber = phoneNumber;
            this.allergyList = allergyList;
            this.habitList = habitList;
            this.surgeryList = surgeryList;
        }


        public DateTime birthOfDate  { get; set; }
        public Int64 phoneNumber { get; set; }
       
        //could change to dictionary
        //list of allergies, 0 no, 1 yes
        public List<int> allergyList { get; set; }

        //list of habits, 0 no, 1 yes
        public List<int> habitList { get; set; }

        //if patient took any surgery
        public List<String> surgeryList { get; set; }

        public void CreateAppointment(Appointment appoinment)
        {

        }

        public void CancelAppointment(Appointment appointment)
        {

        }

        public void SendAppointmentReminder(Appointment appointment)
        {

        }

      


    }
}