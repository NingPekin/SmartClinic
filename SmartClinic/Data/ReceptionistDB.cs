using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Bus;

namespace SmartClinic.Data
{
    public class ReceptionistDB
    {

        public static void SetOccupiedTime(OccupiedTime occupied)
        {
            OccupiedTimeCollection.AddOccupiedTimeToList(occupied);
        }

        public static void DeleteOccupiedTime(OccupiedTime occupied)
        {
            OccupiedTimeCollection.RemoveOccupiedTimeFromList(occupied);
        }

    }
}