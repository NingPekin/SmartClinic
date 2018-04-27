using SmartClinic.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartClinic
{
    public partial class Patient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetDoctorsList();
        }

        void GetDoctorsList()
        {
            string options = string.Empty;

            using (var db = new ProjectContext())
            {
                var query = db.Doctor.ToList();

                foreach(var doctor in query)
                {
                    options += String.Format("<option value=\"{0}\" >{1}</option>", doctor.Id, doctor.Name);
                }

                doctorsList.Text = options;
            }
        }
    }
}