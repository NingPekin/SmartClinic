using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Data;

namespace SmartClinic.Bus
{
    public class OccupiedTimeCollection
    {
        public static List<OccupiedTime> OccupiedTimeList { get; set; }

       
        public static void AddOccupiedTimeToList(OccupiedTime occupiedTime)
        {
            OccupiedTimeList.Add(occupiedTime);
            OccupiedTimeDB.AddOccupiedTimeToList(occupiedTime);

        }

        public static void RemoveOccupiedTimeFromList(OccupiedTime occupiedTime)
        {
            OccupiedTimeList.Remove(occupiedTime);
            OccupiedTimeDB.RemoveOccupiedTimeFromList(occupiedTime);
        }

        //pass object of doctor??(in html it may be a list of doctor name, perhaps we should have a list of doctors or search doctor by name??? )
        //return object occupied time
        public static List<OccupiedTime> GetOccupiedTimeByDoctor(Doctor doctor)
        {
            List<OccupiedTime> occupiedTime = OccupiedTimeDB.GetOccupiedTimeByDoctor(doctor);
            return occupiedTime;
        }



    }
}