using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Bus;
using SmartClinic.DataObject;

namespace SmartClinic.Data
{
    public class ReceptionistDB
    {
      /// <summary>
      /// get receptionist object by email
      /// </summary>
      /// <param name="email"></param>
      /// <returns>receptionist</returns>
        public static DataObject.Receptionist GetReceptionistByEmail(string email)
        {
            using (var db = new ProjectContext())
            {
                return db.Receptionist.Where(a => a.Email == email).FirstOrDefault();
            }

        }

        //insert oppcuied time into db
        public static void AddOccupiedTimeToList(DataObject.OccupiedTime occupied)
        {
            //OccupiedTimeCollection.AddOccupiedTimeToList(occupied);
            using (var db = new ProjectContext())
            {
                db.OccupiedTime.Add(occupied);
                db.SaveChanges();
            }

        }
        //delete from db
        public static void RemoveOccupiedTimeFromList(DataObject.OccupiedTime occupied)
        {
            //OccupiedTimeCollection.RemoveOccupiedTimeFromList(occupied);
            using (var db = new ProjectContext())
            {
                db.OccupiedTime.Remove(occupied);
                db.SaveChanges();
            }
        }


    }
}