using SmartClinic.Bus;
using SmartClinic.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SmartClinic.Data
{
    public class OccupiedTimeDB
    {

        //search by doctor object
        public static List<DataObject.OccupiedTime> GetOccupiedTimeByDoctor(DataObject.Doctor doctor)
        {
            using (var db = new ProjectContext())
            {
                var occupiedTime = db.OccupiedTime.Include("Doctor").Where(a => a.Doctor.Id == doctor.Id).ToList();
                db.SaveChanges();
                return occupiedTime;
            }


        }



    }
}