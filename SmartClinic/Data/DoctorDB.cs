using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartClinic.Bus;
using SmartClinic.DataObject;

namespace SmartClinic.Data
{
    public class DoctorDB
    {
        /// <summary>
        /// get doctor by dept
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public static List<DataObject.Doctor> GetPatientByDept(string dept)
        {
            using (var db = new ProjectContext())
            {
                var doctorList=db.Doctor.Where(d=>d.Department==dept).ToList();
                return doctorList;
            }
        }

    }
}