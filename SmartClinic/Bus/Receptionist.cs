using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartClinic.Bus
{
    public class Receptionist : Person
    {
        public Receptionist(int id, string firstName, string lastName, string email, string password, EnumType.type type) : base(id, firstName, lastName, email, password, type)
        {
        }


        public void CreateAppointment(Patient patient, Appointment appointment)
        {

        }

        public void CancelAppointment(Patient patient, Appointment appointment)
        {

        }

        public void SetOccupiedTime(OccupiedTime occupied)
        {

        }

        public void DeleteOccupiedTime(OccupiedTime occupied)
        {

        }



    }
}