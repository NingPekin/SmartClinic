using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Data;
namespace SmartClinic.Bus
{
    public class Receptionist : Person
    {
        public Receptionist(int id, string firstName, string lastName, string email, string password, EnumType.UserType type) : base(id, firstName, lastName, email, password, type)
        {
        }
        
        //pass occupied object
        //add occupied time into list

        public void SetOccupiedTime(OccupiedTime occupied)
        {
            ReceptionistDB.SetOccupiedTime(occupied);
        }

        public void DeleteOccupiedTime(OccupiedTime occupied)
        {
            ReceptionistDB.DeleteOccupiedTime(occupied);

        }



    }
}