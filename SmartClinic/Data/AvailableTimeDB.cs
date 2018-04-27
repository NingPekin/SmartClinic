using SmartClinic.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartClinic.Data
{
    public class AvailableTimeDB
    {

        public static List<DataObject.AvailableTime> GetAvailableTimeByDoctor(DataObject.Doctor doctor)
        {
            using (var db = new ProjectContext())
            {
                var availableTime = db.AvailableTime.Include("Doctor").Where(a => a.Doctor.Id == doctor.Id).ToList();
                db.SaveChanges();
                return availableTime;
            }


        }
    }
}