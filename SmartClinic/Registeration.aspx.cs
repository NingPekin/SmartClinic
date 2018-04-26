using SmartClinic.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartClinic
{
    public partial class Registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Register(object sender, EventArgs e)
        {
            
            using (var db = new ProjectContext())
            {

                var labdaQuery = db.Patient.Where(u=>u.FirstName.Length > 2).ToList();

                foreach (var row in labdaQuery)
                {
                    Response.Write(row.Email);
                }
            }
        }
    }
}